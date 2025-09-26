//Structs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter6_Othertechnologies
{
    struct Point
    {
        public int x, y;
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(4, 5);
            Console.WriteLine("p1=" + p1.x + ", " + p1.y);

            Point p2 = p1;
            p2.x = 40;
            p2.y = 50;
            Console.WriteLine("p1=" + p1.x + ", " + p1.y);//giá trị p1 không bị thay đổi
            Console.WriteLine("p2=" + p2.x + ", " + p2.y);

            Point p3;//không cần dùng từ khóa new   
            p3.x = 12;
            p3.y = 21;
            Console.WriteLine("p3=" + p3.x + ", " + p3.y);
        }
    }
}

//Interfaces
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_2
{
    interface IAnimal
    {
        void Eat();
    }
    interface IFlyingObject
    {
        void Fly();        
    }
    public class Bird:IAnimal, IFlyingObject
    {
        public void Eat()
        {
            Console.WriteLine("I'm eating");
        }
        public void Fly()
        {
            Console.WriteLine("I'm flying");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IAnimal iAn = new Bird();
            iAn.Eat();

            IFlyingObject iFl = new Bird();
            iFl.Fly();
        }
    }
}

Using interfaces (in .NET framework)
using System;

namespace ConsoleApp39
{
    class Program
    {
        static void Main(string[] args)
        {
            Car[] cars = new Car[]
               {
                    new Car()
                    {
                        Name = "Zinco"
                    }, new Car()
                    {
                        Name = "VW"
                    }, new Car()
                    {
                        Name = "BMW"
                    }
               };
            Array.Sort(cars);
            Array.ForEach(cars, x => Console.WriteLine(x.Name));
        }
    }

    public class Car : IComparable
    {
        public string Name
        {
            get;
            set;
        }
        public int MaxSpeed
        {
            get;
            set;
        }
        public int CompareTo(object obj)
        {
            if (!(obj is Car))
            {
                throw new ArgumentException("Compared Object is not of car");
            }
            Car car = obj as Car;
            return Name.CompareTo(car.Name);
        }
    }
}


//Generic
Allow us write data structures/classess which can be applied for different data types.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Demo
{
    class MyStack<T>
    {
        private T[] a=new T[10];//mang a
        private int top=-1;
        public void Push(T x)
        {
            this.a[top+1] = x;
            this.top++;
        }
        public T Top()
        {
            return this.a[this.top];
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyStack<int> mySt = new MyStack<int>();
            mySt.Push(3);
            mySt.Push(4);
            mySt.Push(5);
            Console.WriteLine(mySt.Top());

            MyStack<string> mySt1 = new MyStack<string>();
            mySt1.Push("Binh");
            mySt1.Push("Hung");
            mySt1.Push("Nam");
            Console.WriteLine(mySt1.Top());
        }
    }
}
