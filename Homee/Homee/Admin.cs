using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homee
{
    internal class Admin : User
    {
        public bool IsSuperAdmin;
        public string Section;
        public Admin(string username, string password, bool issuperadmin, string section) : base(username, password)
        {
            IsSuperAdmin = issuperadmin;
            Section = section;
        }
        public string getinfo()
        {
            return GetInfo()+ $"IsSuperAdmin: {IsSuperAdmin}\nSection: {Section}";
        }
    }
    
}
