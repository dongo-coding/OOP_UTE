using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

abstract class Employee
{
    public string name;
    public string id;
    public int birthYear;
    public double basicSalary;

    public Employee () {  }
    public Employee(string Name, string ID, int BirthYear, double BasicSalary)
    {
        name = Name;
        id = ID;
        birthYear = BirthYear;
        basicSalary = BasicSalary;
    }
public abstract double CalculateSalary();
    


    public virtual void Nhap()
    {
        Console.WriteLine("Nhap ten: ");
        name = Console.ReadLine();
        Console.WriteLine("Nhap ID: ");
        id = Console.ReadLine();
        Console.WriteLine("Nhap nam sinh: ");
        birthYear = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Nhap luong co ban:");
        basicSalary = Convert.ToDouble(Console.ReadLine());
    }


    public virtual void Xuat()
    {
        Console.WriteLine($"Ten: {name} ");
        Console.WriteLine($"ID: {id}");
        Console.WriteLine($"Nam sinh: {birthYear}");
        Console.WriteLine($"Luong co ban: {basicSalary:C}  ");
        Console.WriteLine($"Tong luong: {CalculateSalary():C} ");
    }



}
class Accountant : Employee
{
    public double allowance;

    public override void Nhap()
    {
        base.Nhap();
        Console.WriteLine("Nhap tien tro cap: ");
        allowance = Convert.ToDouble(Console.ReadLine());
    }

    public override double CalculateSalary()
    {
        return basicSalary + allowance;
    }

    public override void Xuat()
    {
        base.Xuat();
        Console.WriteLine($"Tien tro cap: {allowance}");
    }
}

class Business_Staff : Employee
{
    public int numofContract;

    public override void Nhap()
    {
        base.Nhap();
        Console.WriteLine("Nhap so luong hop dong: ");
        numofContract = Convert.ToInt32(Console.ReadLine());
    }

    public override double CalculateSalary()
    {
        return basicSalary + numofContract * 100;
    }

    public override void Xuat()
    {
        base.Xuat();
        Console.WriteLine($"So luong hop dong: {numofContract}");
    }

}

class Guarding_Staff : Employee
{
    public override void Nhap()
    {
        base.Nhap();
    }

    public override double CalculateSalary()
    {
        return 0;
    }

    public override void Xuat()
    {
        Console.Write("Nhan vien bao ve - Khong tinh luong");
    }
}

class Company
{
    private List<Employee> employees = new List<Employee>();

    public void Add(Employee e)
    {
        employees.Add(e);
    }

    public void XemToanBo()
    {
        Console.WriteLine("\n=== DANH SACH NHAN VIEN ===");
        foreach (var e in employees)
        {
            e.Xuat();
            Console.WriteLine("---------------------");
        }
    }

    public double TotalSalary()
    {
        double TS = 0;
        foreach (var e in employees)
        {
            TS += e.CalculateSalary();
        }
        return TS;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Company ct = new Company();

            Console.Write("Nhap so luong ke toan: ");
            int slKT = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < slKT; i++)
            {
                Console.WriteLine($"Ke toan {i + 1}");
                Accountant a = new Accountant();
                a.Nhap();
                ct.Add(a);
            }

            Console.Write("Nhap so luong nhan vien kinh doanh: ");
            int slBS = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < slBS; i++)
            {
                Console.WriteLine($"Nhan vien kinh doanh {i + 1}");
                Business_Staff s = new Business_Staff();
                s.Nhap();
                ct.Add(s);
            }

            Console.Write("Nhap so luong nhan vien bao ve: ");
            int slGS = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < slGS; i++)
            {
                Console.WriteLine($"Nhan vien bao ve {i + 1}");
                Guarding_Staff g = new Guarding_Staff();
                g.Nhap();
                ct.Add(g);
            }

            ct.XemToanBo();

            Console.WriteLine($"\n Tong luong phai tra: {ct.TotalSalary():C} ");
        }


    }
} //apply abstract class , override method to show polymorphism in OOP
