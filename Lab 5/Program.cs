using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    class Program
    {
        private static int userInput;
        private static int userInput2;

        static void Main(string[] args)
        {
            UserInteraction();
        }
   
        public static void UserInteraction()
        {
            Console.WriteLine("Enter in how many sides you would like your first die to have");
            userInput = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter in how many sides you would like your second die to have");
            userInput2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Lets roll the Dice! ");
      
            Random rnd = new Random();
            int die1 = rnd.Next(1, userInput);

            Console.WriteLine("Your first die chose: "+ die1);

            Console.WriteLine("Your second die chose: " +  Die2(userInput));
        }

        public static int Die2(int userInput2)
        {
            Random rnd = new Random();
            int die2 = rnd.Next(1, userInput2);
            return die2;
        }
      
    }
}
