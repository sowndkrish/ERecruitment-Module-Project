using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using ERecruitmentFactoryBO;
using Types;

namespace Erecruitment_DLL
{
    public class BGCScheduleDLL:IBGCScheduleDAL
    {
        public int createBGCSchedule(IBGCScheduleBO obj)
        {
            int ret = 0;
            string sqlstr = "Data Source=inchnilpdb02;Initial Catalog=CHN22_MMS104_Group3;Persist Security Info=True;User ID=mms104group3;password=mms104group3";
            SqlConnection con = new SqlConnection(sqlstr);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_select_bgcSchedule";
            cmd.Parameters.AddWithValue("@fromDate", obj.From_Date);
            cmd.Parameters.AddWithValue("@toDate", obj.To_Date);
            cmd.Parameters.AddWithValue("@location", obj.Location);
            cmd.Parameters.AddWithValue("@AdministratorID", obj.Administrator_Id);
            cmd.Parameters.AddWithValue("@BGC_test_ID", 0);
            cmd.Parameters["@BGC_test_ID"].Direction = ParameterDirection.Output;
            cmd.ExecuteNonQuery();
            con.Close();
            return ret;
        }
        public int updateBGCSchedule(IBGCScheduleBO obj)
        {
            int ret = 0;
            return ret;
        }
        public void viewBGCSchedule()
        {

        }
    }
}
