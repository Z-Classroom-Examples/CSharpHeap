using System;
using System.Net.Http.Headers;

namespace Heap
{
    class Program
    {
        static void Main(string[] args)
        {
            Heap heap = new Heap();

            heap.Insert(5);
            heap.Insert(45);
            heap.Insert(1);
            heap.Insert(90);
            heap.Display();

            int disp = heap.Remove();
            Console.WriteLine($"Removed:{disp}");
            
            heap.Display();

             disp = heap.Remove();
            Console.WriteLine($"Removed:{disp}");

            heap.Display();

            disp = heap.Remove();
            Console.WriteLine($"Removed:{disp}");

            heap.Display();

            disp = heap.Remove();
            Console.WriteLine($"Removed:{disp}");

            heap.Display();

            disp = heap.Remove();
            Console.WriteLine($"Removed:{disp}");

            heap.Display();

        }
    }
}
