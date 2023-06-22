using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCore
{
    public class Audit
    {
        public int AuditID { get; set; }
        public string AuditName { get; set; }
        public Post AuditPost { get; set; }
    }
}
