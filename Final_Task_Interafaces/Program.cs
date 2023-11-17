using Final_Task_Interafaces;
using System;

namespace Final_Task_Interfaces
{
    class Program
    {
        static Ilogger Logger { get; set; }
        static void Main()
        {
            ISum sum = new Summ();
            Logger = new Logger();

            var worker1 = new Worker1(Logger);
            var worker2 = new Worker2(Logger);

            try
            {
                Console.WriteLine("Write first number");
                int a = int.Parse(Console.ReadLine());

                Console.WriteLine("Write second number");
                int b = int.Parse(Console.ReadLine());

                Console.WriteLine();
                worker2.Work();

                Console.WriteLine();
                sum.SumMethod(a, b);

                Console.WriteLine();
                worker1.Work();
            }
            catch
            {
                Console.WriteLine("You writed incorrect value!!!");

            }

            Console.ReadLine();
        }
    }

    public interface Ilogger
    {
        void Event(string message);

        void Error(string message);
    }
    public interface ISum
    {
        public void SumMethod(int a, int b);
    }

    public class Summ : ISum
    {
        void ISum.SumMethod(int a, int b)
        {
            int c = a + b;
            string str = c.ToString();
            Console.WriteLine("Result: " + str);
        }

    }

    public class Logger : Ilogger
    {
        void Ilogger.Error(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }

        void Ilogger.Event(string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
    public interface IWorker
    {
        void Work();
    }
}
