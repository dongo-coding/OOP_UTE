using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

class Employee
{
    public string name;
    public string id;
    public int birthYear;
    public double basicSalary;
    public double allowance;
    public double numofconstract;

    public Employee(string Name, string ID, int BirthYear, double BasicSalary, double Allowance, double noc)
    {
        name = Name;
        id = ID;
        birthYear = BirthYear;
        basicSalary= BasicSalary;
        allowance = Allowance;
        numofconstract = noc;
    }

    public Employee()
    {
        name = "";
        id = "";
        basicSalary = 0;
        allowance = 0;
        numofconstract = 0;
    }
    public double Salary1()
    {
        return basicSalary;

    }

    public double Salary2()
    {
        return basicSalary + allowance;
    }
    public double Salary3()
    {
        return basicSalary + numofconstract * 100;
    }


    public void NhapNV()
    {
        Console.WriteLine("Nhap ten: ");
        name=Console.ReadLine();
        Console.WriteLine("Nhap ID: ");
        id = Console.ReadLine();
        Console.WriteLine("Nhap nam sinh: ");
        birthYear = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Nhap luong co ban:");
        basicSalary=Convert.ToDouble(Console.ReadLine());
    }

    public void NhapKT()
    {
        Console.WriteLine("Nhap ten: ");
        name = Console.ReadLine();
        Console.WriteLine("Nhap ID: ");
        id = Console.ReadLine();
        Console.WriteLine("Nhap nam sinh: ");
        birthYear = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Nhap luong co ban:");
        basicSalary = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Nhap tien tro cap:");
        allowance = Convert.ToDouble(Console.ReadLine());
    }

    public void NhapBS()
    {
        Console.WriteLine("Nhap ten: ");
        name = Console.ReadLine();
        Console.WriteLine("Nhap ID: ");
        id = Console.ReadLine();
        Console.WriteLine("Nhap nam sinh: ");
        birthYear = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Nhap luong co ban:");
        basicSalary = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Nhap so luong hop dong: ");
        numofconstract=Convert.ToInt32(Console.ReadLine());



    }

    public void NhapGS()
    {
        Console.WriteLine("Nhap ten: ");
        name = Console.ReadLine();
        Console.WriteLine("Nhap ID: ");
        id = Console.ReadLine();
        Console.WriteLine("Nhap nam sinh: ");
        birthYear = Convert.ToInt32(Console.ReadLine());
    }
    
    public void XuatNV()
    {
        Console.WriteLine($"Ten: {name} ");
        Console.WriteLine($"ID: {id}");
        Console.WriteLine($"Nam sinh: {birthYear}");
        Console.WriteLine($"Luong co ban: {Salary1():C}  ");
        Console.WriteLine($"Tong luong: {Salary1():C} ");
    }

    public void XuatKT()
    {
        Console.WriteLine($"Ten: {name} ");
        Console.WriteLine($"ID: {id}");
        Console.WriteLine($"Nam sinh: {birthYear}");
        Console.WriteLine($"Luong co ban: {Salary1():C}  ");
        Console.WriteLine($"Tien tro cap: {allowance:C}");
        Console.WriteLine($"Tong luong: {Salary2():C} ");

    }

    public void XuatBS()
    {
        Console.WriteLine($"Ten: {name} ");
        Console.WriteLine($"ID: {id}");
        Console.WriteLine($"Nam sinh: {birthYear}");
        Console.WriteLine($"Luong co ban: {Salary1():C}  ");
        Console.WriteLine($"So luong hop dong: {numofconstract}");
        Console.WriteLine($"Tong luong: {Salary3():C} ");

    }

   

}
class Accountant : Employee
{
    public double Salary2()
    {
        return basicSalary + allowance;
    }
}

class Business_Staff : Employee
{
    public double Salary3()
    {
        return basicSalary + numofconstract * 100; 
    }

}

class Guarding_Staff : Employee
{
    public void Thongbao()
    {
        Console.WriteLine("Khong thuc hien");
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Employee> employees = new List<Employee>();
        Console.Write("Nhap so luong nhan vien: ");
        int slNV = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < slNV; i++)
        {
            Console.WriteLine($"Nhan vien {i + 1} \n");
            Employee e = new Employee();
            e.NhapNV();
            employees.Add(e);
        }

        List<Accountant> accountants = new List<Accountant>();
        Console.Write("Nhap so luong ke toan: ");
        int slKT = Convert.ToInt32(Console.ReadLine());

        for (int j = 0; j < slKT; j++)
        {
            Console.WriteLine($"Ke toan {j + 1} \n");
            Accountant a = new Accountant();
            a.NhapKT();
            accountants.Add(a);
        }
        List<Business_Staff> BS = new List<Business_Staff>();
        Console.Write("Nhap so luong nhan vien kinh doanh: ");
        int slBS = Convert.ToInt32(Console.ReadLine());

        for (int k = 0; k < slBS; k++)
        {
            Console.WriteLine($"Nhan vien kinh doanh {k + 1}\n");
            Business_Staff s = new Business_Staff();
            s.NhapBS();
            BS.Add(s);
        }

        List<Guarding_Staff> GS = new List<Guarding_Staff>();
        Console.Write("Nhap so luong nhan vien thoi vu: ");
        int slGS=Convert.ToInt32(Console.ReadLine());

        for(int l = 0; l < slGS; l++)
        {
            Console.WriteLine($"Nhan vien thoi vu {l + 1}");
            Guarding_Staff g = new Guarding_Staff();
            g.NhapGS();
            GS.Add(g);
        }

        Console.WriteLine("\n\nLUONG CUA NHAN VIEN : ");
        foreach (Employee e in employees)
        {
            e.XuatNV();
        }

        Console.WriteLine("\n\nLUONG CUA KE TOAN: ");
        foreach (Accountant a in accountants)
        {
            a.XuatKT();
        }

        Console.WriteLine("\n\nLUONG CUA NHAN VIEN KINH DOANH ");
        foreach (Business_Staff s in BS)
        {
            s.XuatBS();
        }

        Console.WriteLine("\n\nLUONG CUA NHAN VIEN THOI VU ");
        foreach(Guarding_Staff g in GS)
        {
            g.Thongbao();
        }
    }
    

}
