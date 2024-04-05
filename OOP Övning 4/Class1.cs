using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Övning_4
{
    class Class1
    {
        private string förnamn;
        private string efternamn;
        public int ålder;
        private double höjd;
        private double vikt;

        public string metod1
        {
            get { return förnamn; }
            set { förnamn = value; }
        }

        public string metod2
        {
            get { return efternamn; }
            set { efternamn = value; }
        }

        public double metod3
        {
            get { return höjd; }
            set { höjd = value; }
        }

        public double metod4
        {
            get { return vikt; }
            set { vikt = value; }
        }

        public bool myndig()
        {
            return ålder >= 18;
        }

        public double BMI()
        {
            return vikt / (höjd * höjd);
        }
    }
}