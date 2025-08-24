using System;
class Circle {
  static void Main() {
    Console.Write("Nhap ban kinh cua duong tron : ");
    double r = Convert.ToDouble(Console.ReadLine());
    double pi = 3.14;
    double chuvi = 2 * pi * r;
    double dientich = pi * Math.Pow(r,2);
    Console.WriteLine("Chu vi cua duong tron la : " + chuvi);
    Console.Write("Dien tich cua duong tron la : " + dientich);
    Console.ReadLine();
  }
}
