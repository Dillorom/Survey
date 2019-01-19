using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passcode
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Please, enter a username: ");
            //var username = Console.ReadLine();

            //Console.WriteLine("Please, enter a passcode: ");sdf
            //var passcode = Console.ReadLine();
            //var passcodeLength = passcode.Length;


            //if (passcodeLength > 3 && passcodeLength<8)
            //{
            //    Console.WriteLine("You are authenticated: your username is {0}, your passcode is {1}", username, passcode);
            //}

            // using While loop

            //var code = "";


            //while (code != "secret")
            //{
            //    Console.WriteLine("What is the code?");
            //    code = Console.ReadLine();

            //    if (code != "secret")
            //    {
            //        Console.WriteLine("Not Authenticated");
            //    }
            //    Console.WriteLine("Authenticated");
            //}

            //using forLoop

            //var count = 1;
            //while(count<=10)
            //{
            //    Console.WriteLine(count);
            //    count++;
            //}
            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 1; j <= 10; j++)
            //    {
            //        Console.WriteLine(j);
            //    }
            //    for (int j = 10; j >= 0; j--)
            //        {
            //    Console.WriteLine(j);
            //        }
            //}

            //Arrays
            //var studentGrades = new int[5] { 80, 49, 29, 50, 60 };
            //foreach (var studentGrade in studentGrades)
            //{
            //    Console.WriteLine(studentGrade);
            //}

            Console.WriteLine("What is your name?");
            var name = TryAnswer();

            Console.WriteLine("What is your age?");
            var age = TryAnswer();

            Console.WriteLine("What is your birth month?");
            var birthMonth = TryAnswer();

            Console.ReadKey();

           
        }
        static string TryAnswer()
        {
            var answer = Console.ReadLine();
            if (answer == "")
            {
                Console.WriteLine("You did not type anything. Please, try again:");
                return Console.ReadLine();
            }
            return answer;
        }
    }
}
