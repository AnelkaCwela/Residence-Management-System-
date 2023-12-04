using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BELayer;
using System.Data.SqlClient;
using DALayer;
using System.Data;

namespace DALayer
{
    public class DAL
    {
        SqlConnection con = new SqlConnection("Data Source=Localhost;Initial Catalog=Info@IThelpDesk;Integrated Security=SSPI;");
        SqlCommand com;
        SqlDataAdapter dbAdapter;

        

        public int InsertStaff(BEL beobj)
        {
            com = new SqlCommand();
            com.Connection = con;
            try
            {
                con.Open();
            }
            catch { }
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "stp_InsertStaff";
            com.Parameters.AddWithValue("@firstName", beobj.name);
            com.Parameters.AddWithValue("@lastName", beobj.surname);
            com.Parameters.AddWithValue("@IDNumber", beobj.ID);
            com.Parameters.AddWithValue("@email", beobj.email);
            com.Parameters.AddWithValue("@staffType", beobj.staffType);
            com.Parameters.AddWithValue("@password", beobj.password);
            com.Parameters.AddWithValue("@SQ1", beobj.sq1);
            com.Parameters.AddWithValue("@answer1", beobj.answer1);
            com.Parameters.AddWithValue("@SQ2", beobj.sq2);
            com.Parameters.AddWithValue("@answer2", beobj.answer2);
            com.Parameters.AddWithValue("@phoneNo", beobj.phone);
            com.Parameters.AddWithValue("@DepartCode", beobj.depCode);
            com.Parameters.AddWithValue("@Status", beobj.status);
            int c;
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            c = com.ExecuteNonQuery();
            return c;
        }
        public int InsertStudent(BEL beobj)
        {
            com = new SqlCommand();
            com.Connection = con;
            try
            {
                con.Open();
            }
            catch { }
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "ustp_InsertStudent";

            com.Parameters.AddWithValue("@Surname", beobj.surname);
            com.Parameters.AddWithValue("@Name", beobj.name);
            com.Parameters.AddWithValue("@Email", beobj.email);
            com.Parameters.AddWithValue("@Phone", beobj.phone);
            com.Parameters.AddWithValue("@Course", beobj.course);
            com.Parameters.AddWithValue("@IdNumber", beobj.ID);
            com.Parameters.AddWithValue("@Status", beobj.status);
            com.Parameters.AddWithValue("@YearOfStud", beobj.YearOfStudy);
            int c;
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            c = com.ExecuteNonQuery();
            return c;
        }
        public int InsertTrack(BEL beobj)
        {
            com = new SqlCommand();
            com.Connection = con;
            try
            {
                con.Open();
            }
            catch { }
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "sp_insertTrack";
            com.Parameters.AddWithValue("@track", beobj.track);
            int i;
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            i = com.ExecuteNonQuery();
            return i;
        }
        public DataTable SelectTrack(BEL beobj)
        {
            com = new SqlCommand();
            com.Connection = con;
            try
            {
                con.Open();
            }
            catch { }
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "sp_selectTrack";
            DataTable dt = new DataTable();
            SqlDataAdapter sd = new SqlDataAdapter(com);
            sd.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable SelectStaff(BEL beobj)
        {
            com = new SqlCommand();
            com.Connection = con;
            try
            {
                con.Open();
            }
            catch { }
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "sp_selectStaff";
            DataTable hg = new DataTable();
            SqlDataAdapter ht = new SqlDataAdapter(com);
            ht.Fill(hg);
            con.Close();
            return hg;

        }
        public int InsertVenue(BEL beobj)
        {
            com = new SqlCommand();
            com.Connection = con;
            try
            {
                con.Open();
            }
            catch { }
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "sp_InsertVenue";

            com.Parameters.AddWithValue("@VenueDescription", beobj.VDescription);
            com.Parameters.AddWithValue("@VenueCapasity", beobj.VCapacity);
            int c;
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            c = com.ExecuteNonQuery();
            return c;
        }
        //public int InsertEquipment(BEL beobj)
        //{
        //    com = new SqlCommand();
        //    com.Connection = con;
        //    try
        //    {
        //        con.Open();
        //    }
        //    catch { }
        //    com.CommandType = CommandType.StoredProcedure;
        //    com.CommandText = "sp_Equipment";

        //    com.Parameters.AddWithValue("@EquipmentDescription", beobj.EquipmentDescription);
        //    com.Parameters.AddWithValue("@VenueCode", beobj.VCode);
        //    com.Parameters.AddWithValue("@EquipmentTypeCode", beobj.ETCode);

        //    int c;
        //    if (con.State == ConnectionState.Closed)
        //    {
        //        con.Open();
        //    }sp_SelectStudent

        //    c = com.ExecuteNonQuery();
        //    return c;
        //}
        public int InsertEType(BEL beobj)
        {
            com = new SqlCommand();
            com.Connection = con;
            try
            {
                con.Open();
            }
            catch { }
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "sp1insertEquipmentType";
            com.Parameters.AddWithValue("@ETypeDescription", beobj.EquipTypeDescription);
            int i;
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            i = com.ExecuteNonQuery();
            return i;
        }
        public DataTable SelectVenue(BEL beobj)
        {
            com = new SqlCommand();
            com.Connection = con;
            try
            {
                con.Open();
            }
            catch { }
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "sp_SelectVenue";
            DataTable dt = new DataTable();
            SqlDataAdapter sd = new SqlDataAdapter(com);
            sd.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable SelectEquipment(BEL beobj)
        {
            com = new SqlCommand();
            com.Connection = con;
            try
            {
                con.Open();
            }
            catch { }
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "sp_selectTrack";
            DataTable dt = new DataTable();
            SqlDataAdapter sd = new SqlDataAdapter(com);
            sd.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable SelectEquipmentType(BEL beobj)
        {
            com = new SqlCommand();
            com.Connection = con;
            try
            {
                con.Open();
            }
            catch { }
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "ssspSelectEType";
            DataTable dt = new DataTable();
            SqlDataAdapter sd = new SqlDataAdapter(com);
            sd.Fill(dt);
            con.Close();
            return dt;
        }
        public int InsertEquipment(Equipment equipment)
        {

            com = new SqlCommand();
            com.Connection = con;
            try
            {
                con.Open();
            }
            catch { }
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "stp_Equipment";
            com.Parameters.AddWithValue("@Description", equipment.Description);
            com.Parameters.AddWithValue("@Status", equipment.Status);
     
            com.Parameters.AddWithValue("@VenueCode", equipment.VenueCode);

            int x = com.ExecuteNonQuery();
            return x;
        }
        public int UpdateEquipment(BEL beobj)
        {

            com = new SqlCommand();
            com.Connection = con;
            try
            {
                con.Open();
            }
            catch { }
            string sqlinsert = "sp_UpdateEquipment";
            com.CommandType = CommandType.StoredProcedure;

            com = new SqlCommand(sqlinsert, con);
            com.Parameters.AddWithValue("@Description", beobj.name);
            com.Parameters.AddWithValue("@Status", beobj.status);
         
            com.Parameters.AddWithValue("@VenueCode",beobj.VCode);
            com.Parameters.AddWithValue("@EquipCode", beobj.depCode);

            int x = com.ExecuteNonQuery();
            return x;
        }
        public DataTable GetEquimentByEquipCode(int equipCode)
        {

            try
            {
                con.Open();
            }
            catch
            {

            }
            com = new SqlCommand("sp_ GetEquimentByEquipCode", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@EquipCode", equipCode);
            dbAdapter = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            dbAdapter.Fill(dt);
            return dt;
        }
        public DataTable GetEquipment()
        {
            com = new SqlCommand();
            com.Connection = con;
            try
            {
                con.Open();
            }
            catch { }
            com.CommandType = CommandType.StoredProcedure;
            string sqlinsert = "sp_GetEquipment";

            com = new SqlCommand(sqlinsert, con);
            dbAdapter = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            dbAdapter.Fill(dt);
            return dt;
        }
        public int InsertEquipmentType(EquipmentType equipmentType)
        {

            com = new SqlCommand();
            com.Connection = con;
            try
            {
                con.Open();
            }
            catch { }
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "sp_InsertEquipmentType";
            com.Parameters.AddWithValue("@Description", equipmentType.Description);
            com.Parameters.AddWithValue("@Status", equipmentType.Status);
            com.Parameters.AddWithValue("@YearsValid", equipmentType.YearsValid);

            com.Parameters.AddWithValue("@EquipCode", equipmentType.EquipCode);

            int x = com.ExecuteNonQuery();
            return x;
        }
        public int UpdateEquipmentType(EquipmentType equipmentType)
        {

            try
            {
                con.Open();
            }
            catch
            {

            }
            string sqlinsert = "sp_UpdateEquipmentType";
            com.CommandType = CommandType.StoredProcedure;

            com = new SqlCommand(sqlinsert, con);
            com.Parameters.AddWithValue("@TypeID", equipmentType.Type);
            com.Parameters.AddWithValue("@Description", equipmentType.Description);
            com.Parameters.AddWithValue("@Status", equipmentType.Status);
            com.Parameters.AddWithValue("@YearsValid", equipmentType.YearsValid);


            int x = com.ExecuteNonQuery();
            return x;
        }
        public DataTable GetEquimentTypeByEquipCode(int typeID)
        {

            try
            {
                con.Open();
            }
            catch
            {

            }
            com = new SqlCommand("sp_ GetEquimentTypeByTypeID", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@TypeID", typeID);
            dbAdapter = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            dbAdapter.Fill(dt);
            return dt;
        }
        public DataTable GetEquipmentType()
        {
            com = new SqlCommand();
            com.Connection = con;
            try
            {
                con.Open();
            }
            catch { }
            com.CommandType = CommandType.StoredProcedure;
            string sqlinsert = "sp_GetEquipmentType";

            com = new SqlCommand(sqlinsert, con);
            dbAdapter = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            dbAdapter.Fill(dt);
            return dt;
        }
        public int InsertLabInsp(Inspection lab)
        {
            try
            {
                con.Open();
            }
            catch { }

            com.CommandType = CommandType.StoredProcedure;
            string sqlinsert = "sp_InsertLabInsp";

            com = new SqlCommand(sqlinsert, con);
            com.Parameters.AddWithValue("@iCode", lab.iCode);
            com.Parameters.AddWithValue("@StaffCode", lab.staffCode);
            com.Parameters.AddWithValue("@date", lab.date);
            com.Parameters.AddWithValue("@time", lab.time);
            com.Parameters.AddWithValue("@comment", lab.comment);
            com.Parameters.AddWithValue("@vCode", lab.vCode);

            int x = com.ExecuteNonQuery();
            return x;
        }

        public int InsertLabInspDetail(InspectionDetail lab)
        {
            try
            {
                con.Open();
            }
            catch { }

            com.CommandType = CommandType.StoredProcedure;
            string sqlinsert = "sp_InsertInspectionDetail";

            com = new SqlCommand(sqlinsert, con);
            com.Parameters.AddWithValue("@ICode", lab.iCode);
            com.Parameters.AddWithValue("@StaffCode", lab.staffCode);
            com.Parameters.AddWithValue("@eCode", lab.eCode);
            com.Parameters.AddWithValue("@faultComment", lab.faultcomment);
            com.Parameters.AddWithValue("@status", lab.status);


            int x = com.ExecuteNonQuery();
            return x;
        }
        public int InsertVenue(Venues venues)
        {
            com = new SqlCommand();
            com.Connection = con;
            try
            {
                con.Open();
            }
            catch { }
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "spR_InsertVenue";
            com.Parameters.AddWithValue("@VenueDescription", venues.Descr);
            com.Parameters.AddWithValue("@Capacity", venues.Capacity);
            com.Parameters.AddWithValue("@Status", venues.Status);

            int x = com.ExecuteNonQuery();
            return x;
        }
        //public int UpdateVenue(Venues venues)
        //{
        //    try
        //    {
        //        con.Open();
        //    }
        //    catch { }


        //    string sqlinsert = "sp_UpdateVenue";
        //    com.CommandType = CommandType.StoredProcedure;
        //    com = new SqlCommand(sqlinsert, con);
        //    com.Parameters.AddWithValue("@VenueDescription", venues.Descr);
        //    com.Parameters.AddWithValue("@Capacity", venues.Capacity);

        //    int x = com.ExecuteNonQuery();
        //    return x;
        //}
        public DataTable GetVenue()
        {
            string sqlinsert = "GETALLvenues";

            com = new SqlCommand(sqlinsert, con);
            dbAdapter = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            dbAdapter.Fill(dt);
            return dt;
        }
        public DataTable GetVenueByVenueCode(int venueCode)
        {

            try
            {
                con.Open();
            }
            catch
            {

            }
            com = new SqlCommand("sp_GetVenueByVenueCode", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@VenueCode", venueCode);
            dbAdapter = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            dbAdapter.Fill(dt);
            return dt;
        }
        public int InsertDepartment(Department department)
        {

            com = new SqlCommand();
            com.Connection = con;
            try
            {
                con.Open();
            }
            catch { }
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "sp_InsertDepartment";


            com.Parameters.AddWithValue("@DepartName", department.DepartName);
            com.Parameters.AddWithValue("@Building", department.Building);
            com.Parameters.AddWithValue("@ContactPerson", department.ContactPerson);
            com.Parameters.AddWithValue("@Email", department.Email);


            int x = com.ExecuteNonQuery();
            return x;
        }
        public int UpdateDepartment(Department department)
        {

            com = new SqlCommand();
            com.Connection = con;
            try
            {
                con.Open();
            }
            catch { }
            string sqlinsert = "sp_UpdateDepartment";
            com.CommandType = CommandType.StoredProcedure;
            com = new SqlCommand(sqlinsert, con);
            com.Parameters.AddWithValue("@DepartName", department.DepartName);
            com.Parameters.AddWithValue("@Building", department.Building);
            com.Parameters.AddWithValue("@ContactPerson", department.ContactPerson);
            com.Parameters.AddWithValue("@Email", department.Email);

            int x = com.ExecuteNonQuery();
            return x;
        }
        public DataTable GetDepartmentByDepartID(int departID)
        {

            try
            {
                con.Open();
            }
            catch
            {

            }
            com = new SqlCommand("sp_GetDepartmentByDepartID", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@DepartID", departID);
            dbAdapter = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            dbAdapter.Fill(dt);
            return dt;
        }
        public DataTable GetDepartment()
        {
            com = new SqlCommand();
            com.Connection = con;
            try
            {
                con.Open();
            }
            catch { }

            string sqlinsert = "sp_GetDepartment";
            com.CommandType = CommandType.StoredProcedure;
            com = new SqlCommand(sqlinsert, con);
            dbAdapter = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            dbAdapter.Fill(dt);
            return dt;
        }
        //public int InsertRequest(Request request)
        //{

        //    com = new SqlCommand();
        //    com.Connection = con;
        //    try
        //    {
        //        con.Open();
        //    }
        //    catch { }
        //    com.CommandType = CommandType.StoredProcedure;
        //    com.CommandText = "sp_InsertReaquest";


        //    com.Parameters.AddWithValue("@RequestDescription", request.RequestDescription);
        //    com.Parameters.AddWithValue("@StaffCode", request.StaffCode);
        //    com.Parameters.AddWithValue("@StudentCode", request.StudentCode);
        //    com.Parameters.AddWithValue("@TaskTypeCode", request.TaskTypeCode);
        //    com.Parameters.AddWithValue("@Date", request.Date);
        //    com.Parameters.AddWithValue("@StartTime ", request.StartTime);
        //    com.Parameters.AddWithValue("@EndTime", request.EndTime);


        //    int x = com.ExecuteNonQuery();
        //    return x;
        //}
        public DataTable GetStudent()
        {
            com = new SqlCommand();
            com.Connection = con;
            try
            {
                con.Open();
            }
            catch
            {

            }
           
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "sp_SelectStudent";

            dbAdapter = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            dbAdapter.Fill(dt);
            return dt;
        }
       
        public int InsertUser(BEL beobj)
        {

            com = new SqlCommand();
            com.Connection = con;
            try
            {
                con.Open();
            }
            catch { }
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "spInsertSType";
            
            com.Parameters.AddWithValue("@staffType", beobj.staffType);



            int x = com.ExecuteNonQuery();
            return x;
        }
        //sp_selectLast
        public DataTable GetUser()
        {
            com = new SqlCommand();
            com.Connection = con;
            try
            {
                con.Open();
            }
            catch { }
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "sp_selectLast";
            DataTable dt = new DataTable();
            SqlDataAdapter sd = new SqlDataAdapter(com);
            sd.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable SelectStaffByName(BEL beobj)
        {
            com = new SqlCommand();
            com.Connection = con;
            try
            {
                con.Open();
            }
            catch { }
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "sp_SelectByName";
            com.Parameters.AddWithValue("@firstName", beobj.name);
            DataTable hg = new DataTable();
            SqlDataAdapter ht = new SqlDataAdapter(com);
            ht.Fill(hg);
            con.Close();
            return hg;

        }
        public int updateStaff(BEL beobj)
        {
            com = new SqlCommand();
            com.Connection = con;
            try
            {
                con.Open();
            }
            catch { }
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "sp_UpdateStaff";
            com.Parameters.AddWithValue("@staffCode", beobj.staffCode);
            com.Parameters.AddWithValue("@firstName", beobj.name);
            com.Parameters.AddWithValue("@lastName", beobj.surname);
            com.Parameters.AddWithValue("@IDNumber", beobj.ID);
            com.Parameters.AddWithValue("@email", beobj.email);
            com.Parameters.AddWithValue("@phoneNo", beobj.phone);
          
            int c;
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            c = com.ExecuteNonQuery();
            return c;
        }

        public int removeStaff(BEL beobj)
        {
            com = new SqlCommand();
            com.Connection = con;
            try
            {
                con.Open();
            }
            catch { }
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "spt_RemoveStaff";
            com.Parameters.AddWithValue("@staffCode", beobj.staffCode);
            com.Parameters.AddWithValue("@status", beobj.status);

            int c;
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            c = com.ExecuteNonQuery();
            return c;
        }
        public int updateEquipmentType(EquipmentType equip)
        {
            com = new SqlCommand();
            com.Connection = con;
            try
            {
                con.Open();
            }
            catch { }
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "sp_UpdateByEquipType";
            com.Parameters.AddWithValue("@TypeID", equip.Type);
            com.Parameters.AddWithValue("@Description", equip.Description);
            com.Parameters.AddWithValue("@YearsValid", equip.YearsValid);
            com.Parameters.AddWithValue("@Status", equip.Status);
            com.Parameters.AddWithValue("@EquipCode", equip.EquipCode);

            int c;
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            c = com.ExecuteNonQuery();
            return c;
        }
        //sp_EquipmentTypeByEquipment
        public DataTable EquipmentTypeByEquipment(int code)
        {
            com = new SqlCommand();
            com.Connection = con;
            try
            {
                con.Open();
            }
            catch { }
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "sp_EquipmentTypeByEquipment";
            com.Parameters.AddWithValue("@EquipCode", code);
            DataTable hg = new DataTable();
            SqlDataAdapter ht = new SqlDataAdapter(com);
            ht.Fill(hg);
            con.Close();
            return hg;

        }
        public DataTable EquipmentByDescr(string desc)
        {
            com = new SqlCommand();
            com.Connection = con;
            try
            {
                con.Open();
            }
            catch { }
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "sp_SelectEquip";
            com.Parameters.AddWithValue("@Description", desc);
            DataTable hg = new DataTable();
            SqlDataAdapter ht = new SqlDataAdapter(com);
            ht.Fill(hg);
            con.Close();
            return hg;

        }
        public DataTable GetStudent(BEL beobj)
        {
            com = new SqlCommand();
            com.Connection = con;
            try
            {
                con.Open();
            }
            catch { }
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "sp_SelectStudent";
            DataTable dt = new DataTable();
            SqlDataAdapter sd = new SqlDataAdapter(com);
            sd.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable GetTaskType(BEL beobj)
        {
            com = new SqlCommand();
            com.Connection = con;
            try
            {
                con.Open();
            }
            catch { }
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "sp_selectTrack";
            DataTable dt = new DataTable();
            SqlDataAdapter sd = new SqlDataAdapter(com);
            sd.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable GetRequest(int StaffCode, int StudentCode)
        {
            com = new SqlCommand();
            com.Connection = con;
            try
            {
                con.Open();
            }
            catch { }
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "sp_selectTrack";
            com.Parameters.AddWithValue("staffCode", StaffCode);
            com.Parameters.AddWithValue("@StudentId",StudentCode);
            DataTable dt = new DataTable();
            SqlDataAdapter sd = new SqlDataAdapter(com);
            sd.Fill(dt);
            con.Close();
            return dt;
        }
        public int InsRequests(Request insertRequest)
        {
            com = new SqlCommand();
            com.Connection = con;
            try
            {
                con.Open();
            }
            catch { }

            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "InstertRequestsss";
            com.Parameters.AddWithValue("@RequestDescription", insertRequest.RequestDescription);
            com.Parameters.AddWithValue("@staffCode", insertRequest.StaffCode);
            com.Parameters.AddWithValue("@StudentId", insertRequest.StudentCode);
            com.Parameters.AddWithValue("@TaskType", insertRequest.TaskType);
            com.Parameters.AddWithValue("@Date", insertRequest.Date);
            com.Parameters.AddWithValue("@Time", insertRequest.Time);

            int c;
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            c = com.ExecuteNonQuery();
            return c;
        }
        public DataTable GetTaskType()
        {
            com = new SqlCommand();
            com.Connection = con;
            try
            {
                con.Open();
            }
            catch { }
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "sp_SelectTaskType";
       
            DataTable dt = new DataTable();
            SqlDataAdapter sd = new SqlDataAdapter(com);
            sd.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable GetRequest()
        {
            com = new SqlCommand();
            com.Connection = con;
            try
            {
                con.Open();
            }
            catch { }
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "sp_SeleRequest";

            DataTable dt = new DataTable();
            SqlDataAdapter sd = new SqlDataAdapter(com);
            sd.Fill(dt);
            con.Close();
            return dt;
        }
        public int DeleteVenue(Venues venues)
        {
            try
            {
                con.Open();
            }
            catch { }


            string sqlinsert = "dele_Venues";
            com.CommandType = CommandType.StoredProcedure;
            com = new SqlCommand(sqlinsert, con);
            com.Parameters.AddWithValue("@VenueCode", venues.VenueCode);
            com.Parameters.AddWithValue("@Status", venues.Status);

            int x = com.ExecuteNonQuery();
            return x;
        }
        public int UpdateVenue(int VenueCode, string descr, int capacity)
        {
            try
            {
                con.Open();
            }
            catch { }


            string sqlinsert = "UP_DATEVenue";
            com.CommandType = CommandType.StoredProcedure;
            com = new SqlCommand(sqlinsert, con);
            com.Parameters.AddWithValue("@VenueDescription", descr);
            com.Parameters.AddWithValue("@Capacity", capacity);
            com.Parameters.AddWithValue("@VenueCode", VenueCode);


            int x = com.ExecuteNonQuery();
            return x;
        }

    }
}
