using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_of_Objects
{
    class Personas
    {
        private string Name;
        private string LastName;
        private string PhoneNumber;
        private int Year;

        public string GSNames
        {
            get
            {
                return Name;
            
            }
            set
            {
                Name = value;
            }
        }
        public string GSLastNames
        {
            get
            {
                return LastName;
            }
            set
            {
                LastName = value;
            }
        }
        public string GSPhoneNumbers
        {
            get
            {
                return Convert.ToString(PhoneNumber);
            }
            set
            {
                PhoneNumber = value;
            }
        }
        public int SGYear
        {
            get
            {
                return Year;
            }
            set
            {
                Year = value;
            }
        }
        public int Age(int N)
        {
            return DateTime.Now.Year - N;
        }
        public string Imprimir()
        {
            return Name + "\t" + LastName + "\t" + PhoneNumber;
        }       
    }
}
