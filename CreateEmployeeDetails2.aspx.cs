using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ERecruitmentFactoryBO;
using ERecruitmentFactoryBLL;
using Types;

namespace WebApplication1
{
    public partial class CreateEmployeeDetails2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Add_Click(object sender, EventArgs e)
        {
            IEmployeeDetailsBO objemp = ERecruitmentFactoryBO.Employee_DetailsBOFactory.createEmployeeDetailsBO();
            try
            {
                objemp.Employee_Name = txtempname.Text;
                objemp.DOB = DateTime.Parse(txtdob.Text);
                objemp.DOJ = DateTime.Parse(txtdatej.Text);
                objemp.Gender = rblgender.SelectedValue;
                objemp.Division = txtlocation.Text;
                objemp.Designation = ddldesign.Text;
                objemp.CTC = int.Parse(txtctc.Text);
                objemp.Unit_Head_Id = int.Parse(ddlunitheadid.SelectedValue);
                objemp.Project_Id = int.Parse(ddlprojectid.SelectedValue);
                IEmployeeDetailsBLL empdetobjBLL = ERecruitmentFactoryBLL.EmployeeDetailsBLLFactory.createEmployeeDetailsBLL();
                int ret = empdetobjBLL.createEmployeeDetails(objemp);

            }
            catch
            {
                //string msg = ErrorHandler.getErrorMsg("addBGCAdministrator", ex);
                //Label12.Text = msg;
            }
        }


        //protected void ddldesign_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (ddldesign.SelectedIndex == 1)
        //    {
        //        txtctc.Text = "1.8";

        //    }
        //    else if (ddldesign.SelectedIndex == 2)
        //    {
        //        txtctc.Text = "1.5";
        //    }
        //    else if (ddldesign.SelectedIndex == 3)
        //    {
        //        txtctc.Text = "2";
        //    }
        //    else if (ddldesign.SelectedIndex == 4)
        //    {
        //        txtctc.Text = "2.5";
        //    }
        //}

    }
}