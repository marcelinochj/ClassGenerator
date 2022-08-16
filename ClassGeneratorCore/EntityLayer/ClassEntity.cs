using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassGeneratorCore.EntityLayer
{
    internal class ClassEntity
    {
        public string TableName { get; set; }
        public List<PropertyEntity> ListpropertyEntities { get; set; }
    }
}
