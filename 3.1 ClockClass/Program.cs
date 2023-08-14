using System;
namespace ClockClass
{
    public class MainClass
    {
        static void Main(string[] args)
        {
            Clock clock = new Clock();
            for (int i = 0; i < 14400; i++)
            {
                clock.Ticks();
                Console.WriteLine(clock.GetTime());

            }

        }
        Clock clock = new Clock();


    }
}