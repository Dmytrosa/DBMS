
using MyDBSM.Controllers;
using MyDBSM.Models;
using System.Windows.Forms;
using System.Linq;
using System.Data.Common;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace MyDBSM
{
    public partial class Form1 : Form
    {
        int selectedTableId = -1;
        public Form1()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            dbInfoPanel.Visible = false;
            startPanel.Visible = true;
            valuesPanel.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void dbCreateButton_Click(object sender, EventArgs e)
        {
            NameRequest nameRequest = new NameRequest();
            if (nameRequest.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DBController.CreateDatabase(nameRequest.NewName);
                    name_label.Text = "Database name: " + nameRequest.NewName;
                    startPanel.Visible = false;
                    dbInfoPanel.Visible = true;
                    TableListBoxChanged();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK);
                }
            }

        }

        private void TableListBoxChanged()
        {
            tableListBox.Items.Clear();
            foreach (var t in DBController.db.Tables)
            {
                tableListBox.Items.Add(t.Name);
            }
        }

        private void dbDeleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Delete confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DBController.DeleteDatabase();
                dbInfoPanel.Visible = false;
                tableColumnsPanel.Visible = false;
                startPanel.Visible = true;
            }

        }

        private void dbRenameButton_Click(object sender, EventArgs e)
        {
            NameRequest nameRequest = new NameRequest();
            if (nameRequest.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DBController.RenameDatabase(nameRequest.NewName);
                    name_label.Text = "Database name: " + nameRequest.NewName;
                    dbInfoPanel.Update();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK);
                }

            }

        }

        private void addTableButton_Click(object sender, EventArgs e)
        {
            NameRequest nameRequest = new NameRequest();
            if (nameRequest.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DBController.AddTable(nameRequest.NewName);
                    TableListBoxChanged();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK);
                }

            }
        }

        private void dbInfoPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (tableListBox.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("Are you sure?", "Delete confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DBController.DeleteTable(tableListBox.SelectedIndex);
                    TableListBoxChanged();
                }
            }
            else
            {
                MessageBox.Show("No table is selected", "Error!", MessageBoxButtons.OK);
            }
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog openFileDialog = new SaveFileDialog())
                {
                    openFileDialog.InitialDirectory = "C:\\";
                    openFileDialog.Filter = "JSON Files (*.json)|*.json|All Files (*.*)|*.*";
                    openFileDialog.FilterIndex = 1;
                    openFileDialog.RestoreDirectory = true;

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string selectedFilePath = openFileDialog.FileName;

                        if (!File.Exists(selectedFilePath))
                        {
                            File.Create(selectedFilePath).Close();
                        }

                        DBController.ExportDatabase(selectedFilePath);
                        MessageBox.Show("All done!", "Success!", MessageBoxButtons.OK);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK);
            }
        }

        private void dataTableButton_Click(object sender, EventArgs e)
        {
            if (tableListBox.SelectedItems.Count > 0)
            {
                if (DBController.db.Tables[tableListBox.SelectedIndex].Columns.Count == 0)
                {
                    MessageBox.Show("You should add columns first!", "Error!", MessageBoxButtons.OK);
                }
                else
                {
                    valuesGrid.Rows.Clear();
                    valuesGrid.Columns.Clear();
                    dbInfoPanel.Visible = false;
                    valuesPanel.Visible = true;
                    selectedTableId = tableListBox.SelectedIndex;
                    LoadValues();
                }
            }
            else
            {
                MessageBox.Show("No table is selected", "Error!", MessageBoxButtons.OK);
            }
        }

        private void LoadValues()
        {
            valuesGrid.Columns.Clear();

            DataGridViewColumn firstColumn = new DataGridViewTextBoxColumn();
            firstColumn.ReadOnly = true;
            firstColumn.Name = "Id";
            firstColumn.HeaderText = "Id";
            valuesGrid.Columns.Add(firstColumn);

            foreach (var c in DBController.db.Tables[selectedTableId].Columns)
            {
                DataGridViewColumn column = new DataGridViewTextBoxColumn();

                column.HeaderText = c.Name;
                column.Name = c.Name;

                valuesGrid.Columns.Add(column);
            }

            valuesGrid.Rows.Clear();
            List<Row> rows = DBController.db.Tables[selectedTableId].Rows;
            if (rows.Count != 0)
            {
                valuesGrid.RowCount = rows.Count;
            }

            for (int i = 0; i < rows.Count; i++)
            {
                valuesGrid.Rows[i].Cells["Id"].Value = DBController.db.Tables[selectedTableId].Rows[i].Id;
                for (int j = 1; j < valuesGrid.ColumnCount; j++)
                {
                    if (DBController.db.Tables[selectedTableId].Rows[i].Values[j - 1] == null)
                    {
                        valuesGrid[j, i].Value = null;
                    }
                    else
                    {
                        valuesGrid[j, i].Value = DBController.db.Tables[selectedTableId].Rows[i].Values[j - 1].ToString();
                    }
                }
            }

        }


        private void columnsTableButton_Click(object sender, EventArgs e)
        {
            if (tableListBox.SelectedItems.Count > 0)
            {
                dbInfoPanel.Visible = false;
                tableColumnsPanel.Visible = true;
                selectedTableId = tableListBox.SelectedIndex;
                TableColumnsUpdate();

            }
            else
            {
                MessageBox.Show("No table is selected", "Error!", MessageBoxButtons.OK);
            }


        }

        private void TableColumnsUpdate()
        {
            dataGridView1.Rows.Clear();
            List<Column> columns = DBController.db.Tables[selectedTableId].Columns;
            if (columns.Count != 0)
            {
                dataGridView1.RowCount = columns.Count;
            }

            for (int i = 0; i < columns.Count; i++)
            {
                dataGridView1.Rows[i].Cells["ColumnName"].Value = columns[i].Name;
                dataGridView1.Rows[i].Cells["DataType"].Value = columns[i].Type.ToString();
                dataGridView1.Rows[i].Cells["IsNullable"].Value = columns[i].IsNullable;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void backFromColumnsButton_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            tableListBox.ClearSelected();
            tableColumnsPanel.Visible = false;
            dbInfoPanel.Visible = true;
            selectedTableId = -1;
            TableListBoxChanged();
        }

        private void saveChangesColumnsButton_Click(object sender, EventArgs e)
        {
            try
            {
                UpsertColumns();
                MessageBox.Show("All done!", "Success!", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK);
            }
        }

        private void UpsertColumns()
        {
            try
            {
                if (DBController.db.Tables[selectedTableId].Rows.Count > 0)
                {
                    throw new Exception("There are existing data in this table. Clear rows first, then you can change table.");
                }

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        string columnName = "";
                        string columnType = "";
                        if (row.Cells["ColumnName"].Value != null && row.Cells["DataType"].Value != null)
                        {
                            columnName = row.Cells["ColumnName"].Value.ToString();
                            columnType = row.Cells["DataType"].Value.ToString();
                        }
                        else throw new Exception("All cells must be filled");
                        bool isNullable = Convert.ToBoolean(row.Cells["IsNullable"].Value);

                        DBController.AddColumn(selectedTableId, columnName, columnType, isNullable);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK);
            }


        }

        private void deleteColumnButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (DBController.db.Tables[selectedTableId].Rows.Count > 0)
                {
                    throw new Exception("There are existing data in this table. Clear rows first, then you can change table.");
                }
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Selected)
                    {
                        if (MessageBox.Show("Are you sure?", "Delete confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            if (row.Cells["ColumnName"].Value == null || row.Cells["DataType"].Value == null)
                            {
                                dataGridView1.Rows.Remove(row);
                            }
                            else if (row.Cells["ColumnName"].Value != null)
                            {
                                var column = DBController.db.Tables[selectedTableId].Columns.FirstOrDefault(c => c.Name == row.Cells["ColumnName"].Value.ToString());
                                if (column == null)
                                {
                                    dataGridView1.Rows.Remove(row);
                                }
                                else
                                {
                                    string name = row.Cells["ColumnName"].Value.ToString();
                                    DBController.DeleteColumn(selectedTableId, name);
                                    TableColumnsUpdate();
                                }
                            }


                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK);
            }

        }

        private void addNewColumnButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (DBController.db.Tables[selectedTableId].Rows.Count > 0)
                {
                    throw new Exception("There are existing data in this table. Clear rows first, then you can change table.");
                }
                DataGridViewRow newRow = new DataGridViewRow();
                dataGridView1.Rows.Add(newRow);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK);
            }

        }

        private void backFromValuesButton_Click(object sender, EventArgs e)
        {
            valuesGrid.ClearSelection();
            tableListBox.ClearSelected();
            valuesPanel.Visible = false;
            dbInfoPanel.Visible = true;
            selectedTableId = -1;
            TableListBoxChanged();
        }

        private void saveValuesButton_Click(object sender, EventArgs e)
        {
            try
            {
                AddNewOrEditRows();
                MessageBox.Show("All done!", "Success!", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK);
            }
        }

        private void AddNewOrEditRows()
        {
            foreach (DataGridViewRow row in valuesGrid.Rows)
            {
                if (!row.IsNewRow)
                {
                    Dictionary<int, string> columnValuePairs = new Dictionary<int, string?>();
                    foreach (DataGridViewColumn col in valuesGrid.Columns)
                    {
                        if (col.Index == 0) continue;
                        var currentColumn = DBController.db.Tables[selectedTableId].Columns.FirstOrDefault(c => c.Name == col.Name);
                        bool isNull = currentColumn.IsNullable;

                        if (!isNull)
                        {
                            if (valuesGrid[col.Index, row.Index].Value != null)
                            {
                                columnValuePairs[col.Index - 1] = valuesGrid[col.Index, row.Index].Value.ToString();
                            }
                            else
                            {
                                throw new Exception("Not nullable cells must be filled!");
                            }
                        }
                        else
                        {
                            if (valuesGrid[col.Index, row.Index].Value != null)
                            {
                                columnValuePairs[col.Index - 1] = valuesGrid[col.Index, row.Index].Value.ToString();
                            }
                            else
                            {
                                columnValuePairs[col.Index - 1] = null;
                            }
                        }

                    }
                    if (Convert.ToInt32(row.Cells["Id"].Value) == 0)
                    {
                        DBController.AddRow(selectedTableId, DBController.db.Tables[selectedTableId].NextRowId, columnValuePairs);
                    }
                    else
                    {
                        DBController.EditRow(selectedTableId, Convert.ToInt32(row.Cells["Id"].Value), columnValuePairs);
                    }


                }
            }

        }

        private void newRowButton_Click(object sender, EventArgs e)
        {
            DataGridViewRow newRow = new DataGridViewRow();
            valuesGrid.Rows.Add(newRow);

        }

        private void deleteRowButton_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in valuesGrid.Rows)
                {
                    if (row.Selected)
                    {
                        if (MessageBox.Show("Are you sure?", "Delete confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            var r = DBController.db.Tables[selectedTableId].Rows.FirstOrDefault(x => x.Id == Convert.ToInt32(row.Cells["Id"].Value));
                            if (r == null)
                            {
                                valuesGrid.Rows.Remove(row);
                            }

                            else
                            {
                                int id = Convert.ToInt32(row.Cells["Id"].Value);
                                DBController.DeleteRow(selectedTableId, id);
                                valuesGrid.Rows.Remove(row);
                            }
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK);
            }
        }


        private void importButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.InitialDirectory = "C:\\";
                    openFileDialog.Filter = "JSON Files (*.json)|*.json|All Files (*.*)|*.*";
                    openFileDialog.FilterIndex = 1;
                    openFileDialog.RestoreDirectory = true;

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string selectedFilePath = openFileDialog.FileName;

                        if (File.Exists(selectedFilePath))
                        {
                            DBController.ImportDatabase(selectedFilePath);
                            startPanel.Visible = false;
                            dbInfoPanel.Visible = true;
                            name_label.Text = "Database name: " + DBController.db.Name;
                            TableListBoxChanged();
                        }
                        else
                        {
                            throw new Exception("File does not exist.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
