using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DemoClasses
{
 class Program
 {
 static void Main()
 {
 TimePeriod t = new TimePeriod();
 // The property assignment causes the 'set' accessor to be called.
 try
 {
 t.Hours = 25;
 }
 catch (Exception e)
 {
 Console.WriteLine(e.Message);
 }

 // Retrieving the property causes the 'get' accessor to be called.
 Console.WriteLine($"Time in hours: {t.Hours}");
 }
 }
 class TimePeriod
 {
 private double seconds;
private double hours;
 public double Hours
 {
 get { return hours; }
 set
 {
 if (value < 0 || value > 24)
 throw new ArgumentOutOfRangeException(
 $"{nameof(value)} must be between 0 and 24.");
 hours=value;
 seconds = value * 3600;
 }
 }
 }
}
