using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERecruitmentDALFactory;
using ERecruitmentFactoryBO;
using Types;

namespace ERecruitment_BLL
{
    public class BGCAdministratorBLL:IBGCAdministratorBLL
    {
        public int addBGCAdministrator(IBGCAdministratorBO obj)
        {
            int ret=0;
            IBGCAdministratorDAL objbgcadmindal = ERecruitmentDALFactory.BGCAdministratorDALFactory.createBGCAdministratorDAL();
            objbgcadmindal.addBGCAdministrator(obj);
            return ret;
        }
        public int approveBGCAdministrator()
        {
            int ret = 0;
            IBGCAdministratorDAL objbgcadmindal = ERecruitmentDALFactory.BGCAdministratorDALFactory.createBGCAdministratorDAL();

            return ret;
        }
        public void viewBGCAdministrator()
        {
            IBGCAdministratorDAL objbgcadmindal = ERecruitmentDALFactory.BGCAdministratorDALFactory.createBGCAdministratorDAL();
            objbgcadmindal.viewBGCAdministrator();
        }
        public int login()
        {
            int ret = 0;
            IBGCAdministratorDAL objbgcadmindal = ERecruitmentDALFactory.BGCAdministratorDALFactory.createBGCAdministratorDAL();

            return ret;
        }
        public int changePassword()
        {
            int ret = 0;
            IBGCAdministratorDAL objbgcadmindal = ERecruitmentDALFactory.BGCAdministratorDALFactory.createBGCAdministratorDAL();

            return ret;
        }
    }
}
