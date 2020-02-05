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

        public bool Examine()
        {
            if (contrabandAmount == 0)
            {
                return false;
            }
            else
            {
                return true;
            }

            alreadyChecked = true;
        }
        


    }
}
