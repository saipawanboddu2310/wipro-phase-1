using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> numberStack = new Stack<int>();

            // Push elements onto the stack
            numberStack.Push(10);
            numberStack.Push(20);
            numberStack.Push(30);
            numberStack.Push(40);

            // Print the elements in the stack
            Console.WriteLine("Elements in the stack:");
            foreach (int num in numberStack)
            {
                Console.WriteLine(num);
            }

            // Pop elements from the stack
            int poppedElement = numberStack.Pop();
            Console.WriteLine("Popped element: " + poppedElement);

            // Peek at the top element without removing it
            int topElement = numberStack.Peek();
            Console.WriteLine("Top element: " + topElement);

            // Print the updated stack
            Console.WriteLine("Remaining elements in the stack:");
            foreach (int num in numberStack)
            {
                Console.WriteLine(num);
            }

            Stack nongenricstack = new Stack();
            nongenricstack.Push("kiran");
            nongenricstack.Push(10);

            Console.ReadLine();
        }
    }
}
