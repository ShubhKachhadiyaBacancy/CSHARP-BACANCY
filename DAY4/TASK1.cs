using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY4
{
    public class TASK1
    {
        private static int sharedCounter = 0;
        private static readonly object lockObject = new object();
        private void  increamentCounter()
        {
            lock (lockObject)
            {
                Thread currThread = Thread.CurrentThread;
                Console.WriteLine($"Name of thread updating the variable is : " +
                    $"{currThread.Name}");
                sharedCounter++;
                Console.WriteLine($"Updated value : {sharedCounter}\n");
            }
        }

        public void executeThread()
        {
            Thread t1 = new Thread(increamentCounter);
            Thread t2 = new Thread(increamentCounter);
            Thread t3 = new Thread(increamentCounter);

            t1.Name = "THREAD-1";
            t2.Name = "THREAD-2";
            t3.Name = "THREAD-3";

            t1.Start();
            t2.Start();
            t3.Start();
        }
    }
}
