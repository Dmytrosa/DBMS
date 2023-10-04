using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MyDBSM.Models
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DataType
    {
        Integer,
        Real,
        Char,
        String,
        Color,
        ColorInvl
    }


    public abstract class Column
    {
        public string Name { get; set; }
        public abstract DataType Type { get; }
        public bool IsNullable { get; set; }
        public Column(string name, bool isNull)
        {
            Name = name;
            IsNullable = isNull;
        }
        public abstract bool Validate(string value);
    }

    public class IntColumn : Column
    {
        public override DataType Type { get; } = DataType.Integer;
        public IntColumn(string name, bool isNull) : base(name, isNull) { }

        public override bool Validate(string value)=> int.TryParse(value, out _);
        
    }

    public class RealColumn : Column
    {
        public override DataType Type { get; } = DataType.Real;
        public RealColumn(string name, bool isNull) : base(name, isNull) { }

        public override bool Validate(string value) => double.TryParse(value, out _);
        
    }

    public class CharColumn : Column
    {
        public override DataType Type { get; } = DataType.Char;
        public CharColumn(string name, bool isNull) : base(name, isNull) { }

        public override bool Validate(string value)=>char.TryParse(value, out _);
        
    }

    public class StringColumn : Column
    {
        public override DataType Type { get; } = DataType.String;
        public StringColumn(string name, bool isNull) : base(name, isNull) { }

        public override bool Validate(string value) => true;
    }

    public class ColorColumn : Column
    {
        public override DataType Type { get; } = DataType.Color;
        public ColorColumn(string name, bool isNull) : base(name, isNull) { }

        public override bool Validate(string value) => Regex.IsMatch(value, @"^#([A-Fa-f0-9]{6}|[A-Fa-f0-9]{3})$") ? true : false;
        
    }

    public class ColorInvlColumn : Column
    {
        public override DataType Type { get; } = DataType.ColorInvl;
        public ColorInvlColumn(string name, bool isNull) : base(name, isNull) { }

        public override bool Validate(string value)
        {
            string[] colors = value.Split(',');

            if (colors.Length != 2)
            {
                return false;
            }

            if (Regex.IsMatch(colors[0], @"^#([A-Fa-f0-9]{6}|[A-Fa-f0-9]{3})$") && Regex.IsMatch(colors[1], @"^#([A-Fa-f0-9]{6}|[A-Fa-f0-9]{3})$"))
            {
                return true; 
            }
            else
            {
                return false; 
            }
        }
    }

}
