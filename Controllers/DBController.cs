using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Common;
using System.Data.SqlTypes;
using System.Drawing.Imaging;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using Newtonsoft.Json;
using MyDBSM.Models;
using System.Diagnostics.SymbolStore;

namespace MyDBSM.Controllers
{
    public static class DBController
    {
        public static Database db { get; set; }
        public static void CreateDatabase(string name)
        {
            if (String.IsNullOrEmpty(name)) throw new Exception("Name cannot be blank!");
            db = new Database(name);
        }
        public static void DeleteDatabase()
        {
            db = null;
        }
        public static void RenameDatabase(string name)
        {
            if (String.IsNullOrEmpty(name)) throw new Exception("Name cannot be blank!");
            db.Name = name;
        }
        public static void ImportDatabase(string path)
        {

            db = JsonConvert.DeserializeObject<Database>(File.ReadAllText(path), new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.Auto,
                NullValueHandling = NullValueHandling.Ignore,
            });

            //string json = File.ReadAllText(path);

            //db = JsonConvert.DeserializeObject<Database>(json);

        }
        public static void ExportDatabase(string path)
        {
            JsonSerializer serializer = new JsonSerializer();
            serializer.NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore;
            serializer.TypeNameHandling = Newtonsoft.Json.TypeNameHandling.Auto;
            serializer.Formatting = Newtonsoft.Json.Formatting.Indented;

            using (StreamWriter sw = new StreamWriter(path))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, db, typeof(Database));
            }



            //string json = JsonConvert.SerializeObject(db);

            //File.WriteAllText(path, json);
        }
        public static void AddTable(string name)
        {
            foreach (var table in db.Tables)
            {
                if (table.Name.ToLower() == name.ToLower()) throw new Exception("Table with this name already exists.");
                else if (String.IsNullOrEmpty(name)) throw new Exception("Name cannot be blank!");
            }
            db.Tables.Add(new Table(name));
        }

        public static void DeleteTable(int table_id)
        {
            db.Tables.RemoveAt(table_id);
        }
        public static Table ProjectTable(int table_id, Dictionary<int, string> columnNamesIndexes)
        {
            Table table = new Table("ProjectedTable");
            foreach (var pair in columnNamesIndexes)
            {
                Column newColumn = db.Tables[table_id].Columns[pair.Key];
                table.Columns.Add(newColumn);
            }

            List<Row> rows = db.Tables[table_id].Rows;

            for (int i = 0; i < rows.Count; i++)
            {
                table.Rows.Add(new Row(db.Tables[table_id].Rows[i].Id));
                for (int j = 0; j < db.Tables[table_id].Columns.Count; j++)
                {
                    if (columnNamesIndexes.ContainsKey(j))
                    {
                        table.Rows[i].Values.Add(db.Tables[table_id].Rows[i].Values[j]);
                    }
                }
            }
            return table;
        }
        public static void AddColumn(int table_id, string name, string dataType, bool isNull)
        {
            Models.DataType tempType;
            switch (dataType)
            {
                case "Integer":
                    tempType = Models.DataType.Integer;
                    break;
                case "Real":
                    tempType = Models.DataType.Real;
                    break;
                case "Char":
                    tempType = Models.DataType.Char;
                    break;
                case "String":
                    tempType = Models.DataType.String;
                    break;
                case "Color":
                    tempType = Models.DataType.Color;
                    break;
                case "Color interval":
                    tempType = Models.DataType.ColorInvl;
                    break;
                default:
                    throw new Exception("Something went wrong!");
            }

            db.Tables[table_id].Columns.RemoveAll(c => c.Name == name);

            Column tempCol;
            switch (dataType)
            {
                case "Integer":
                    tempCol = new IntColumn(name, isNull);
                    break;
                case "Real":
                    tempCol = new RealColumn(name, isNull);
                    break;
                case "Char":
                    tempCol = new CharColumn(name, isNull);
                    break;
                case "String":
                    tempCol = new StringColumn(name, isNull);
                    break;
                case "Color":
                    tempCol = new ColorColumn(name, isNull);
                    break;
                case "Color interval":
                    tempCol = new ColorInvlColumn(name, isNull);
                    break;
                default:
                    throw new Exception("Something went wrong!");
            }

            db.Tables[table_id].Columns.Add(tempCol);
        }

        public static void DeleteColumn(int table_id, string columnName)
        {
            var column = db.Tables[table_id].Columns.FirstOrDefault(c => c.Name == columnName);

            db.Tables[table_id].Columns.Remove(column);

        }
        public static void AddRow(int table_id, int rowId, Dictionary<int, string> values)
        {
            Row newRow = new Row(rowId);

            for (int i = 0; i < db.Tables[table_id].Columns.Count; i++)
            {
                if (db.Tables[table_id].Columns[i].Validate(values[i]) || values[i] == null)
                {
                    newRow.Values.Add(values[i]);
                }
                else
                {
                    throw new Exception("Invalid type of a value: " + db.Tables[table_id].Columns[i].Name);
                }
            }

            db.Tables[table_id].Rows.Add(newRow);
            db.Tables[table_id].NextRowId++;
        }
        public static void DeleteRow(int table_id, int row_id)
        {
            var row = db.Tables[table_id].Rows.FirstOrDefault(r => r.Id == row_id);

            db.Tables[table_id].Rows.Remove(row);
        }
        public static void EditRow(int table_id, int row_id, Dictionary<int, string> values)
        {
            var existingRow = db.Tables[table_id].Rows.FirstOrDefault(c => c.Id == row_id);
            for (int i = 0; i < db.Tables[table_id].Columns.Count; i++)
            {
                if (existingRow.Values[i] == values[i]) continue;

                if (db.Tables[table_id].Columns[i].Validate(values[i]) || values[i] == null)
                {
                    existingRow.Values[i] = values[i];
                }
                else
                {
                    throw new Exception("Invalid type of a value: " + db.Tables[table_id].Columns[i].Name);
                }
            }
        }
    }
}

