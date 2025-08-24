using System;
class Rectangle {
  static void Main() {
    Console.Write("Nhap chieu dai cua hinh chu nhat : ");
    double l = Convert.ToDouble(Console.ReadLine());
    Console.Write("Nhap chieu rong cua hinh chu nhat : ");
    double w = Convert.ToDouble(Console.ReadLine());
    double chuvi = 2*(l+w);
    Console.Write("Chu vi cua hinh chu nhat la : " + chuvi);
    Console.ReadLine();
  }
}
