using System;

namespace _01_numbers_strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables & constants
                // Console.WriteLine("What day of the week is your favorite? ");
                // var favoriteDay = Console.ReadLine();
                // Console.WriteLine($"\n I love { favoriteDay}'s too!");
                // Console.WriteLine($"{Environment.NewLine}Press any key to exit ...");
                // Console.ReadKey(true);

                // const string germanCar = "Jetta";
                // const string americanCar = "Ford F-150";
                // Console.WriteLine("Do you prefer German or American vehicles?");
                // string carPreference = Console.ReadLine().ToLower();
                // if(carPreference == "german")
                // {
                //     Console.WriteLine($"You might like the { germanCar}");
                // }
                // else if (carPreference == "american")
                // {
                //     Console.WriteLine($"You might like the { americanCar}");

                // }
                // else 
                // {
                //     Console.WriteLine("Your entry was invalid. Please press any key to exit");
                //     Console.ReadKey(true);
                // }

            //arithmetic expressions

                // int age;
                // string name;

                // Console.WriteLine("What is your name? ");
                // name = Console.ReadLine();

                // Console.WriteLine("What is your age? ");
                // age = Convert.ToInt32(Console.ReadLine());

                // if (age >= 15)
                // {
                //     Console.WriteLine($"{ name } you are old enough to obtain a driver's license in Idaho!");
                // }
                // else 
                // {
                //     Console.WriteLine($"{ name } you are not old enough to obtain a driver's license in Idaho");
                // }

            //ReadKey()
                // DateTime date = DateTime.Now;
                // Console.WriteLine("The time is {0:d} at {0:t}", date);

                // TimeZoneInfo timeZone = TimeZoneInfo.Local;
                // Console.Write("The timezone: {0} \n", timeZone.IsDaylightSavingTime(date) ? timeZone.DaylightName : timeZone.StandardName);

                // Console.WriteLine("Press <Enter> to exit ...");
                // while (Console.ReadKey().Key != ConsoleKey.Enter) 
                // {
                //     Console.WriteLine(Console.ReadKey().Key);
                // }

            //casting - Convert grade to letter grade
             
                // int grade1 = 0;
                // int grade2 = 0;
                // int grade3 = 0;
                // int avgGrade = 0;
                
                // Console.WriteLine("Enter your top your 1st grade: ");
                //     grade1 = Convert.ToInt32(Console.ReadLine());
                // Console.WriteLine("Enter your top your 2nd grade: ");
                //     grade2 = Convert.ToInt32(Console.ReadLine());
                // Console.WriteLine("Enter your top your 3rd grade: ");
                //     grade3 = Convert.ToInt32(Console.ReadLine());
                
                // avgGrade = (grade1 + grade2 + grade3) / 3;          

                // if (avgGrade >= 100) 
                // {
                //     Console.WriteLine("Your grade is A+");
                // }
                // else if (avgGrade >= 90)
                // {
                //     Console.WriteLine("Your grade is A");
                // }
                // else if (avgGrade >= 80)
                // {
                //     Console.WriteLine("Your grade is B");
                // }
                // else if (avgGrade >= 70)
                // {
                //     Console.WriteLine("Your grade is C");
                // }
                // else if (avgGrade >= 60)
                // {
                //     Console.WriteLine("Your grade is D");
                // }
                // else if (avgGrade <= 60)
                // {
                //     Console.WriteLine("Your grade is F");
                // }
             

            //Math class
                // double value = 0;
                // Int16 number1 = 0;
                //  Int32 number2 = 0;
                // // int64 number3 = 0;

                // Console.WriteLine("Enter a Int16");
                // number2 = Convert.ToInt32(Console.ReadLine());
                // number1 = (Int16)number2;
                // Console.WriteLine($"Abs({ number1 }) = {Math.Abs(number1)}" );

//https://www.w3resource.com/csharp-exercises/math/index.php
        //2. Write a  program to find the greater and smaller value of two variables.
            // int numb1 = 0;
            // int numb2 = 0;

            // Console.Write("Enter a number: ");
            // numb1 = Convert.ToInt32(Console.ReadLine());

            // Console.Write("Enter another number: ");
            // numb2 = Convert.ToInt32(Console.ReadLine());

            // if (numb1 < numb2)
            // {
            //     Console.Write($"{numb1} is less than {numb2}");
            // }
            // else if (numb1 > numb2)
            // {
            //     Console.Write($"{numb1} is larger than {numb2} \n");
            // }
            // else
            // {
            //     Console.Write($"{numb1} is equal to {numb2} \n");
            // }

        //3. Write a C# Sharp program to calculate the value that results from raising 3 to a power ranging from 0 to 32. 
            int number = 3;
            double answer = 0;
            for (int x = 0; x < 32; x++)
            {
                answer = Math.Pow(number, x);
                // Console.Write($"Math.Pow({number}, {x} = {answer} \n");
                Console.WriteLine($"{number}^{x} = (0x{(long)Math.Pow(number, x):X})");
            }

        //4. Write a C# Sharp program to calculate true mean value, mean with rounding away from zero and mean with rounding to nearest of some specified decimal values. 

        //5. Write a C# Sharp program to determine the sign of a single value and display it to the console.

        //6. Write a C# Sharp program to calculate the of each city's size in square from the given area of some cities in the United States.


            //Random class

            //Strings & special characters in strings

            //convert Data types

            //Methods to convert numbers to formatted strings

            //Enums

            //Nullable and Null-coalescing operators





            // Prompt user and write response
            // Console.WriteLine("What is your name? ");
            // var name = Console.ReadLine();
            // var currentDate = DateTime.Now;
            // Console.WriteLine($"{Environment.NewLine}Hello, {name}, on {currentDate:d} at {currentDate:t}!");
            // Console.WriteLine($"{Environment.NewLine}Press any key to exit...");
            // Console.ReadKey(true);
        }
    }
}
