using System;
class Trapezoid{
  static void Main() {
    Console.Write("Nhap chieu dai cua canh day thu nhat : ");
    double a = Convert.ToDouble(Console.ReadLine());
    Console.Write("Nhap chieu dai cua canh day thu hai : ");
    double b = Convert.ToDouble(Console.ReadLine());
    Console.Write("Nhap chieu dai cua canh ben thu nhat : ");
    double c = Convert.ToDouble(Console.ReadLine());
    Console.Write("Nhap chieu dai cua canh ben thu hai : ");
    double d = Convert.ToDouble(Console.ReadLine());
    Console.Write("Nhap chieu cao cua hinh thang : ");
    double h = Convert.ToDouble(Console.ReadLine());
    double chuvi = a + b + c + d;
    double dientich = ((a+b)*h)/2;
    Console.WriteLine("Chu vi cua hinh thang la : " + chuvi);
    Console.Write("Dien tich cua hinh thang la : " + dientich);
    Console.ReadLine();
  }
}
