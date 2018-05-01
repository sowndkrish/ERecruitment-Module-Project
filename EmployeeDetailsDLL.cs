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
   public class EmployeeDetailsDLL:IEmployeeDetailsDAL
    {
       public int createEmployeeDetails(IEmployeeDetailsBO objemp)
       {
           int ret = 0;
           SqlConnection conn = new SqlConnection();
           conn.ConnectionString = DataUtility.getConnection();
           try
           {
               conn.Open();
               SqlCommand command = new SqlCommand();
               command.CommandType = CommandType.StoredProcedure;
               command.CommandText = "sp_insert_empData1";
               command.Connection = conn;
               command.Parameters.AddWithValue("@EmployeeID", 0);
               command.Parameters.AddWithValue("@EmployeeName", objemp.Employee_Name);
               command.Parameters.AddWithValue("@DOB", objemp.DOB);
               command.Parameters.AddWithValue("@division", objemp.Division);
               command.Parameters.AddWithValue("@gender", objemp.Gender);
               command.Parameters.AddWithValue("@DOJ", objemp.DOJ);
               command.Parameters.AddWithValue("@CTC", objemp.CTC);
               command.Parameters.AddWithValue("@Designation", objemp.Designation);
               command.Parameters.AddWithValue("@UnitHeadID", objemp.Unit_Head_Id);
               command.Parameters.AddWithValue("@projectID", objemp.Project_Id);
               command.Parameters.AddWithValue("@isHR", 0);
               command.Parameters.AddWithValue("@isNew", 0);
               command.Parameters["@EmployeeID"].Direction = ParameterDirection.Output;
               command.ExecuteNonQuery();
               //return Convert.ToInt32(command.Parameters["@EmployeeID"]);
               conn.Close();
               return ret;
           }
           catch
           {
               throw;
           }
       }
        public void viewEmployeeDetails()
        {

        }
        public int updateEmployeeDetails(IEmployeeDetailsBO obj)
        {
            int ret = 0;
            return ret;
        }
    }
}
