using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Manager
{
    class PriceSum
    {
        static void Main()
        {
            var getInventory = TheInventoryManager.GetInventories();
            foreach (var item in getInventory)
            {
                Console.WriteLine($"{item.Name,-30} : N{item.Price,5} ");
            }

            Console.WriteLine();
            var a = TheInventoryManager.GetInventories().OrderBy(x => x.Id).Select(x => x.Price).Sum();
            Console.WriteLine("Calculating sum of all prices.....");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("The sum of all prices is N{0}", a);
            Console.WriteLine();
        }
    }
}
