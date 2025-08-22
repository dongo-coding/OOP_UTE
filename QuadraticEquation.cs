using System;

class QuadraticEquation {
    static void Main() {
        Console.Write("Nhap a : ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Nhap b : ");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.Write("Nhap c : ");
        double c = Convert.ToDouble(Console.ReadLine());

        if (a == 0) {
            if (b == 0) {
                if (c == 0) Console.WriteLine("Phuong trinh vo so nghiem");
                else Console.WriteLine("Phuong trinh vo nghiem");
            } else {
                double x = -c / b;
                Console.WriteLine("Phuong trinh bac nhat, nghiem x = " + x);
            }
        } else {
            double delta = Math.Pow(b, 2) - 4 * a * c;

            if (delta < 0) {
                Console.WriteLine("Phuong trinh vo nghiem");
            }
            else if (delta > 0) {
                Console.WriteLine("Phuong trinh co hai nghiem phan biet:");
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("x1 = " + x1);
                Console.WriteLine("x2 = " + x2);
            }
            else {
                Console.WriteLine("Phuong trinh co nghiem kep:");
                double x = -b / (2 * a);
                Console.WriteLine("x = " + x);
            }
        }

        Console.ReadLine();
    }
}
