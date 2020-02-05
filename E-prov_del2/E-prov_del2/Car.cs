using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_prov_del2
{
    class Car
    {
        public int passengers;
        public int contrabandAmount;
        public bool alreadyChecked = false;
        public Random generator = new Random();

        public bool Examine(string cf, string cnf)
        {
            int r = generator.Next(2);

            if (r == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

            alreadyChecked = true;
        }
        


    }
}
