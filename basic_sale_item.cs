using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DemoClasses
{
 public class SaleItem
 {
 public string Name
 { get; set; }
 public decimal Price
 { get; set; }
 }
 class Program
 {
 static void Main()
 {
 var item = new SaleItem { Name = "Shoes", Price = 19.95m };
 Console.WriteLine($"{item.Name}: sells for {item.Price:C2}");
 }
 }
}
