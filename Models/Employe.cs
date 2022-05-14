using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationTp2.Models
{
    public class Employe
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Departement { get; set; }
        public int Salary { get; set; }

        public string photoPath { get; set; }
    }
}
