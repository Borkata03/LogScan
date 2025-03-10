using CSoftt.Contract;
using CSoftt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSoftt.Services
{
    public class LogReader : ILogReader
    {
        public List<VisitLog> ReadLogFile(string filePath)
        {
            var logs = new List<VisitLog>();

            foreach (var line in File.ReadLines(filePath))
            {
                List<string> parts = line.Split(',').ToList();

                if (parts.Count == 3)
                {
                    logs.Add(new VisitLog
                    {
                        VisitDate = DateTime.Parse(parts[0]),
                        UserId = parts[1],
                        PageId = parts[2]
                    });
                }
            }

            return logs;
        }
    }
}
