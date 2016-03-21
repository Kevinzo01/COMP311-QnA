using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Multtreading
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a name thread using a thread delgate called Threadstart 
            MessagePrinter printer1 = new MessagePrinter();
            Thread thread1 = new Thread(new ThreadStart(printer1.Print));
            thread1.Name = "thread1";
            
            MessagePrinter printer2 = new MessagePrinter();
            Thread thread2 = new Thread(new ThreadStart(printer2.Print));
            thread2.Name ="thread2";

            MessagePrinter printer3 = new MessagePrinter();
            Thread thread3 = new Thread(new ThreadStart(printer3.Print));
            thread3.Name = "thread3";
            Console.WriteLine("Attention, threads are about to start.");
            
            //call start method to put the threads to their Running state 
            thread1.Start();
            thread2.Start();
            thread3.Start();
            Console.ReadKey();




        }

        class MessagePrinter
        {
            private int sleepTime;
            private static Random random = new Random();
            //constructor to inialize MessagePrinter 

            public MessagePrinter()
            {
                sleepTime = random.Next(5001);
            }

            //Print Method that would control the thread 
            public void Print()
            {
                //obtain a reference to the executing thread 
                Thread current = Thread.CurrentThread;

                //put thread to sleep for sleepTime amount of time
                Console.WriteLine("{0} is going to sleep for {1} milliseconds.", current.Name, sleepTime);
                // print threadName
                Console.WriteLine("{0} is waking up, it is done with sleeping", current.Name);
            }
        }
    }
}
