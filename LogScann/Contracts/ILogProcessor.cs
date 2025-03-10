using CSoftt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSoftt.Contracts
{
    public interface ILogProcessor
    {
        List<string> GetUsersWithMultiplePages(List<VisitLog> logs, DateTime startDate, DateTime endDate);

        DateTime GetUsersDateLogin(List<VisitLog> logs,string userId);
    }
}
    