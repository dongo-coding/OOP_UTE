using System;
class FirstEquation {
  static void Main() {
    Console.Write("Nhap a : ");
    double a = Convert.ToDouble(Console.ReadLine());
    Console.Write("Nhap b : ");
    double b = Convert.ToDouble(Console.ReadLine());
    double x=-b/a;
    Console.WriteLine("Nghiem cua phuong trinh la x = " + x);
    Console.ReadLine();
    
  }
}
