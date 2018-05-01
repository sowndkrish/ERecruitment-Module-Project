using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types;
using Erecruitment_DLL;

namespace ERecruitmentDALFactory
{
    public class BGCAdministratorDALFactory
    {
        public static IBGCAdministratorDAL createBGCAdministratorDAL()
        {
            IBGCAdministratorDAL objbgcadministratordal = new BGCAdministratorDLL();
            return objbgcadministratordal;
        }
    }
}
