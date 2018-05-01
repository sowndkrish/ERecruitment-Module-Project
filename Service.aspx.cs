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
    public partial class Service : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Add_Click(object sender, EventArgs e)
        {
            IBGCAdministratorBO objbgcadminbo = ERecruitmentFactoryBO.BGC_AdministratorBOFactory.createBGCAdministratorBO();
            try
            {
                objbgcadminbo.Status = ddlApproval.SelectedValue;
                objbgcadminbo.Status_Change_Date = DateTime.Now;
                objbgcadminbo.Employee_Id = int.Parse(ddlBGCta.SelectedValue);
                IBGCAdministratorBLL objbgcadminbll = ERecruitmentFactoryBLL.BGCAdministratorBLLFactory.createBGCAdministratorBLL();
                objbgcadminbll.addBGCAdministrator(objbgcadminbo);
            }
            catch
            {
                throw;
            }
        }
    }
}