using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManager.Repository.Models
{
    public class Project
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Employee { get; set; }
        
        public string Status { get; set; }

        public int FinBalance { get; set; }

        public int FinIncome { get; set; }

        public int FinOutcome { get; set; }

        public DateTime DateRun { get; set; }

        public DateTime DateEnd { get; set; }
    }
}
