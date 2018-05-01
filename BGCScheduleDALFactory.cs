using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types;
using Erecruitment_DLL;

namespace ERecruitmentDALFactory
{
    public class BGCScheduleDALFactory
    {
        public static IBGCScheduleDAL createBGCScheduleDAL()
        {
            IBGCScheduleDAL objbgcscheduledal = new BGCScheduleDLL();
            return objbgcscheduledal;
        }
    }
}
