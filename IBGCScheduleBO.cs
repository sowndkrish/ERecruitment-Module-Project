using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types
{
    public interface IBGCScheduleBO
    {
        int BGC_Test_Id { get; set; }
        DateTime From_Date { get; set; }
        DateTime To_Date { get; set; }
        string Location { get; set; }
        int Administrator_Id { get; set; }
    }
}
