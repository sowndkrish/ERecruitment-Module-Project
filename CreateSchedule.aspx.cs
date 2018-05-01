using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ERecruitmentFactoryBO;
using ERecruitmentFactoryBLL;
using Types;
using System.Windows.Forms;


namespace WebApplication1
{
    public partial class CreateSchedule : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Schedule1_Click1(object sender, EventArgs e)
        {
            IBGCScheduleBO objbgcschedulebo = ERecruitmentFactoryBO.BGC_ScheduleBOFactory.createBGCScheduleBO();
            try
            {
                objbgcschedulebo.From_Date = Convert.ToDateTime(txtfrom.Text);
                objbgcschedulebo.To_Date = Convert.ToDateTime(txtto.Text);
                objbgcschedulebo.Location = ddlLocation.SelectedValue;
                objbgcschedulebo.Administrator_Id = Convert.ToInt32(ddlSchedule.SelectedValue);
                IBGCScheduleBLL objbgcschedulebll = ERecruitmentFactoryBLL.BGCScheduleBLLFactory.createBGCScheduleBLL();
                int ret=objbgcschedulebll.createBGCSchedule(objbgcschedulebo);
                //MessageBox.Show("BGC Administrator Selected");
            }
            catch
            {
                throw;
            }
        }
    }
}