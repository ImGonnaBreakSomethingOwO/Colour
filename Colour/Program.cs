using System;

namespace Colour
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Coloured Text Example";//RUN THE PROGRAM AND SEE WHAT EFFECT THIS HAS ON THE PROGRAM WINDOW 
            string sName = "";

            Console.WriteLine("Enter your name:");
            sName = Console.ReadLine();

            //THE BACKGROUNDCOLOR AND FOREGROUND COLOR ARE SELF DOCUMENTING!
            //RUN THE PROGRAM AND CHECK THEM OUT
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Cyan;

            




            Console.WriteLine("You have entered: \"{0}\"", sName);//TRY THIS WITHOUT THE ESCAPE CHARACTERS
            Console.ResetColor();//SEE WHAT HAPPENS IF YOU DO NOT HAVE THIS LINE
            Console.WriteLine(" ----------------------------- ");
            //Console.BackgroundColor = ConsoleColor.Red;
            //Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Please press the enter key to continue");
            Console.ReadLine();
            
            //COMMENT OUT READLINE() AND REMOVE THE COMMENT CHARACTERS FOR READKEY()
            //SEE WHAT EFFECT THAT HAS AND CHANGE THE PROGRAM AS NECESSARY
            //Console.ReadKey();
        }

    }
}

