using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Miniprojekt.Models.Text2Color
{
    public class Color
    {
        public string Name { get; protected set; }
        public string HexValue { get; protected set; }

        public Color() { }

        public Color(string name, string hexvalue)
        {
            this.Name = name;
            this.HexValue = hexvalue;
        }
    }
}
