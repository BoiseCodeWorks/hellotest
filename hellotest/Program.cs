using System;

namespace hellotest
{
    class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();
            int answer = random.Next(1, 100);
            var guesses = 0;
            Console.WriteLine("Try guesing my number");

            bool playing = true;
            while (playing)
            {
                guesses++;
                var guess = Console.ReadLine();


                int.TryParse(guess, out int x);

                if (x == answer)
                {
                    Console.WriteLine("GREAT GUESS");
                    playing = false;
                    break;
                }

                if (x > answer)
                {
                    Console.WriteLine("LOWER");
                    continue;
                }

                if (x < answer)
                {
                    Console.WriteLine("HIGHER");
                }

            }

            Console.WriteLine("Bye Felicia");

        }
    }

}
