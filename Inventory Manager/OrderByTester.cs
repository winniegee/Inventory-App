using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Manager
{
    class OrderByTester
    {
        static void Main(string[] args)
        {
            Console.WriteLine("All products are as below");
            var b = TheInventoryManager.GetInventories().OrderBy(x => x.Id).ToList();
            foreach (var n in b)
                Console.WriteLine($"{n.Id,-5} {n.Name,-30} {n.Price,-10} {n.EntryDate,-20}");

            Console.WriteLine();
           
            Console.WriteLine("DOING THE ORDERBY ID AND THENBY ENTRY DATE IN ASCENDING ORDER");
            TheInventoryManager.GetInventories().OrderBy(x => x.Id).ThenBy(x => x.EntryDate).ToList().ForEach(
                x => Console.WriteLine($"{x.Id,-5} {x.Name,-30} {x.Price,-10} {x.EntryDate,-20}"));


            Console.WriteLine();
            Console.WriteLine("DOING THE ORDERBY AND THENBY IN DESCENDING ORDER");
            TheInventoryManager.GetInventories().OrderByDescending(x => x.Id).ThenByDescending(x => x.EntryDate).ToList().ForEach(
                x => Console.WriteLine($"{x.Id,-5} {x.Name,-30} {x.Price,-10} {x.EntryDate,-20}"));

        }
    }
}
