using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types
{
    public interface IBGCScheduleDAL
    {
        int createBGCSchedule(IBGCScheduleBO obj);
        int updateBGCSchedule(IBGCScheduleBO obj);
        void viewBGCSchedule();
    }
}
