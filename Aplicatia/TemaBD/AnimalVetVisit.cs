using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemaBD
{
    internal class AnimalVetVisit
    {
        public int ID_Visit { get; set; }
        public int ID_Animal { get; set; }
        public string Name_Animal { get; set; }
        public string Species { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }
        public string State { get; set; }
        public int ID_Employee { get; set; }

        public int ID_Vet { get; set; }
        public string Name_Vet { get; set; }
        public string Specialization { get; set; }
        public string Experience { get; set; }
        public string PhoneNumber { get; set; }

        public DateTime Date { get; set; }
        public string Diagnostic { get; set; }
        public string Treatment { get; set; }

    }
}
