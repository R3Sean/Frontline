using System;
using System.Linq;

namespace Frontline
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            /*
             * SOLUTION NUMBER ONE
             */
			Console.WriteLine("This is the results of the Firstline Problem 1 solution:");
			Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Parse the string:");
			Console.WriteLine("(id,created,employee(id,firstname,employeeType(id), lastname),location)");
			Console.WriteLine("---------------------------------------------------------");
			Console.WriteLine("Version One:");
            Console.WriteLine("---------------------------------------------------------");

            ProblemOne obj1 = new ProblemOne();
            //this value is set in the constructor but could be dynamic for an instance of the object
            obj1.InputString = "(id,created,employee(id,firstname,employeeType(id), lastname),location)";

            //this will set the output collection from the input string based on 
            obj1.GetOutputCollection(false);

            foreach (var n in obj1.OutputCollection)
            {
                Console.WriteLine(n);
            }
            /*
             * BONUS OUTPUT SOLUTION NUMBER ONE
             */
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Bonus: Output in alphabetical order:");
			Console.WriteLine("---------------------------------------------------------");
			
            Console.WriteLine();


            obj1.GetOutputCollection(true);
			foreach (var n in obj1.OutputCollection)
			{
				Console.WriteLine(n);
			}

            Console.WriteLine();
            Console.WriteLine();
			Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine();

            /*
             * SOLUTION NUMBER TWO
             */
			Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("This is the output of Firstline Problem 2 solution:");
			Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Challenge: Reverse each word of a string but maintain the positioning of capitalization, punctuation, and special characters.");
            Console.WriteLine("Input String: My name is Albert McDonald.");
            Console.WriteLine("---------------------------------------------------------");

			ProblemTwo obj2 = new ProblemTwo();
			obj2.InputString = "My name is Albert McDonald.";
			obj2.ProcessPhrase();
			Console.WriteLine(obj2.OutputString);
			Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine();

            /*
             * SOLUTION NUMBER TWO OTHER EXAMPLES
             */
            Console.WriteLine("Other Examples of solution:");
			Console.WriteLine("Input String: My name is Albert$ Mc'Donald.");
			Console.WriteLine("---------------------------------------------------------");
            obj2.InputString = "My name is Albert$ Mc'Donald.";
            obj2.ProcessPhrase();
            Console.WriteLine(obj2.OutputString);

            Console.WriteLine();
			Console.WriteLine("---------------------------------------------------------");
			Console.WriteLine("Input String: !My %$a... is () AlBert .Mc'DonalD.");
			Console.WriteLine("---------------------------------------------------------");
			obj2.InputString = "!My %$a... is () AlBert .Mc'DonalD.";
            obj2.ProcessPhrase();
            Console.WriteLine(obj2.OutputString);

			Console.WriteLine();
			Console.WriteLine("---------------------------------------------------------");
			Console.WriteLine("Input String: !My Na..m.E is (9) $AlBer6t .Mc'DonalD?");
			Console.WriteLine("---------------------------------------------------------");

			obj2.InputString = "!My Na..m.E is (9) $AlBer6t .Mc'DonalD?";
			obj2.ProcessPhrase();
			Console.WriteLine(obj2.OutputString);
            Console.WriteLine();
			Console.WriteLine("-----------------------END-------------------------------");
            Console.WriteLine("---Please scroll up to view output from both solutions---");

			Console.ReadKey();
            Console.ReadLine();

        }
    }
}
