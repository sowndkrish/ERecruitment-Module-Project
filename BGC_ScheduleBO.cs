using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types;

namespace Erecruitment_BO
{
   public class BGC_ScheduleBO:IBGCScheduleBO
    {
        int bgc_test_id;
        DateTime from_date;
        DateTime to_date;
        string location;
        int administrator_id;
        public int BGC_Test_Id
        {
            get
            {
                return bgc_test_id;
            }
            set
            {
                bgc_test_id = value;
            }
        }
        public DateTime From_Date
        {
            get
            {
                return from_date;
            }
            set
            {
                from_date = value;
            }
        }
        public DateTime To_Date
        {
            get
            {
                return to_date;
            }
            set
            {
                to_date = value;
            }
        }
        public int Administrator_Id
        {
            get
            {
                return administrator_id;
            }
            set
            {
                administrator_id = value;
            }
        }
        public string Location
        {
            get
            {
                return location;
            }
            set
            {
                location = value;
            }
        }
        
        public BGC_ScheduleBO()
        { }
        public BGC_ScheduleBO(int bgc_test_id,DateTime from_date,DateTime to_date,string location,int administrator_id)
        {
            this.bgc_test_id = bgc_test_id;
            this.from_date = from_date;
            this.to_date = to_date;
            this.location = location;
            this.administrator_id = administrator_id;
        }
    }
}
