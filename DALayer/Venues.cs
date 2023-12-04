using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALayer
{
    public class Venues
    {
        public string Descr { get; set; }
        public string Status { get; set; }
        public int Capacity { get; set; }
        public int VenueCode { get; set; }
        public Venues()
        {

        }
        public Venues(string descr, int capacity,string status)
        {
            Descr = descr;
            Capacity = capacity;
            Status = status;
        }
        //public Venues(int VenueCode, string descr, int capacity)
        //{
        //    Descr = descr;
        //    Capacity = capacity;
        //    this.VenueCode = VenueCode;

        //}

        public Venues(int VenueCode, string Status)
        {

            this.VenueCode = VenueCode;
            this.Status = Status;
        }
    }
}
