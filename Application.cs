using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public string Name { get; set; }
    public string Id { get; set; }
    public double Score { get; set; }

    public Student(string name, string id, double score)
    {
        Name = name;
        Id = id;
        Score = score;
    }

    public void Display()
    {
        Console.WriteLine($"Student: {Name}, ID: {Id}, Score: {Score}");
    }
}

class ClassGroup
{
    public string Name { get; set; }
    public List<Student> Students { get; set; }

    public ClassGroup(string name)
    {
        Name = name;
        Students = new List<Student>();
    }

    public void AddStudent(Student s)
    {
        Students.Add(s);
    }

    public void Display()
    {
        Console.WriteLine($"  Class: {Name}, Students: {Students.Count}");
        foreach (var s in Students)
            s.Display();
    }
}

class Faculty
{
    public string Name { get; set; }
    public List<ClassGroup> Classes { get; set; }

    public Faculty(string name)
    {
        Name = name;
        Classes = new List<ClassGroup>();
    }

    public void AddClass(ClassGroup c)
    {
        Classes.Add(c);
    }

    public void Display()
    {
        Console.WriteLine($"Faculty: {Name}");
        foreach (var c in Classes)
            c.Display();
    }
}

class University
{
    public string Name { get; set; }
    public List<Faculty> Faculties { get; set; }

    public University(string name)
    {
        Name = name;
        Faculties = new List<Faculty>();
    }

    public void AddFaculty(Faculty f)
    {
        Faculties.Add(f);
    }

    // Search a faculty by name
    public Faculty SearchFaculty(string facultyName)
    {
        return Faculties.FirstOrDefault(f => f.Name == facultyName)
           ?? new Faculty("Unknown Faculty");
    }

    // Find students with highest score in the university
    public List<Student> FindTopStudents()
    {
        var allStudents = Faculties
            .SelectMany(f => f.Classes)
            .SelectMany(c => c.Students)
            .ToList();

        if (allStudents.Count == 0) return new List<Student>();

        double maxScore = allStudents.Max(s => s.Score);
        return allStudents.Where(s => s.Score == maxScore).ToList();
    }

    // Find the class with the largest number of students
    public ClassGroup FindLargestClass()
    {
        return Faculties
             .SelectMany(f => f.Classes)
        .OrderByDescending(c => c.Students.Count)
        .FirstOrDefault() ?? new ClassGroup("No Class Found");
    }

    public void Display()
    {
        Console.WriteLine($"University: {Name}");
        foreach (var f in Faculties)
            f.Display();
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter university name: ");
        string uniName = Console.ReadLine()!;
        University uni = new University(uniName);

        Console.Write("Enter number of faculties: ");
        int nFaculty = int.Parse(Console.ReadLine()!);

        for (int i = 0; i < nFaculty; i++)
        {
            Console.Write($"\nEnter name of faculty {i + 1}: ");
            string facultyName = Console.ReadLine()!;
            Faculty faculty = new Faculty(facultyName);

            Console.Write($"Enter number of classes in {facultyName}: ");
            int nClass = int.Parse(Console.ReadLine()!);

            for (int j = 0; j < nClass; j++)
            {
                Console.Write($"  Enter name of class {j + 1}: ");
                string className = Console.ReadLine()!;
                ClassGroup classGroup = new ClassGroup(className);

                Console.Write($"  Enter number of students in {className}: ");
                int nStudent = int.Parse(Console.ReadLine()!);

                for (int k = 0; k < nStudent; k++)
                {
                    Console.Write($"    Enter student {k + 1} name: ");
                    string sName = Console.ReadLine()!;
                    Console.Write($"    Enter student {k + 1} ID: ");
                    string sId = Console.ReadLine()!;
                    Console.Write($"    Enter student {k + 1} score: ");
                    double sScore = double.Parse(Console.ReadLine()!);

                    classGroup.AddStudent(new Student(sName, sId, sScore));
                }

                faculty.AddClass(classGroup);
            }

            uni.AddFaculty(faculty);
        }

        // Show all data
        uni.Display();

        // Search faculty
        Console.Write("\nEnter faculty name to search: ");
        string searchName = Console.ReadLine()!;
        var found = uni.SearchFaculty(searchName);
        if (found != null) found.Display();
        else Console.WriteLine("Faculty not found!");

        // Top students
        Console.WriteLine("\nTop students in university:");
        var topStudents = uni.FindTopStudents();
        if (topStudents.Count > 0)
            foreach (var s in topStudents)
                s.Display();
        else
            Console.WriteLine("No students in the university.");

        // Largest class
        Console.WriteLine("\nClass with most students:");
        var largestClass = uni.FindLargestClass();
        if (largestClass != null)
            largestClass.Display();
        else
            Console.WriteLine("No classes in the university.");
    }
}
