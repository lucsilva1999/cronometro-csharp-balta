using System;
using System.Threading;

namespace Cronometro
{
    class Program
    {
        static void Main(string[] args)
        {
            Start();
        }

        static void Start()

        {
            int time = 10;
            int currentTime = 0;

            while (currentTime != time)
            {
                Limpar();
                currentTime++;
                Console.WriteLine(currentTime);
                Sleep();
                
            }
        }   

        static void Limpar() {

            Console.Clear();

        }

        static void Sleep(){

            Thread.Sleep(1000);
        }
    }
}
