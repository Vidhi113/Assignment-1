using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.
            //Console.WriteLine("Hello World");

            //2. & 3.
            //int a = 10;
            //int b = 5;
            //Console.WriteLine(a + b);
            //Console.WriteLine(a / b);

            //4.
            //Console.WriteLine(-1 + 4 * 6);
            //Console.WriteLine(( 35 + 5 ) % 7);
            //Console.WriteLine(14 + -4 * 6 / 11);
            //Console.WriteLine(2 + 15 / 6 * 1 - 7 % 2); 

            //5.
            //Console.WriteLine("Input the First Number : ");
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Input the Second Number : ");
            //int b = Convert.ToInt32(Console.ReadLine());
            //int c = a;
            //a = b;
            //b = c;
            //Console.WriteLine("First Value After Swapping : {0} ",a);
            //Console.WriteLine("Second Value After Swapping : {0} ", b);

            //6.
            //Console.WriteLine("Input the First Number : ");
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Input the Second Number : ");
            //int b = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Input the Third Number : ");
            //int c = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("The Multiplicatin of {0} , {1} and {2} is = {3}",a,b,c,(a*b*c));

            //7.
            //Console.WriteLine("Input the First Number : ");
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Input the Second Number : ");
            //int b = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
            //Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
            //Console.WriteLine("{0} * {1} = {2}", a, b, a * b);
            //Console.WriteLine("{0} / {1} = {2}", a, b, a / b);
            //Console.WriteLine("{0} Modulo {1} = {2}", a, b, a % b);

            //8.
            //Console.WriteLine("Input Any Number : ");
            //int a = Convert.ToInt32(Console.ReadLine());
            //for (int i = 0; i <= 10; i++)
            //{
            //    Console.WriteLine("{0} * {1} = {2}", a, i, a*i);   
            //}

            //9.
            //Console.WriteLine("Input the First Number : ");
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Input the Second Number : ");
            //int b = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Input the Third Number : ");
            //int c = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Input the Forth Number : ");
            //int d = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("The Avarage of {0} , {1}, {2}, {3}, is = {4}", a, b, c, d, ( a + b + c + d ) / 4);

            //10.
            // Console.WriteLine("Input the First Number : ");
            // int x = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Input the Second Number : ");
            // int y = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Input the Third Number : ");
            // int z = Convert.ToInt32(Console.ReadLine());
            // Console.Write("Result of specified numbers {0}, {1} and ", x, y);
            // Console.WriteLine("{0}, (x+y).z is {1} and x.y + y.z is {2}", z, (x+y)*z, (x*y)+(y*z));

            //11.
            //Console.WriteLine("Enter Your Age : ");
            //int i = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("You Look Older Than {0} ",i);

            //12.
            //Console.Write("Input Any Number : ");
            //int a = Convert.ToInt32(Console.ReadLine());
            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        Console.Write("{0} ",a);
            //    }
            //    Console.WriteLine();
            //    for (int k = 0; k < 4; k++)
            //    {
            //        Console.Write("{0}", a);
            //    }
            //    Console.WriteLine();
            //}

            //13.
            //Console.Write("Input Any Number : ");
            //int a = Convert.ToInt32(Console.ReadLine());
            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        if (i == 0 || i == 4 || j == 0 || j == 2)
            //        {
            //            Console.Write("{0} ",a);
            //        }
            //        else
            //        {
            //            Console.Write("  ");
            //        }
            //    }
            //    Console.WriteLine();
            //}

            //14.
            //Celsius to Fahrenheit: F = 9/5(C) + 32 or F = 1.80(C) + 32
            //Celsius to Kelvin: K = C + 273 (or K = C + 271.15 to be more precise)
            //Console.WriteLine("Enter Celsius to Convert Kelvin and Fahrenheit : ");
            //float c = Convert.ToSingle(Console.ReadLine());
            //Console.WriteLine("{0} Celsius To Kelvin is = {1}", c, (c + 273.15));
            //Console.WriteLine("{0} Celsius To Fahrenheit is = {1}", c, (1.8*c) + 32);

            //15.
            //Console.WriteLine(remove_char("Atmiya University", 2));
            //Console.WriteLine(remove_char("Atmiya University", 7));   
            //}
            //public static string remove_char(string str, int n)
            //{
            //return str.Remove(n);
            //}

            //15.
            //string s1 = "Hi I'm Vidhi";         //(4->Index number which you want to delete)
            //string s2 = s1.Remove(4,1);         //(1->how many numbers you want to delete [default=after index all char. delete])
            //Console.WriteLine(s2);

            //16.
            //Console.Write("Input a string : ");
            //string str = Console.ReadLine();
            //if (str.Length >= 1)
            //{
            //    string s = str.Substring(0, 1);
            //    Console.WriteLine(s + str + s);
            //}
            //else 
            //{
            //    Console.WriteLine("Input Any Valid String...");
            //}

            //17.
            //Console.WriteLine("Enter First Number : ");
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter Second Number : ");
            //int b = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine( ( a > 0 && b < 0 ) || ( a < 0 && b > 0 ) );

            //18.
            //Console.WriteLine("Enter First Number : ");
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter Second Number : ");
            //int b = Convert.ToInt32(Console.ReadLine());
            //if (a == b)
            //{
            //    Console.WriteLine("({0} + {1} ) * 3 = {2} ", a, b, (a + b) * 3);
            //}
            //else
            //{
            //    Console.WriteLine("{0} + {1} = {2} ", a, b, a + b);
            //}

            //19.
            //Console.WriteLine("Enter First Number : ");
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter Second Number : ");
            //int b = Convert.ToInt32(Console.ReadLine());
            //int c = Math.Abs(a);
            //int d = Math.Abs(b);
            //if( a > b )
            //{
            //    Console.WriteLine("Absolute value of {0} = {1} and the Double of {1} is {2} ", a, c, c * 2);
            //    Console.WriteLine("Absolute value of {0} = {1} and the Double of {1} is {2} ", b, d, d * 2);
            //}
            //else
            //{
            //    Console.WriteLine("Absolute of {0} is {1}", a, c);
            //    Console.WriteLine("Absolute of {0} is {1}", b, d);
            //}

            //20.
            //Console.WriteLine("Enter First Number : ");
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter Second Number : ");
            //int b = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine((a + b == 20) || (a == 20) || (b == 20));

            //21.
            //Console.WriteLine("Enter An Integer : ");
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine((Math.Abs(a - 100) <= 20) || (Math.Abs(a - 100) <= 20));

            //22.
            //Console.Write("Enter Any String : ");
            //string s = Console.ReadLine();
            //Console.WriteLine("In Lower Case : {0}",s.ToLower());

            //23.
            //Console.WriteLine("The Odd Number Between 1 to 99 is ..");
            //for (int i = 1; i <= 100; i++)
            //{   
            //    if(i%2!=0)
            //    Console.WriteLine(i);
            //}

            //24.
            
            //25.
            //Console.WriteLine("Enter Any Integer : ");
            //int i = Convert.ToInt32(Console.ReadLine());
            //int flag = i;
            //int a, sum = 0;
            //while( i != 0 )
            //{
            //    a = i % 10;
            //    sum += a;
            //    i = i / 10;
            //}
            //Console.WriteLine("Sum of digit {0} is {1}",flag, sum);

            //26.
            //Console.WriteLine("Write Any String : ");
            //string str = Console.ReadLine(); 
            //string[] s =str.Split(' ');
            //string ans = "";
            //for (int i = s.Length - 1; i >= 0; i--)
            //{
            //    ans += s[i] + " ";
            //}
            //Console.Write("Reversed String : ");
            //Console.WriteLine(ans.Substring(0, ans.Length - 1));

            //27.
            
            //28.
            //Console.Write("Write Any Hexa-Decimal Code : ");
            //string hex_code = Console.ReadLine();
            //int dec_code = Convert.ToInt32(hex_code,16);
            //Console.WriteLine("Decimal Code of {0} is {1} ", hex_code, dec_code);

            //29.
            //int[] arr1 = new int[] { 1, 4, -4, 6 };
            //int[] arr2 = new int[] { 1, 6, -2, -3 };
            //Console.Write("Multiply corresponding elements of two arrays : ");
            //int[] arr3 = new int[4];
            //for (int i = 0; i < 4; i++)
            //{
            //    arr3[i] = arr1[i] * arr2[i];
            //    Console.Write("{0} ",arr3[i]);
            //}
            //Console.WriteLine();

            //30.
            //Console.Write("Enter String : ");
            //string str = Console.ReadLine(); 
            //if (str.Length <= 4)
            //{
            //    Console.WriteLine(str + str + str + str);
            //}
            //else
            //{
            //    string s = str.Substring(str.Length - 4);
            //    Console.WriteLine(s + s + s + s);
            //}

            //31.
            //Console.Write("Enter Any Number : ");
            //int i = Convert.ToInt32(Console.ReadLine());
            //if (i > 0)
            //{
            //    Console.WriteLine((i % 3 == 0) || (i % 7 == 0));
            //}
            
            //32.
            //Console.Write("Enter Any String : ");
            //string str = Console.ReadLine();
            //Console.WriteLine((str.Length < 6 && str.Equals("Hello")) || (str.StartsWith("Hello")));

            //33.
            //Console.Write("Enter First Value : ");
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter Second Value : ");
            //int b = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(a < 100 && b > 200);

            //34.
            //Console.Write("Enter An Integer : ");
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter Second Value : ");
            //int b = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine((a > -10 && a < 10) || (b > -10 && b < 10));

            //35.
            //Console.Write("Enter Any String : ");
            //string str=Console.ReadLine();
            //if (str.Substring(1, 2).Equals("HP"))
            //{
            //    Console.WriteLine(str.Remove(1, 2));
            //}
            //else { Console.WriteLine(str); }

            //36.
            //Console.Write("Enter First Value : ");
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter Second Value : ");
            //int b = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter Third Value : ");
            //int c = Convert.ToInt32(Console.ReadLine());
            //if (a > b)
            //{
            //    if (c > a)
            //    {
            //        Console.WriteLine("Smallest of three : {0}", b);
            //        Console.WriteLine("Largest of three : {0}", c);
            //    }
            //    else
            //    {
            //        if (c > b)
            //        {
            //            Console.WriteLine("Smallest of three : {0}", b);
            //        }
            //        else
            //        {
            //            Console.WriteLine("Smallest of three : {0}", c); 
            //        }
            //        Console.WriteLine("Largest of three : {0}", a);
            //    }
            //}
            //else
            //{
            //    if (c > b)
            //    {
            //        Console.WriteLine("Smallest of three : {0}", a);
            //        Console.WriteLine("Largest of three : {0}", c);
            //    }
            //    else
            //    {
            //        if (c > a)
            //        {
            //            Console.WriteLine("Smallest of three : {0}", a);
            //        }
            //        else
            //        {
            //            Console.WriteLine("Smallest of three : {0}", c);
            //        }
            //        Console.WriteLine("Largest of three : {0}", b);
            //    }
            //}

            //37.
            //Console.Write("Enter Any Value : ");
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter Any Value : ");
            //int b = Convert.ToInt32(Console.ReadLine());
            //int c = Math.Abs(a - 20);
            //int d = Math.Abs(b - 20);
            //if (a != b)
            //    Console.WriteLine((c < d ? a : b));
            //else { Console.WriteLine("false"); }

            //38.

            //39.

            //40.
            //int[] arr = new int[] { 4, 56, 345, 4, 6, 7, 7, 78 };
            //int sum = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{ 
            //    sum+=arr[i];
            //}
            //Console.WriteLine("The Sum Of Array is : {0} ",sum);

            //41.
            //int[] arr1 = new int[] { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };
            //int[] arr2 = new int[] { 6, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 5 };
            //int last1 = arr1.Length - 1;
            //int last2 = arr2.Length - 1;
            //Console.WriteLine((arr1[0] == arr2[0]) || (arr1[last1] == arr2[last2]));

            //42.
            //Console.WriteLine("Enter Three Elements : ");
            //int[] a = new int[3];
            //for (int i = 0; i < 3; i++)
            //{
            //    a[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //int temp = a[0];
            //for (int j = 0; j < a.Length - 1; j++)
            //{
            //    a[j] = a[j + 1];
            //}
            //a[a.Length - 1] = temp;
            //Console.Write("Rotate An Array Of Integers In Left Direction : ");
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.Write("{0} ",a[i]);
            //}
            //Console.WriteLine();

            //43.
            //Console.WriteLine("Enter Three Elements : ");
            //int[] a = new int[3];
            //for (int i = 0; i < 3; i++)
            //{
            //    a[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //if (a[0] > a[2])
            //{
            //    Console.WriteLine("The Larger Value Between First And Last Element is : {0} ", a[0]);
            //}
            //else { Console.WriteLine("The Larger Value Between First And Last Element is : {0} ", a[2]); }

            //44. 
            //int[] arr1 = new int[3] { 6, 2, 2 };
            //int[] arr2 = new int[3] { -3, 9, 45 };
            //int[] arr3 = new int[3] { 8, -7, 0 };
            //int[] arr4 = new int[3];
            //arr4[0] = arr1[1];
            //arr4[1] = arr2[1];
            //arr4[2] = arr3[1];
            //Console.Write("The Middle Elements Of Three Is : ");
            //foreach (int a in arr4)
            //{
            //    Console.Write("{0} ", a);
            //}
            //Console.WriteLine();

            //45.
            //Console.WriteLine("Enter Five Elements : ");
            //int flag = 0;
            //int[] a = new int[5];
            //for (int i = 0; i < 5; i++)
            //{ 
            //    a[i] = Convert.ToInt32(Console.ReadLine());     
            //}
            //for (int i = 0; i < 5; i++)
            //{
            //    if ((a[i] % 2 != 0) && (flag < 1))
            //    {
            //        Console.WriteLine(true);
            //        flag = 1;
            //    }
            //}        
       
        }
    }
}
