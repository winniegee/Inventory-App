using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Manager
{
    public class OtherOperators
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Concatenating...");
            System.Threading.Thread.Sleep(1000);
            var together= TheInventoryManager.GetInventories().Concat(TheInventoryManager.FreshInventories()).ToList();
            foreach (var item in together)
            {
                Console.WriteLine($"{item.Id,-5} {item.Name,-30} {item.Price,-10} {item.EntryDate,-20}");

            }
                Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("SHOWING THE UNION OPERATOR....");
            System.Threading.Thread.Sleep(1000);
            var union = TheInventoryManager.GetInventories().Union(TheInventoryManager.FreshInventories(), new InventoryComparer());
            foreach (var item in union)
                Console.WriteLine($"{item.Id,-5} {item.Name,-30} {item.Price,-10} {item.EntryDate,-20}");
            Console.WriteLine();
            foreach (var item in together)
            {
                Console.WriteLine($"{item.Id,-5} {item.Name,-30} {item.Price,-10} {item.EntryDate,-20}");
                
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("SHOWING THE DISTINCT OPERATOR");
            System.Threading.Thread.Sleep(1000);
            var distinct = TheInventoryManager.GetInventories().Distinct();
            foreach (var item in distinct)
                Console.WriteLine($"{item.Id,-5} {item.Name,-30} {item.Price,-10} {item.EntryDate,-20}");
            Console.WriteLine();
           Console.WriteLine("SHOWING THE INTERSECT OPERATOR");
            System.Threading.Thread.Sleep(1000); Console.WriteLine();
            var intersect = TheInventoryManager.GetInventories().Intersect(TheInventoryManager.FreshInventories(), new InventoryComparer());
            foreach (var item in intersect)
                Console.WriteLine($"{item.Id,-5} {item.Name,-30} {item.Price,-10} {item.EntryDate,-20}");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("SHOWING THE EXCEPT OPERATOR");
            System.Threading.Thread.Sleep(1000); Console.WriteLine();
            var Except = TheInventoryManager.GetInventories().Except(TheInventoryManager.FreshInventories(),new InventoryComparer());
            foreach (var item in Except)
                Console.WriteLine($"{item.Id,-5} {item.Name,-30} {item.Price,-10} {item.EntryDate,-20}");
        }
    }
}
