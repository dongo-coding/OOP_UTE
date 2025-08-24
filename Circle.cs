using System;
class Circle {
  static void Main() {
    Console.Write("Nhap ban kinh cua duong tron : ")
    double r = Convert.ToDouble(Console.ReadLine());
    double pi = 3.14;
    double chuvi = 2 * pi * r;
    Console.Write("Chu vi cua duong tron la : " + chuvi);
    Console.ReadLine();
  }
}
