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
    public class BGCAdministratorDLL:IBGCAdministratorDAL
    {
        public int addBGCAdministrator(IBGCAdministratorBO obj)
        {
            int ret = 0;        
            string sqlstr = "Data Source=inchnilpdb02;Initial Catalog=CHN22_MMS104_Group3;Persist Security Info=True;User ID=mms104group3;password=mms104group3";
            SqlConnection con = new SqlConnection(sqlstr);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_select_bgcta";
            cmd.Parameters.AddWithValue("@status", obj.Status);
            cmd.Parameters.AddWithValue("@statusChangeDate", obj.Status_Change_Date);
            cmd.Parameters.AddWithValue("@EmployeeID", obj.Employee_Id);
            cmd.Parameters.AddWithValue("@BGC_Administrator_ID", 0);
            cmd.Parameters["@BGC_Administrator_ID"].Direction = ParameterDirection.Output;
            cmd.ExecuteNonQuery();
            con.Close();
            return ret;
        }
        public int approveBGCAdministrator()
        {
            int ret = 0;
            return ret;
        }
        public void viewBGCAdministrator()
        {

        }
        public int login()
        {
            int ret = 0;
            return ret;
        }
        public int changePassword()
        {
            int ret = 0;
            return ret;
        }
    }
}
