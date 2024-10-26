using System;
using System.Threading;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
         
        }

        static void Start()
        {
          int time = 10;
          int currentTime = 0;

          while(currentTime != time)
          {
            Console.Clear();
            currentTime++;
            Console.WriteLine(currentTime);
            Thread.Sleep(1000);
            Thread.Sleep(1000);
          }
        }
        static void Comecar()
        {

        }
        static void Stop()
        {
          
        }
        static void Restart()
        {
          
        }
    }
}