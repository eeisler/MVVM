using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbdullinaPZ18.Interfaces
{
    public interface IRequest
    {
        int RequestId { get; }
        DateTime? StartDate { get; set; }
        int TechTypeId { get; set; }
        string TechModel { get; set; }
        string Problem { get; set; }
        int RequestStatusId { get; set; }
        DateTime? CompleteDate { get; set; }
        string Parts { get; set; }
        int MasterId { get; set; }
        int ClientId { get; set; }
    }
}
