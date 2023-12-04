using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALayer
{
    public class Equipment
    {
        public string Description { get; set; }
        public int VenueCode { get; set; }
        public string Status { get; set; }
      

        public Equipment()
        {

        }
        public Equipment(string description, int venueCode, string status)
        {
            Description = description;
            VenueCode = venueCode;
            Status = status;
         
        }
    }
}
