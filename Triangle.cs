using System;
class Triangle{
  static void Main() {
   Console.Write("Nhap chieu dai canh thu nhat cua tam giac : ");
   double a = Convert.ToDouble(Console.ReadLine());
   Console.Write("Nhap chieu dai canh thu hai cua tam giac : ");
   double b = Convert.ToDouble(Console.ReadLine());
   Console.Write("Nhap chieu dai canh thu ba cua tam giac : ");
   double c = Convert.ToDouble(Console.ReadLine());
   double chuvi = a + b + c;
   double p = (a+b+c)/2;
   double dientich = Math.Sqrt(p*(p-a)*(p-b)*(p-c));
   Console.WriteLine("Chu vi cua tam giac la : " + chuvi);
   Console.Write("Dien tich cua tam giac la : " + dientich);
   Console.ReadLine();
  }
}
