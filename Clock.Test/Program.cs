using System;

namespace Clock.Test
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var clock = new CountdownClock(5000, "Hello", "xyz");

            clock.Start();
            
            clock.Elapsed += (sender, eventArgs) =>
            {
                Console.WriteLine(eventArgs.Message);
                if (eventArgs.AdditionalInfo != null)
                {
                    Console.WriteLine(eventArgs.AdditionalInfo);
                }
            };

            Console.ReadKey();
        }
    }
}
