using System;
using System.ComponentModel;
using System.Drawing;
using System.Xml.Linq;

namespace Route_Session_03
{
    internal class Program
    {
        static void Main(string[] args)
        {






            #region Value Type Casting
            #region Implicit Castign (Safe Casting)
            //// كبيره type صغيره الي  type عادي احط من 

            //int x = 10;
            //long y = x; // Valid 
            //Console.WriteLine(y);
            //Console.WriteLine(x);


            #endregion

            #region Explicit Casting ( Unsafe Casting )
            //long x = 55555555555555555;
            //int y;
            //checked
            //{
            //      y = (int)x;
            //}

            ////صغير  type كبير الي  type  مينفعش اخد نسخه من 
            //Console.WriteLine(x); // 55555555555555555
            //Console.WriteLine(y); // Rawend Number 

            //double x = 10.2; // 10.2
            //int y = (int)x; // 10

            #endregion

            #region Parse ( Convert From  String any Datatype )
            //Console.WriteLine("Please Enter Your Name ");
            //string Name = Console.ReadLine();

            //Console.WriteLine("Please Enter Your Age ");
            //int Age = int.Parse(Console.ReadLine());

            //Console.WriteLine("Please Enter Your Salary  ");
            //double Salary = double.Parse(Console.ReadLine());

            //Console.Clear();

            //Console.WriteLine("your Name " + Name);
            //Console.WriteLine("your Age " + Age);
            //Console.WriteLine("your Salary " + Salary);


            #endregion

            #region Convert (Convert From AnyDatatype To  AnyDataType)

            //Console.WriteLine("Please Enter Your Name ");
            //string Name = Console.ReadLine();

            //Console.WriteLine("Please Enter Your Age ");
            //int Age = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Please Enter Your Salary  ");
            //double Salary = Convert.ToDouble(Console.ReadLine());

            //Console.Clear();

            //Console.WriteLine("your Name " + Name);
            //Console.WriteLine("your Age " + Age);
            //Console.WriteLine("your Salary " + Salary);


            #endregion
            #endregion

            #region Operators 
            #region Unary Operators  [++ , -- ]
            // Unary Operatos =>  Works on one Operand  (Varible)

            //int x = 10;
            //// PreFix (increment And Then Print)
            //    Console.WriteLine(++x);

            //int y = 10;
            ////Postfix(Then print And Increment)
            //Console.WriteLine(++y); //10
            //Console.WriteLine(y); // 11


            //int x = 10;
            //// PreFix (Decrement And Then Print)
            //Console.WriteLine(++x);

            //int y = 10;
            ////Postfix(Then print And Decrement)
            //Console.WriteLine(++y); //10
            //Console.WriteLine(y); // 11

            #endregion

            #region Binary Operator [+ , - , / , * , %]
            // Binary Operatos =>  Works on 2 Operand  (Varible)

            //int Sum, Mul, Div, Sub, Mod;

            //int Num1 = 5 , Num2 = 10 ;

            //Sum = Num1 + Num2 ;
            //Mul = Num1 - Num2 ; 
            //Div = Num1 / Num2 ; 
            //Sub = Num1 * Num2 ; 
            //Mod = Num1 % Num2 ;

            #endregion

            #region Assignment Operator [+ , = , - , / , % , *]
            //int x = 5;
            //x = 9;
            //x += 5; // 14
            //x -= 5; // 9
            //x /= 5;
            //x %= 5;
            //x *= 5;

            #endregion

            #region Relational Operator [== , != , > , < , <= , >= , ]
            //int x = 9 , y = 10;

            //Console.WriteLine(x == y); // False
            //Console.WriteLine(x != y); // True
            //Console.WriteLine(x > y); // True
            //Console.WriteLine(x < y); // False
            //Console.WriteLine(x <= y); // False
            //Console.WriteLine(x >= y); // true






            #endregion

            #region Logical Operator (Short Circuit) [ !  , && , || ]

            // Console.WriteLine(true || false); // true
            // Console.WriteLine(true && false); // false
            // Console.WriteLine(!false); // True

            //Console.WriteLine(4 < 5 && 5 > 8); // false
            // Console.WriteLine(4 < 5 || 5 > 8); // true




            #endregion

            #region Bitwise Operator (logn Circuit) [ | , & , ^ , >> , << ]


            //Console.WriteLine(true | false); // true
            //Console.WriteLine(true & false); // false
            //Console.WriteLine(!false); // True

            //Console.WriteLine(4 < 5 & 5 > 8); // false
            //Console.WriteLine(4 < 5 | 5 > 8); // true

            #endregion

            #region Ternary Operator (conditional Operator = , ? , : )
            //String Massge = 4 > 5 ? "Num1 is Greater Then Num2" : "Num1 is Leas  then num2 ";

            #endregion
            #endregion

            #region Operators Priority

            /*
             1. Unary Operator (perFix)
             2. Round Breaces ()
             3. * / %
             4. + - 
             
             */

            //int a = 20;
            //int b = 10;
            //int c = 30;
            //int d = 40;
            //int e = 50;
            //int Result;

            //Result =  (a + b) * c / d + e;
            //Result = ((a + b) * c );
            //Result = ((a + b) * d + e) * e;

            //Console.WriteLine(Result);


            #endregion

            #region String Formatting
            // Equation : 5 + 6 = 10
            //int x = 5;
            //int y = 6;

            //string Massge = "Equation : " + x + " + " + y + "=" + (x + y);  // invalid ❌❌
            //  string is immutable type => can not be  changed After creation


            // 1. composit Formating  C# 5
            //Massge = string.Format("Equation : {0} + {1} + {2} " , x, y , x + y);
            //Console.WriteLine("Equation : {0} + {1} + {2} ", x, y, x + y);


            //// 2. string interPolation C# 7
            //// $ -> String Manipulation
            //Massge = $"Equation : {y} + {x} = {x+y}";
            //Console.WriteLine(Massge);

            //// 3. Console Dairact
            //Console.WriteLine($"Equation : {y} + {x} = {x + y:c}");

            #endregion

            #region Conditional Statments

            #region Conditional Statments [ IF , Switch ]

            #region Ex01
            #region IF 
            //Console.WriteLine("Please Entar a Month Number Exited at first Quarter");

            //int MonthNumber = int.Parse(Console.ReadLine());

            //if (MonthNumber == 1 )
            //{
            //    Console.WriteLine("January");
            //}
            //else if (MonthNumber == 2)
            //{
            //    Console.WriteLine("Februre");
            //}
            //else if (MonthNumber == 3)
            //{
            //    Console.WriteLine("Marth");
            //}
            //else
            //{
            //    Console.WriteLine("Ahmed Basha el bald");
            //}
            #endregion

            // Switch jump Table
            #region Switch
            //Console.WriteLine("Please Entar a Month Number Exited at first Quarter");

            //int MonthNumber = int.Parse(Console.ReadLine());

            //switch (MonthNumber)
            //{
            //    case 1:
            //        Console.WriteLine("Januar");
            //        break;

            //    case 2:
            //        Console.WriteLine("Februare");
            //        break;

            //    case 3:
            //        Console.WriteLine("Marth");
            //        break;

            //    default:
            //        Console.WriteLine("Abdelrahman Basha El bald");
            //        break;


            //}

            #endregion
            #endregion

            #region Ex02
            //Console.WriteLine("Plesa Enter Name");

            //string Name = Console.ReadLine();

            // if (Name == "Ahmed")
            // {
            //     Console.WriteLine("Hello Ahmed");
            // }

            //else if (Name == "Mostafa")
            // {
            //     Console.WriteLine("Hello Mostafa");
            // }


            //switch (Name) {

            //    case "Ahmed":
            //        Console.WriteLine("Hello Ahmed");
            // break;

            //    case "Mohamed":
            //        Console.WriteLine("Hello Mohamed");
            //        break;

            //        default:
            //        Console.WriteLine("Ahmed MOhamed");
            //        break;

            //}

            #endregion

            #region EX03 Go to
            // بتمنع تكرار الكود
            //Console.WriteLine("Please Enter Your Budget");
            //int Budget = int.Parse(Console.ReadLine());

            //switch (Budget)
            //{
            //    case 3:
            //        Console.WriteLine("Hello 3"); 
            //        goto case 2;
            //            case 2:
            //        Console.WriteLine("Hello 2");
            //        goto case 1;
            //            case 1:
            //        Console.WriteLine("Hello 1"); break ;








            #endregion

            #endregion

            #endregion


            #region Evolution of Switch in C#
            #region Ex01 [SWitch In C# 6.0]

        Console.Write("Enter Enetr Your Age : ");
    int Age = int.Parse(Console.ReadLine());
switch(Age)
    {
        case > 22:
            Console.WriteLine("Yuo Age is Greater Than 22");
            break;

        case < 22:
            Console.WriteLine("Yuo Age is Less Then 22");
            break;

        default: Console.WriteLine("Your Age is 22");
            break;

    }

            #endregion

                

 #region Ex02 [SWitch In C# 7.0]

object input = new object();

input = 10.25;
input = "ahmed";
input = 5;


switch (input)
{
    case int Number when Number > 5 && Number < 100:
        Console.WriteLine($"input is int and Equal = {Number}");
        break;

    case double Number:
        Console.WriteLine($"input is int and Equal = {Number}");
        break;

    case string:
        Console.WriteLine($"input is int and Equal = {Name}");
        break;
}
#endregion

    #region Ex02 [SWitch In C# 8.0]
#region Ex 01
// بعد التحديث SWitch طريقه ال 

//Console.WriteLine("Please Entr Number");
//int option = int.Parse(Console.ReadLine());

//String Massge = option switch
//{
//    1 => "option 1",
//    2 => "option 2",
//    3 => " option 3",
//    _ => "suported option"
//};
#endregion
    
    #region Ex 02
      Emploeyy emploeyee01 = new Emploeyy();
  emploeyee01.Id =  1;
  emploeyee01.Name = "Ahmed";
  emploeyee01.Age = 21;


  String Massage = emploeyee01 switch
  {
      { Id: 1 } => "Hello mona  your id is 1",
      { Id: 2 } => "Hello mona  your id is 1",

      _ => "invalid Embloyee"
  } ;

  Console.WriteLine(Massage);
    #endregion

#endregion


 #region Ex02 [SWitch In C# 9.0]
Emploeyy emploeyee01 = new Emploeyy();
emploeyee01.Id =  1;
emploeyee01.Name = "Ahmed";
emploeyee01.Age = 21;


String Massage = emploeyee01 switch
{
    { Age: <=40 } => $"Hello {emploeyee01.Name}  your id is 40",
    { Age: >=80 and <= 40 } => $"Hello {emploeyee01.Name}  your id is 80",
    { Age: 80 or 50 } => $"  your Age is 45 or 80",


    _ => "invalid Embloyee"
} ;

Console.WriteLine(Massage);
#endregion
            #endregion




            //========================================= Assignment Session 03 ========================================= //

            #region Assignment Session 03
            #region 1- Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.

            //Console.WriteLine("Pelase Entar Number");
            //int Number = int.Parse(Console.ReadLine());
            //if (Number % 3 == 0 && Number % 4 == 0)
            //{
            //    Console.WriteLine("yes");
            //}

            //else
            //{
            //    Console.WriteLine("no");
            //}
            #endregion


            #region 2- Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive.
            //Console.WriteLine("Pelase Entar Number");
            //int Number = int.Parse(Console.ReadLine());

            //if (Number < 0 )
            //{
            //    Console.WriteLine("negative");
            //}

            //else
            //{
            //    Console.WriteLine("positive");
            //}
            #endregion


            #region 3 - Write a program that takes 3 integers from the user then prints the max element and the min elemen
            //Console.WriteLine("Pelase Entar Number");
            //int Number = int.Parse(Console.ReadLine());

            //      // Take 3 integers from the user
            //Console.Write("Enter the first integer: ");
            //int num1 = int.Parse(Console.ReadLine());

            //Console.Write("Enter the second integer: ");
            //int num2 = int.Parse(Console.ReadLine());

            //Console.Write("Enter the third integer: ");
            //int num3 = int.Parse(Console.ReadLine());

            //// Find the maximum and minimum values
            //int maxValue = Math.Max(Math.Max(num1, num2), num3);
            //int minValue = Math.Min(Math.Min(num1, num2), num3);

            //// Print the results
            //Console.WriteLine($"The maximum value is: {maxValue}");
            //Console.WriteLine($"The minimum value is: {minValue}");
            #endregion


            #region 4- Write a program that allows the user to insert an integer number then check If a number is even or odd.
            // Take input from the user
            //Console.Write("Enter an integer: ");
            //int number = int.Parse(Console.ReadLine());

            //// Check if the number is even or odd
            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("The number is even.");
            //}
            //else
            //{
            //    Console.WriteLine("The number is odd.");
            //}
            #endregion

            #region 5- Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant).
            //// Take a character input from the user
            //Console.Write("Enter a character: ");
            //char inputChar = Char.ToLower(Console.ReadLine()[0]);  // Convert to lowercase for uniformity

            //// Check if the character is a vowel or consonant
            //if (inputChar == 'a' || inputChar == 'e' || inputChar == 'i' || inputChar == 'o' || inputChar == 'u')
            //{
            //    Console.WriteLine("vowel");
            //}
            //else
            //{
            //    Console.WriteLine("consonant");
            //}
            #endregion

            #region 7 - Write a program that allows the user to insert an integer thenprint a multiplication table up to 12.

                        //// Take an integer input from the user
                        //Console.Write("Enter an integer: ");
                        //int number = int.Parse(Console.ReadLine());

                        //// Print the multiplication table for the given number up to 12
                        //Console.WriteLine($"Multiplication table for {number}:");
                        //for (int i = 1; i <= 12; i++)
                        //{
                        //    Console.WriteLine($"{number} x {i} = {number * i}");
                        //}
            #endregion

                #region Problem 9 - Power Calculation
                //Console.WriteLine("Problem 9: Power Calculation");
                //Console.Write("Enter two integers: ");
                //int baseNumber = Convert.ToInt32(Console.ReadLine());
                //int exponent = Convert.ToInt32(Console.ReadLine());

                //int result = (int)Math.Pow(baseNumber, exponent);
                //Console.WriteLine("Result: " + result);
                //Console.WriteLine();
                #endregion

                #region Problem 10 - Marks Calculation
                //Console.WriteLine("Problem 10: Marks Calculation");
                //Console.WriteLine("Enter Marks of five subjects: ");
                //int[] marks = new int[5];
                //for (int i = 0; i < 5; i++)
                //{
                //    marks[i] = Convert.ToInt32(Console.ReadLine());
                //}

                //int total = 0;
                //foreach (int mark in marks)
                //{
                //    total += mark;
                //}

                //double average = total / 5.0;
                //double percentage = (total / 500.0) * 100;

                //Console.WriteLine("Total marks = " + total);
                //Console.WriteLine("Average Marks = " + average);
                //Console.WriteLine("Percentage = " + percentage);
                //Console.WriteLine();
                #endregion

                #region Problem 11 - Month Days Calculation
                Console.WriteLine("Problem 11: Month Days Calculation");
                Console.Write("Enter Month Number: ");
                int month = Convert.ToInt32(Console.ReadLine());
                int days = 0;

                switch (month)
                {
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12:
                        days = 31;
                        break;
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        days = 30;
                        break;
                    case 2:
                        Console.Write("Enter Year: ");
                        int year = Convert.ToInt32(Console.ReadLine());
                        if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
                        {
                            days = 29; // Leap year
                        }
                        else
                        {
                            days = 28;
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid Month Number.");
                        break;
                }

                Console.WriteLine("Days in Month: " + days);
                Console.WriteLine();
                #endregion

                #region Problem 17 - Check If Points are on a Straight Line
                Console.WriteLine("Problem 17: Check If Points are on a Straight Line");
                Console.WriteLine("Enter three points (x1, y1), (x2, y2), and (x3, y3): ");
                int x1 = Convert.ToInt32(Console.ReadLine());
                int y1 = Convert.ToInt32(Console.ReadLine());
                int x2 = Convert.ToInt32(Console.ReadLine());
                int y2 = Convert.ToInt32(Console.ReadLine());
                int x3 = Convert.ToInt32(Console.ReadLine());
                int y3 = Convert.ToInt32(Console.ReadLine());

                // Check if the area of triangle formed by three points is zero
                int area = (x1 * (y2 - y3)) + (x2 * (y3 - y1)) + (x3 * (y1 - y2));

                if (area == 0)
                {
                    Console.WriteLine("The points lie on a straight line.");
                }
                else
                {
                    Console.WriteLine("The points do not lie on a straight line.");
                }
                Console.WriteLine();
                #endregion

                #region Problem 18 - Worker Efficiency
                Console.WriteLine("Problem 18: Worker Efficiency");
                Console.Write("Enter time taken by the worker to complete the task (in hours): ");
                double timeTaken = Convert.ToDouble(Console.ReadLine());

                if (timeTaken >= 2 && timeTaken <= 3)
                {
                    Console.WriteLine("The worker is highly efficient.");
                }
                else if (timeTaken > 3 && timeTaken <= 4)
                {
                    Console.WriteLine("The worker needs to increase their speed.");
                }
                else if (timeTaken > 4 && timeTaken <= 5)
                {
                    Console.WriteLine("The worker needs training to enhance their speed.");
                }
                else if (timeTaken > 5)
                {
                    Console.WriteLine("The worker is required to leave the company.");
                }
                else
                {
                    Console.WriteLine("Invalid input.");
                }
                Console.WriteLine();
                #endregion

                #region Problem 19 - Value Type Assignment
                Console.WriteLine("Problem 19: Value Type Assignment");
                int a = 5;
                int b = a; // Value type assignment
                b = 10;

                Console.WriteLine("a: " + a); // a remains 5
                Console.WriteLine("b: " + b); // b becomes 10
                Console.WriteLine();
                #endregion

                #region Problem 20 - Reference Type Assignment
                Console.WriteLine("Problem 20: Reference Type Assignment");
                Person person1 = new Person();
                person1.Name = "Alice";

                Person person2 = person1; // Reference type assignment
                person2.Name = "Bob";

                Console.WriteLine("person1 Name: " + person1.Name); // person1 Name is Bob
                Console.WriteLine("person2 Name: " + person2.Name); // person2 Name is Bob
                Console.WriteLine();
                #endregion

                #region Problem 21 - Convert to Int32 with Logical NOT
                Console.WriteLine("Problem 21: Convert to Int32 with Logical NOT");
                int d;
                d = Convert.ToInt32(!(30 < 20));

                Console.WriteLine(d); // Output will be 1 because !(false) is true and Convert.ToInt32(true) is 1
                Console.WriteLine();
                #endregion

                #region Problem 22 - Arithmetic Operation with String Concatenation
                Console.WriteLine("Problem 22: Arithmetic Operation with String Concatenation");
                Console.WriteLine(13 / 2 + " " + 13 % 2); // 6 0
                Console.WriteLine();
                #endregion

                #region Problem 23 - If Else Logic with Increment/Decrement Operators
                Console.WriteLine("Problem 23: If Else Logic with Increment/Decrement Operators");
                int num = 1, z = 5;

                if (!(num <= 0))
                    Console.WriteLine(++num + z++ + " " + ++z);
                else
                    Console.WriteLine(--num + z-- + " " + --z);

                // Output: 6 6
                Console.WriteLine();
                #endregion
        

     





        #endregion

    }
}
}
