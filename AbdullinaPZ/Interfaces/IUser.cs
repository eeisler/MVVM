using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbdullinaPZ18.Interfaces
{
    public interface IUser
    {
        int UserId { get; }
        string Name { get; set; }
        string Phone { get; set; }
        string Login { get; set; }
        string Password { get; set; }

        bool IsPhoneValid();

    }
}
