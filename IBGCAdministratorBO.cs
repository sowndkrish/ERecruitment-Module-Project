using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types
{
    public interface IBGCAdministratorBO
    {
        int BGC_Administrator_Id { get; set; }
        string Status { get; set; }
        DateTime Status_Change_Date { get; set; }
        int Employee_Id { get; set; }
    }
}
