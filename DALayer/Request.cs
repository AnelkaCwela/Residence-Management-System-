using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALayer
{
   public class Request
    {
        public string RequestDescription { get; set; }
        public int StaffCode { get; set; }
        public int StudentCode { get; set; }
        public int TaskType { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public Request(string RequestDescription, int StaffCode, int StudentCode, int TaskType, string Date, string Time)
        {
            this.StaffCode = StaffCode;
            this.RequestDescription = RequestDescription;
            this.StudentCode = StudentCode;
            this.TaskType = TaskType;
            this.Date = Date;
            this.Time = Time;
        }
    }
}
