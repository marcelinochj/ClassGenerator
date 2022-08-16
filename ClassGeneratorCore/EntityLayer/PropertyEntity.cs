using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassGeneratorCore.EntityLayer
{
    internal class PropertyEntity
    {
        public enum ListDataType
        {
            String,
            Float,
            Boolean
        };

        public bool IsKey { get; set; }
        public string Name { get; set; }
        public ListDataType DataType { get; set; }
        public int Length { get; set; }
    }
}
