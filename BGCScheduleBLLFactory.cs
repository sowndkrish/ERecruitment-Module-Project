using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERecruitment_BLL;
using Types;

namespace ERecruitmentFactoryBLL
{
   public class BGCScheduleBLLFactory
    {
        public static IBGCScheduleBLL createBGCScheduleBLL()
        {
            IBGCScheduleBLL objbgcschedulebll = new BGCScheduleBLL();
            return objbgcschedulebll;
        }
    }
}
