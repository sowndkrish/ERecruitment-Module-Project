using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERecruitment_BLL;
using Types;

namespace ERecruitmentFactoryBLL
{
    public class BGCAdministratorBLLFactory
    {
        public static IBGCAdministratorBLL createBGCAdministratorBLL()
        {
            IBGCAdministratorBLL objbgcadministratorbll = new BGCAdministratorBLL();
            return objbgcadministratorbll;
        }
    }
}
