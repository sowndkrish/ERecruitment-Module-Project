using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication1
{
    public class ErrorHandler
    {
        public static string getErrorMsg(string operation,Exception ex)
        {
            string errormsg = string.Empty;
            if((ex is SqlException))
            {
                if (ex.Message.Contains("Primary Key"))
                    return "Already exists";
                else if (ex.Message.Contains("Unique Key"))
                    return "Already exists";
                else
                {
                    if (operation == "addBGCAdministrator")
                        return "Error in adding BGC Administrator";
                    else if(operation=="approveBGCAdministrator")
                        return "Error in approving BGC Administrator";
                    else if (operation == "viewBGCAdministrator")
                        return "Error in viewing BGC Administrator";
                    else if (operation == "login")
                        return "Error in logging in";
                    else if (operation == "changePassword")
                        return "Error in changing password";
                    else if (operation == "createBGCSchedule")
                        return "Error in creating BGCSchedule";
                    else if (operation == "viewBGCSchedule")
                        return "Error in viewing BGCSchedule";
                    else if (operation == "updateBGCSchedule")
                        return "Error in updating BGCSchedule";
                    else if (operation == "createEmployeeDetails")
                        return "Error in creating EmployeeDetails";
                    else if (operation == "viewEmployeeDetails")
                        return "Error in viewing EmployeeDetails";
                    else if(operation == "updateEmployeeDetails")
                        return "Error in updating EmployeeDetails";
                }
            }
            else if(ex is FormatException)
            {
                return "Error in Format";
            }
            return errormsg;
        }
    }
}