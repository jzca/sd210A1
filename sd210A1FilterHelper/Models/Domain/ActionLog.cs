using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sd210A1FilterHelper.Models.Domain
{
    public class ActionLog
    {
        public int Id { get; set; }
        public string ControllerName { get; set; }
        public string ActionName { get; set; }
        public long ExecutionTime { get; set; }
    }
}