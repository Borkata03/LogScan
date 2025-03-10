using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSoftt.Models
{
    public class VisitLog
    {
        public DateTime VisitDate { get; set; }

        public string UserId { get; set; } = null!;

        public string PageId { get; set; } = null!;
    }
}
