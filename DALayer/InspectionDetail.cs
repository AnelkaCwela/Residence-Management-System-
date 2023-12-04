using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALayer
{
    public class InspectionDetail
    {
        public int idCode { get; set; }
        public int iCode { get; set; }
        public int staffCode { get; set; }
        public int eCode { get; set; }
        public string faultcomment { get; set; }
        public string status { get; set; }


        public InspectionDetail()
        {

        }

        public InspectionDetail(int IDCode, int StaffCode, int ICode, int ECode, string FaultComment, string Status)
        {
            idCode = IDCode;
            staffCode = StaffCode;
            iCode = ICode;
            eCode = ECode;
            faultcomment = FaultComment;
            status = Status;

        }
    }
}
