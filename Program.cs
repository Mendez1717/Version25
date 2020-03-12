using System;

namespace Version25
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print 1-10 numbers onto the console 
            int i;
            int start = 1;
            int end = 10;
            


            int stringnumber;
            Console.WriteLine("Hello, my name is Mikayla Anne Mendez and this is Version=25!");

            string characters;
            Console.Write("Enter any string of characters:  ");
            characters = Console.ReadLine();

            // Ask User to enter a value between two and five
            Console.WriteLine("Enter an number between 2 and 5:  ");
            stringnumber = Convert.ToInt32(Console.ReadLine());



            string single;
            // Ask User to enter a single character
            Console.Write("Enter a single character:  ");
            single = Console.ReadLine();


            if (stringnumber == 2)
            {
                for (i = start; i <= stringnumber; i++)
                {
                    Console.Write(characters);
                    Console.Write(single);

                }
            }
            else if (stringnumber == 3)
            {
                for (i = start; i <= stringnumber; i++)
                {
                    Console.Write(characters);
                    Console.Write(single);

                }

            }
            else if (stringnumber == 4)
            {
                for (i = start; i <= stringnumber; i++)
                {
                    Console.Write(characters);
                    Console.Write(single);

                }
            }
            else if (stringnumber == 5)
            {
                for (i = start; i <= stringnumber; i++)
                {
                    Console.Write(characters);
                    Console.Write(single);

                }
            }

           

        }

    }
}
