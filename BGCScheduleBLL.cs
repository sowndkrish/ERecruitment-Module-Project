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
   public class BGCScheduleBLL:IBGCScheduleBLL
    {
        public int createBGCSchedule(IBGCScheduleBO obj)
        {
            int ret = 0;
            IBGCScheduleDAL objbgcschdal = ERecruitmentDALFactory.BGCScheduleDALFactory.createBGCScheduleDAL();
            objbgcschdal.createBGCSchedule(obj);
            return ret;
        }
        public int updateBGCSchedule(IBGCScheduleBO obj)
        {
            int ret = 0;
            IBGCScheduleDAL objbgcschdal = ERecruitmentDALFactory.BGCScheduleDALFactory.createBGCScheduleDAL();

            return ret;
        }
        public void viewBGCSchedule()
        {
            IBGCScheduleDAL objbgcschdal = ERecruitmentDALFactory.BGCScheduleDALFactory.createBGCScheduleDAL();
            objbgcschdal.viewBGCSchedule();
        }
    }
}
