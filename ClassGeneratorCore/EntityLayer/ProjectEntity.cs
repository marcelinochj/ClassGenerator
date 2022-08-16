using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassGeneratorCore.EntityLayer
{
    internal class ProjectEntity
    {
        public string ProjectName { get; set; }
        public List<ClassEntity> ListclassEntities { get; set; };
    }
}
