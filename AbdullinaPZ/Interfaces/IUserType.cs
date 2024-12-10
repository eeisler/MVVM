using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbdullinaPZ18.Interfaces
{
    public interface IUserType
    {
        int UserTypeId { get; }
        string UserTypeName { get; set; }

        public bool IsMasterRole()
    }
}
