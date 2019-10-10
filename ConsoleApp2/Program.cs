using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string nimi;
            Console.WriteLine("Tere, mis on sinu nimi? ");
            nimi = Console.ReadLine();
            Console.WriteLine("Tere {0} !", nimi);
            
            Start:
            int randomNumber;
            Random rnd = new Random();
            randomNumber = rnd.Next(1, 4);
            string userChoise;
            Console.WriteLine("Mille sa valid? Kas paber, kivi või käärid? ");
            userChoise = Console.ReadLine();

           


            //1 - paber, 2 - kivi, 3 - käärid
            if (randomNumber == 1 && userChoise == "paber")
            {
                Console.WriteLine("Arvuti valis ka paberi");
                string message = "Teie jäite viiki";
                Console.WriteLine(message);
                Console.WriteLine(" ");
                

            }

            else if (randomNumber == 1 && userChoise == "kivi")
            {
                Console.WriteLine("Arvuti valis paberi");
                string message = "Kahjuks sina kaotasid";
                Console.WriteLine(message);
                Console.WriteLine(" ");
            }

            else if (randomNumber == 1 && userChoise == "käärid")
            {
                Console.WriteLine("Arvuti valis paberi");
                string message = "Sina võitsid";
                Console.WriteLine(message);
                Console.WriteLine(" ");
            }

            //1 - paber, 2 - kivi, 3 - käärid
            else if (randomNumber == 2 && userChoise == "paber")
            {
                Console.WriteLine("Arvuti valis kivi");
                string message = "Sina võitsid";
                Console.WriteLine(message);
                Console.WriteLine(" ");
            }

            else if (randomNumber == 2 && userChoise == "kivi")
            {
                Console.WriteLine("Arvuti valis ka kivi");
                string message = "Teie jäite viiki";
                Console.WriteLine(message);
                Console.WriteLine(" ");
            }

            else if (randomNumber == 2 && userChoise == "käärid")
            {
                Console.WriteLine("Arvuti valis kivi");
                string message = "Sina kaotasid";
                Console.WriteLine(message);
                Console.WriteLine(" ");
            }

            //1 - paber, 2 - kivi, 3 - käärid
            else if (randomNumber == 3 && userChoise == "paber")
            {
                Console.WriteLine("Arvuti valis käärid");
                string message = "Kahuks sina kaotasid";
                Console.WriteLine(message);
                Console.WriteLine(" ");
            }
            
            else if (randomNumber == 3 && userChoise == "kivi")
            {
                Console.WriteLine("Arvuti valis käärid");
                string message = "Sina võitsid";
                Console.WriteLine(message);
                Console.WriteLine(" ");
            }

            else if (randomNumber == 3 && userChoise == "käärid")
            {
                Console.WriteLine("Arvuti valis ka käärid");
                string message = "Teie jäite viiki";
                Console.WriteLine(message);
                Console.WriteLine(" ");
            }

            goto Start;

            Console.ReadLine();




        }
    }
}
