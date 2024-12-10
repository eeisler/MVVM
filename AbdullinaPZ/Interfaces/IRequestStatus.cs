using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbdullinaPZ18.Interfaces
{
    public interface IRequestStatus
    {
        int RequestStatusId { get; }
        string RequestStatusName { get; set; }
    }
}
