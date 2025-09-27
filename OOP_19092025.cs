using System;

class Diem
{
    public double x { get; set; }
    public double y { get; set; }

    public Diem(double x = 0, double y = 0)
    {
        this.x = x;
        this.y = y;

    }

    public void Nhap ()
    {
        Console.WriteLine("Nhap x:");
        x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Nhap y: ");
        y = Convert.ToDouble(Console.ReadLine());
    }

    public void Xuat()
    {
        Console.WriteLine($"{x}, {y}");
    }

    public double Kcach (Diem d)
    {
        return Math.Sqrt(Math.Pow(x-d.x,2) + Math.Pow(y-d.y,2));
    }
}

abstract class Hinh
{
    protected Diem d1, d2;

    public Hinh (Diem a = null, Diem b = null)
    {
        d1 = a ?? new Diem();
        d2 = b ?? new Diem();
    }

    public virtual void Nhap()
    {
        Console.WriteLine("Nhap diem thu nhat: ");
        d1.Nhap();
        Console.WriteLine("Nhap diem thu hai: ");
        d2.Nhap();
    }

    public virtual void Xuat()
    {
        Console.Write("Diem 1: "); 
        d1.Xuat();
        Console.Write("Diem 2:");
        d2.Xuat();
    }

    public abstract double DT();
}

class DoanThang : Hinh
{
    public DoanThang(Diem a = null, Diem b = null) : base(a, b) { }

    public override double DT()
    {
        return 0;
        throw new NotImplementedException();
    }
    public double Dodai()
    {
        return d1.Kcach(d2);
    }

    public override void Xuat()
    {
        Console.WriteLine("===Doan thang===");
        base.Xuat();
        Console.WriteLine($"Do dai: {Dodai()}");
    }
}

class HinhChuNhat : Hinh
{
    public HinhChuNhat(Diem a = null, Diem b = null) : base(a, b) { }

    public override double DT()
    {
        double dai = Math.Abs(d1.x - d2.x);
        double rong = Math.Abs(d1.y - d2.y);
        return dai * rong;
    }

    public override void Xuat()
    {
        Console.WriteLine("===Hinh chu nhat===");
        base.Xuat();
        Console.WriteLine($"Dien tich: {DT()}");
    }

}

class HinhTamGiac : Hinh
{
    protected double ccao;
    public HinhTamGiac (Diem a=null,Diem b = null,double h=0) : base(a, b)
    {
        ccao = h;
    }

    public override void Nhap()
    {
        base.Nhap();
        Console.Write("Nhap chieu cao: ");
        ccao = Convert.ToDouble(Console.ReadLine());
        
    }

    public override double DT()
    {
        double day = d1.Kcach(d2);
        return 0.5 * day * ccao;
    }

    public override void Xuat()
    {
        Console.WriteLine("===Hinh tam giac===");
        base.Xuat();
        Console.WriteLine($"Chieu cao: {ccao}");
        Console.WriteLine($"Dien tich: {DT()}");
    }

}

class Program
{
    static void Main (string[] args)
    {
        DoanThang dt = new DoanThang();
        dt.Nhap();
        dt.Xuat();

        HinhChuNhat hcn = new HinhChuNhat();
        hcn.Nhap();
        hcn.Xuat();

        HinhTamGiac htg=new HinhTamGiac();
        htg.Nhap();
        htg.Xuat();

        Console.ReadLine();
    }
}
