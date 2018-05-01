using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types;
using Erecruitment_BO;

namespace ERecruitmentFactoryBO
{
   public class BGC_ScheduleBOFactory
    {
        public static IBGCScheduleBO createBGCScheduleBO()
        {
            IBGCScheduleBO objbgcschedulebo = new BGC_ScheduleBO();
            return objbgcschedulebo;
        }
        public static IBGCScheduleBO createBGCScheduleBO(int bgc_test_id, DateTime from_date, DateTime to_date,string location, int administrator_id)
        {
            IBGCScheduleBO objbgcschedulebo = new BGC_ScheduleBO(bgc_test_id,from_date,to_date,location,administrator_id);
            return objbgcschedulebo;
        }
    }
}
