using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSoftt.Models;

namespace CSoftt.Contract
{
    public interface ILogReader
    {
        List<VisitLog> ReadLogFile(string filePath);
    }
}
