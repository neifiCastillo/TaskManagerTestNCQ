using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.Application.Helpers
{
    public class SessionData
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public DateTime LoginTime { get; set; }
    }
}
