using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassGeneratorCore.DataLayer
{
    internal class GenerateEntity
    {
        public string GetEntity(EntityLayer.ClassEntity ClassEntity)
        {
            try
            {
                StringBuilder ListProperties = new StringBuilder();
                
                foreach (EntityLayer.PropertyEntity propertyEntity in ClassEntity.ListpropertyEntities)
                {

                }
            }
            catch(Exception ex)
            {
                throw new Exception($"ClassGeneratorCore.DataLayer.GetEntity : {ex.Message}");
            }
        }

        public string GetPropertie(EntityLayer.PropertyEntity PropertyEntity)
        {
            StringBuilder stringBuilder = new StringBuilder();
            try
            {
                
                if (PropertyEntity.IsKey) {
                    stringBuilder.AppendLine("[Key]");
                }

                return $"public {PropertyEntity.DataType} {PropertyEntity.Name} ";
            }catch(Exception ex)
            {
                throw new Exception($"ClassGeneratorCore.DataLayer.GetPropertie : {ex.Message}");
            }
            finally
            {
                
            }
        }
    }
}
