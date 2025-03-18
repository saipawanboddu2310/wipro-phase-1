using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using ReflectionDemo;
using System.IO;

namespace ReflectionDemo
{
    public abstract class Song
    {
        public void ResumeSong()
        {
            Console.WriteLine("Song Playing..");
        }
        abstract public Song PlaySong { get; set; }
        abstract public bool StopSong { get; set; }
        abstract public bool RemoveSong { get; set; }
        abstract public int SongCount { get; set; }
    }
    class A
    {

    }
    class B : A
    {

    }
    class MyClass
    {
        int x;
        int y;
        public MyClass()
        {

        }
        public MyClass(int i, int j)
        {
            x = i;
            y = j;
        }

        public MyClass(MyClass c)
        {
            this.x = c.x;
            this.y = c.y;
        }

        public int sum()
        {
            return x + y;
        }

        public bool isBetween(int i)
        {
            if (x < i && i < y) return true;
            else return false;
        }

        public void set(int a, int b)
        {
            x = a;
            y = b;
        }

        public void set(double a, double b)
        {
            x = (int)a;
            y = (int)b;
        }

        public void show()
        {
            Console.WriteLine(" x: {0}, y: {1}", x, y);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            B b = new B();
            if (a is A)
            {
                Console.WriteLine("a is the object of A class ");
            }
            if (b is A)
            {
                Console.WriteLine("b is in A becasue derived from A");
            }
            // suppose i want to types of .net framework assembllies
            Type t = typeof(StreamWriter);
            Console.WriteLine($"{t.FullName}");
            Type t2 = typeof(Song);
            if (t2.IsClass)
            {
                Console.WriteLine("yes it is a class");
            }
            if (t2.IsAbstract)
            {
                Console.WriteLine("yes it is abstract");
            }
            else
            {
                Console.WriteLine("it is concnrete class");
            }

            Type tt = typeof(MyClass);
            Console.WriteLine($"checking methods in {tt.Name} class");
            Console.WriteLine("Methods involved....");
            Console.WriteLine("---------------------");
            MethodInfo[] mi = tt.GetMethods();
            foreach (MethodInfo m in mi)
            {
                Console.Write($"{m.ReturnType.Name}  {m.Name}(\n");
            }
            Type tt1 = typeof(MyClass);
            Console.WriteLine($"checking methods in {tt1.Name} class");
            Console.WriteLine("Methods involved....");
            Console.WriteLine("---------------------");
            MethodInfo[] mi1 = tt.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.DeclaredOnly);
            foreach (MethodInfo m in mi1)
            {
                Console.Write($"{m.ReturnType.Name}  {m.Name}(");
                ParameterInfo[] pi = m.GetParameters();
                for (int i = 0; i < pi.Length; i++)
                {
                    Console.Write($"{pi[i].ParameterType.Name} {pi[i].Name}");
                    if (i + 1 < pi.Length)
                    {
                        Console.Write(",");
                    }


                }
                Console.WriteLine(")");
                Console.WriteLine();
            }


            Console.ReadLine();

        }
    }
}

