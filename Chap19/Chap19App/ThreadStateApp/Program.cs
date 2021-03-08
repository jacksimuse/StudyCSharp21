using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadStateApp
{
    class Program
    {
        static void PrintState(ThreadState state)
        {
            Console.WriteLine($"{state,-16} : {(int)state}");
        }
        static void Main(string[] args)
        {
            PrintState(ThreadState.Running);

            
            PrintState(ThreadState.StopRequested);
            PrintState(ThreadState.Suspended);
            PrintState(ThreadState.Stopped);
            PrintState(ThreadState.Unstarted);
            PrintState(ThreadState.WaitSleepJoin);
            PrintState(ThreadState.AbortRequested);
            PrintState(ThreadState.Aborted);
        }
    }
}
