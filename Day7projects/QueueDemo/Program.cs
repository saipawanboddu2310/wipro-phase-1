using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> stringQueue = new Queue<string>();

            // Enqueue elements into the queue
            stringQueue.Enqueue("Alice");
            stringQueue.Enqueue("Bob");
            stringQueue.Enqueue("Charlie");
            stringQueue.Enqueue("David");

            // Print the elements in the queue
            Console.WriteLine("Elements in the queue:");
            foreach (string name in stringQueue)
            {
                Console.WriteLine(name);
            }

            // Dequeue elements from the queue
            string dequeuedElement = stringQueue.Dequeue();
            Console.WriteLine("Dequeued element: " + dequeuedElement);

            // Peek at the front element without removing it
            string frontElement = stringQueue.Peek();
            Console.WriteLine("Front element: " + frontElement);

            // Print the updated queue
            Console.WriteLine("Remaining elements in the queue:");
            foreach (string name in stringQueue)
            {
                Console.WriteLine(name);
            }
            Queue nongenericqueue = new Queue();
            nongenericqueue.Enqueue("kkkk");
            nongenericqueue.Enqueue(23);
            nongenericqueue.Enqueue(DateTime.Now);
            Console.ReadLine();
        }
    }
}
