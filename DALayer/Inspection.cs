using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALayer
{
    public class Inspection
    {
        public int iCode { get; set; }
        public int staffCode { get; set; }
        public int vCode { get; set; }
        public string date { get; set; }
        public string comment { get; set; }
        public string time { get; set; }


        public Inspection()
        {

        }
        public Inspection(int StaffCode, int VCode, string Date, string Comment, string Time)
        {
            //iCode = ICode;
            staffCode = StaffCode;
            vCode = VCode;
            date = Date;
            comment = Comment;
            time = Time;

        }
    }
}
