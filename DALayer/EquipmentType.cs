using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALayer
{
    public class EquipmentType
    {
        
             public int Type { get; set; }
        public int YearsValid { get; set; }
        public int EquipCode { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }

        public EquipmentType()
        {

        }
        public EquipmentType(string description, int yearsValid, string status,int equipCode)
        {
            YearsValid = yearsValid;
            Description = description;
            Status = status;
            EquipCode = equipCode;
        }
        public EquipmentType(int type,string description, int yearsValid, string status, int equipCode)
        {
            YearsValid = yearsValid;
            Description = description;
            Status = status;
            EquipCode = equipCode;
            Type = type;
        }
        public EquipmentType(int type, string description, int yearsValid, string status)
        {
            YearsValid = yearsValid;
            Description = description;
            Status = status;
         
            Type = type;
        }
    }
}
