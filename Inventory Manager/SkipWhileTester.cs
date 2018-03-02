using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Inventory_Manager
{
    class SkipWhileTester
    {
        static void Main(string[] args) {
            var getInventory = TheInventoryManager.GetInventories();
            Console.WriteLine("ALL PRODUCTS: ");
            foreach (var item in getInventory)
            {
                Console.WriteLine($"{item.Id,-5} {item.Name,-30} {item.Price,-10} {item.EntryDate,-20}");
            }
            Console.WriteLine();
            Console.WriteLine("SKIP WHILE ACTION SHOWING SKIP FOR ALL PRODUCTS ABOVE N1500, I.E PRINT ALL PROUCTS ABOVE N2000");
            var skipWhile = getInventory.OrderBy(s=>s.Price).SkipWhile((s) => s.Price < 2000);
            foreach (var item in skipWhile)
                Console.WriteLine($"{item.Id,-5} {item.Name,-30} {item.Price,-10} {item.EntryDate,-20}");
            Console.WriteLine();
            Console.WriteLine("TAKE WHILE ACTION FOR PRODUCTS LESS THAN N2000 I.E PRINT ALL PRODUCTS BELOW 2000");
            var takeWhile = getInventory.OrderBy(s => s.Price).TakeWhile((s) => s.Price < 2000);
            foreach (var item in takeWhile)
                Console.WriteLine($"{item.Id,-5} {item.Name,-30} {item.Price,-10} {item.EntryDate,-20}");
            Console.WriteLine();
        }
    }
}
