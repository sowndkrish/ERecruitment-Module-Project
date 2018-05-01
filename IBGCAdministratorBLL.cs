using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types
{
    public interface IBGCAdministratorBLL
    {
        int addBGCAdministrator(IBGCAdministratorBO obj);
        int approveBGCAdministrator();
        void viewBGCAdministrator();
        int login();
        int changePassword();
    }
}
