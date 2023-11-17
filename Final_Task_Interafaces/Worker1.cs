using Final_Task_Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Task_Interafaces
{
    public class Worker1 : IWorker
    {
        Ilogger Logger { get; }

        public Worker1(Ilogger logger)
        {
            Logger = logger;
        }

        public void Work()
        {
            Thread.Sleep(300);
            Logger.Event("The calculator finished working!");
            Thread.Sleep(700);
            Logger.Error("No errors found");
        }
    }
    public class Worker2 : IWorker
    {
        Ilogger Logger { get; }

        public Worker2(Ilogger logger)
        {
            Logger = logger;
        }

        public void Work()
        {
            Logger.Event("The calculator started working");
            Thread.Sleep(100);
            Logger.Event("0%");
            Thread.Sleep(300);
            Logger.Event("22%");
            Thread.Sleep(800);
            Logger.Event("51%");
            Thread.Sleep(600);
            Logger.Event("69%");
            Thread.Sleep(300);
            Logger.Event("87%");
            Thread.Sleep(2000);
            Logger.Event("93%");
            Thread.Sleep(700);
            Logger.Event("100%");
            Thread.Sleep(500);
        }
    }
}
