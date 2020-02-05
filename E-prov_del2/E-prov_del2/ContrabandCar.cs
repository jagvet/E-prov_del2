using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_prov_del2
{
    class ContrabandCar : Car
    {
        
        public void ContrabandCars()
        {
            passengers = generator.Next(5);
            contrabandAmount = generator.Next(1, 5);
        }


    }
}
