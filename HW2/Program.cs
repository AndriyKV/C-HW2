using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2
{
    struct Dog
    {
        public string name;
        public string mark;
        public int age;

        public override String ToString()
        {
            return "Name: " + name + "\nAge: " + age + "\nMark: " + mark;
        }
    }
    class Program
    {
        public enum errorHttp
        {
            Bad_Request = 400,
            Unauthorized,
            Payment_Required,
            Forbidden,
            Not_Found,
            Method_Not_Allowed,
            Not_Acceptable,
            Proxy_Authentication_Requ,
            Request_Timeout,
            Conflict,
            Gone,
            Length_Required,
            Precondition_Failed,
            Payload_Too_Large,
            Request_URI_Too_Long,
            Unsupported_Media_Type,
            Requested_Range_Not_Satis,
            Expectation_Failed,
            I_am_a_teapot,
            Misdirected_Request = 421,
            Unprocessable_Entity,
            Locked,
            Failed_Dependency = 424,
            Upgrade_Required = 426,
            Precondition_Required = 428,
            Too_Many_Requests,
            Request_Header_Fields_Too = 431,
            Connection_Closed_Without = 444,
            Unavailable_For_Legal_Rea = 451,
            Client_Closed_Request = 499
        }
        static void Main(string[] args)
        {
            ////HW2 TASK "A"_____________________________________________________________________________________________

            //Console.WriteLine("Please, enter 3 float numbers.");
            //string chA = Console.ReadLine();
            //Console.WriteLine("Enter second number.");
            //string chB = Console.ReadLine();
            //Console.WriteLine("And finally last.");
            //string chC = Console.ReadLine();
            //bool checkA = float.TryParse(chA, out float A);
            //bool checkB = float.TryParse(chB, out float B);
            //bool checkC = float.TryParse(chC, out float C);
            //if (checkA && checkB && checkC == true)
            //{
            //    string resultA = (A >= -5 && A <= 5) ? "The first number belongs to the range from -5 to 5." :
            //        "The first number doesn't belong to the range from -5 to 5.";
            //    string resultB = (B >= -5 && B <= 5) ? "The second number belongs to the range from -5 to 5." :
            //        "The second number doesn't belong to the range from -5 to 5.";
            //    string resultC = (C >= -5 && C <= 5) ? "The third number belongs to the range from -5 to 5." :
            //        "The third number doesn't belong to the range from -5 to 5.";
            //    Console.WriteLine($"{resultA}\n{resultB}\n{resultC}");
            //}
            //else
            //    Console.WriteLine("One of the entered numbers is incorrect (not float value). " +
            //        "Check please and try again.");

            //Console.WriteLine("\nPress any button to exit.");
            //Console.ReadKey();

            //// HW2 TASK "B"_____________________________________________________________________________________________
            //// за допомогою IF без макс та мін
            //Console.WriteLine("Please enter three integers.");
            //string chA = Console.ReadLine();
            //Console.WriteLine("Enter second number.");
            //string chB = Console.ReadLine();
            //Console.WriteLine("And finally last.");
            //string chC = Console.ReadLine();
            //bool checkA = Int32.TryParse(chA, out int A);
            //bool checkB = Int32.TryParse(chB, out int B);
            //bool checkC = Int32.TryParse(chC, out int C);
            //int[] num = { A, B, C };
            //if (checkA && checkB && checkC == true)
            //    Console.WriteLine("Min integer = " + num.Min() + "\nMax integer = " + num.Max());
            //else
            //    Console.WriteLine("\nYou have entered not integer value. Check please and try again.");

            //Console.WriteLine("\nPress any button to exit.");
            //Console.ReadKey();

            //// HW2 TASK "C"_____________________________________________________________________________________________

            ////errorHttp input = (errorHttp)(chInput);

            //Console.WriteLine("Please enter code of HTTP Error (e.g. 401).");
            //string chInput = Console.ReadLine();
            //int input;
            //bool checkInput = int.TryParse(chInput, out input);

            //if (checkInput == true)
            //{
            //    if (Enum.IsDefined(typeof(errorHttp), input))
            //    {
            //        int[] enumValues = new int[] { input };
            //        foreach (int enumValue in enumValues)
            //        {
            //            Console.WriteLine("\nName of error: " + Enum.GetName(typeof(errorHttp), enumValue));
            //        }
            //    }
            //    else
            //        Console.WriteLine("There is no such error code in the list.");
            //}
            //else
            //    Console.WriteLine("\nYou have entered not integer value. Check please and try again.");

            //Console.WriteLine("\nPress any button for exit.");
            //Console.ReadKey();

            //// HW2 TASK "D"_____________________________________________________________________________________________

            //Dog myDog;
            //Console.WriteLine("Please enter the dog's name:");
            //myDog.name = Console.ReadLine();
            //Console.WriteLine($"What's the {myDog.name} mark?");
            //myDog.mark = Console.ReadLine();
            //Console.WriteLine($"How old is {myDog.name}?");
            //myDog.age = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("\nInformation about your dog:\n" + myDog);

            //Console.WriteLine("\nPress any button to exit.");
            //Console.ReadKey();
        }
    }
}
