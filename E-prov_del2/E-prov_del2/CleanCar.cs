using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_prov_del2
{
    class CleanCar : Car
    {
        
        public void CarClean()
        {
            passengers = generator.Next(4);

            contrabandAmount = 0;

        }


    }
}
