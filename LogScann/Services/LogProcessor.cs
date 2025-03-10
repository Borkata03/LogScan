using CSoftt.Contracts;
using CSoftt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CSoftt.Services
{
    public class LogProcessor : ILogProcessor
    {
        public DateTime GetUsersDateLogin(List<VisitLog> logs, string userId)
        {
            var dates = logs.Where(log => log.UserId == userId)
                .Select(log => log.VisitDate)
                .First();

            return dates;  
        }
        List<string> ILogProcessor.GetUsersWithMultiplePages(List<VisitLog> logs, DateTime startDate, DateTime endDate)
        {
            
            var filteredLogs = logs.Where(log => log.VisitDate >= startDate && log.VisitDate <= endDate).ToList();

            
            var result = filteredLogs
                .GroupBy(log => log.UserId)
                .Where(group => group.Select(log => log.PageId).Distinct().Count() >= 2)
                .Select(group => group.Key)
                .ToList();

            return result;  
        }
    }
}
