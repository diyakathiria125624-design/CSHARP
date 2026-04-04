using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program21
{
    internal class cars : vehicle
    {
        string model_type, company_name;
        public void get_car()
        {
            Console.WriteLine("Enter model_type");
            model_type = Console.ReadLine();

            Console.WriteLine("Enter Company name");
            company_name = Console.ReadLine();
        }
        public void show_car()
        {
            Console.WriteLine("Model type:  " + model_type);
            Console.WriteLine("Company Name: " + company_name);
        }
    }
}
