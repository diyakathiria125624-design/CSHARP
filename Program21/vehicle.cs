using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program21
{
    internal class vehicle
    {
        string vehicle_type;
        public void get_data()
        {
            Console.WriteLine("Enter Vehicel type: ");
            vehicle_type = Console.ReadLine();
        }
        public void show_vehicel()
        {
            Console.WriteLine("vahicel Type: " + vehicle_type);
        }
    }
}
