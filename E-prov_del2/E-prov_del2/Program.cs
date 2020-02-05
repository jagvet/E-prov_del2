using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_prov_del2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många bilar ska skapas? Skriv ett tal större än 0");

            string answer = Console.ReadLine();
            int amountCars;
            bool success = int.TryParse(answer, out amountCars);

            while (amountCars <= 0)
            {
                Console.WriteLine("Skriv ett tal större än 0");
                answer = Console.ReadLine();
                success = int.TryParse(answer, out amountCars);
            }

            List<Car> carList = new List<Car>();
            

            Console.ReadLine();
        }
    }
}
