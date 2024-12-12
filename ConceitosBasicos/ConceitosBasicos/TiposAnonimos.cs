using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceitosBasicos.ConceitosBasicos
{
    public class TiposAnonimos
    {
        public void TesteTiposAnonimos()
        {
            var v = new { Amount = 108, Message = "Hello" };
            Console.WriteLine(v.Amount + v.Message);

            var product = new Product();
            var bonus = new { note = "You won!" };
            var shipment = new { address = "Nowhere St.", product };
            var shipmentWithBonus = new { address = "Somewhere St.", product, bonus };

            var anonArray = new[] { new { name = "apple", diam = 4 }, new { name = "grape", diam = 1 } };

            var apple = new { Item = "apples", Price = 1.35 };
            var onSale = apple with { Price = 0.79 };
            Console.WriteLine(apple);
            Console.WriteLine(onSale);

            var y = new { Title = "Hello", Age = 24 };

            Console.WriteLine(y.ToString()); // "{ Title = Hello, Age = 24 }"
        }
    }

    public class Product
    {
        public string? Color { get; set; }
        public decimal Price { get; set; }
        public string? Name { get; set; }
        public string? Category { get; set; }
        public string? Size { get; set; }
    }
}
