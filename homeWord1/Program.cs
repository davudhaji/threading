using System;
using System.Threading;

namespace homeWord1
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread1 = new Thread(new ThreadStart(dongu));
            Thread thread2 = new Thread(new ThreadStart(yazdir));
            thread1.Start();
            thread2.Start();

        }
        public static void dongu()
        {
            for(var i=0; i<10; i++)
            {
                Console.WriteLine(i);
            }
        }
        public static void yazdir()
        {
            Console.WriteLine("Salam");
            Console.WriteLine("necesen");
        }
    }
}
