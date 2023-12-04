using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using BELayer;
using DALayer;

namespace BALayer
{
    public class BAL
    {
        BEL beobj = new BEL();

        DAL daobj = new DAL();

        public int InsertStaff(BEL beobj)
        {
            return daobj.InsertStaff(beobj);
        }
        public int InsertTrack(BEL beobj)
        {
            return daobj.InsertTrack(beobj);
        }
        public DataTable SelectTrack(BEL beobj)
        {
            return daobj.SelectTrack(beobj);
        }
        public DataTable SelectStaff(BEL beobj)
        {
            return daobj.SelectStaff(beobj);
        }
        public int InsertStudent(BEL beobj)
        {
            return daobj.InsertStudent(beobj);
        }
        public int InsertEType(BEL beobj)
        {
            return daobj.InsertEType(beobj);
        }
        //public int InsertEquipment(BEL beobj)
        //{
        //    return daobj.InsertEquipment(beobj);
        //}
        public DataTable EquipmentTypeByEquipment(int code)
        {
            return daobj.EquipmentTypeByEquipment(code);
        }
        public int InsertVenue(BEL beobj)
        {
            return daobj.InsertVenue(beobj);
        }
        public DataTable SelectVenue(BEL beobj)
        {
            return daobj.SelectVenue(beobj);
        }
        public DataTable SelectEquipment(BEL beobj)
        {
            return daobj.SelectEquipment(beobj);
        }
        public DataTable EquipmentByDescr(string desc)
        {
            return daobj.EquipmentByDescr(desc);
        }
        public DataTable SelectEquipmentType(BEL beobj)
        {
            return daobj.SelectEquipmentType(beobj);
        }
        public int InsertDepartment(Department department)
        {
            return daobj.InsertDepartment(department);
        }
        public int UpdateDepartment(Department department)
        {
            return daobj.UpdateDepartment(department);
        }
        public DataTable GetDepartment()
        {
            return daobj.GetDepartment();
        }
        public DataTable GetDepartmentByDepartID(int departID)
        {
            return daobj.GetDepartmentByDepartID(departID);
        }
        public int InsertEquipment(Equipment equipment)
        {
            return daobj.InsertEquipment(equipment);
        }
        public int UpdateEquipment(BEL beobj)
        {
            return daobj.UpdateEquipment(beobj);
        }
        public DataTable GetEquipment()
        {
            return daobj.GetEquipment();
        }
        public DataTable GetEquipmentByEquipCode(int equipCode)
        {
            return daobj.GetEquimentByEquipCode(equipCode);
        }
        public int InsertEquipmentType(EquipmentType equipmentType)
        {
            return daobj.InsertEquipmentType(equipmentType);
        }
        public int UpdateEquipmentType(EquipmentType equipmentType)
        {
            return daobj.UpdateEquipmentType(equipmentType);
        }
        public DataTable GetEquipmentType()
        {
            return daobj.GetEquipmentType();
        }
        public DataTable GetEquipmentTypeByTypeID(int typeId)
        {
            return daobj.GetEquimentTypeByEquipCode(typeId);
        }

        public DataTable GetVenue()
        {
            return daobj.GetVenue();
        }
        public DataTable GetVenueByVenueCode(int venueCode)
        {
            return daobj.GetVenueByVenueCode(venueCode);
        }
        //public int InsertStudent(BEL beobj)
        //{
        //    return daobj.InsertStudent(beobj);
        //}
        public int InsertVenue(Venues venues)
        {
            return daobj.InsertVenue(venues);
        }
        public int InsRequests(Request insertRequest)
        {
            return daobj.InsRequests(insertRequest);
        }
        public DataTable GetStudent()
        {
            return daobj.GetStudent();
        }
        public int InsertUser(BEL beobj)
        {
            return daobj.InsertUser(beobj);
        }
        public DataTable GetUser()
        {
            return daobj.GetUser();
        }
        public DataTable SelectStaffByName(BEL beobj)
        {
            return daobj.SelectStaffByName(beobj);
        }
        public int updateStaff(BEL beobj)
        {
            return daobj.updateStaff(beobj);
        }
        public int removeStaff(BEL beobj)
        {
            return daobj.removeStaff(beobj);
        }
        //public int InsRequests(Request insertRequest)
        //{
        //    return daobj.InsRequests(insertRequest);
        //}
        public DataTable GetRequest(int StaffCode, int StudentCode)
        {
            return daobj.GetRequest(StaffCode, StudentCode);
        }
        public DataTable GetStudent(BEL beobj)
        {
            return daobj.GetStudent(beobj);
        }
        public DataTable GetTaskType()
        {
            return daobj.GetTaskType();
        }
        public DataTable GetRequest()
        {
            return daobj.GetRequest();
        }
        public int UpdateVenue(int VenueCode, string descr, int capacity)
        {
            return daobj.UpdateVenue(VenueCode,descr,capacity);
        }
        public int DeleteVenue(Venues venues)
        {
            return daobj.DeleteVenue(venues);
        }
    }
    
}
