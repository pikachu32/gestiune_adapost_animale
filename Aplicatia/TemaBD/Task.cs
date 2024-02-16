using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemaBD
{
    internal class Task
    {
        public int ID { get; set; }

        public string Description { get; set; }
        public DateTime Assignment_Date { get; set; }
        public DateTime Deadline_Date { get; set;}
        public int ID_Employee { get; set; }
        public string Name { get; set; }
        public string Function { get; set; }
    }
}
