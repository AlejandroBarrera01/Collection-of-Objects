using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_of_Objects
{
    class Docentes:Personas
    {
        private string Facultad;
        private double Salario;

        public string GSFaculta
        {
            set { Facultad = value; }
            get { return Facultad; }
        }
        public double SGSalario
        {
            set { Salario = value; }
            get { return Salario; }
        }
    
    }


}
