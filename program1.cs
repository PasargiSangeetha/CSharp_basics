using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class program1
    {
        static void Q1()
        {
            Console.WriteLine("Q1 solution");
            Console.WriteLine("Welcome to the world of C#");
        }
        static void Q2()
        {
            Console.WriteLine("Q2 Solution");
            Console.WriteLine("name of the user");
            String username = Console.ReadLine();
            Console.WriteLine("Hi {0}\nWelcome to the World of C#", username);
        }
        static void Q3()
        {
            Console.WriteLine("Q3 Solution");
            Console.WriteLine("n1");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("n2");
            int n2 = Convert.ToInt32(Console.ReadLine());
            for (int i=n1;i<n2; i++)
            {
                Console.Write(i);
            }
        }
        static void Q4()
        {
            Console.WriteLine("Q4 Even or odd");
            int num=Convert.ToInt32(Console.Read());
            if (num%2==0)
            {
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("odd");
            }
        }
        static void Q5()
        {
            int oddCount=0;
            int evenCount = 0;
            Console.WriteLine("even odd count program \n enter the Array values");
            int[] a = new int[10];
            for (int i=0;i<10;i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());                             
            }
            for (int i = 0; i < 10; i++)
            {
                if (a[i] % 2 == 0)
                {
                    evenCount += 1;
                }
                else
                {
                    oddCount += 1;
                }
            }
            Console.WriteLine($"even count {evenCount}");
            Console.WriteLine($"odd count {oddCount}");


        }
        static void Q6()
        {
            Console.WriteLine("Temp in fahrenheit");
            float fahrenheit = Convert.ToInt32(Console.ReadLine());
            float celsius = (fahrenheit - 32)*5/9;
            Console.WriteLine("{0}fahrenheit = {1}celsius", fahrenheit, celsius);
        }
        static void Q7()
        {
            Console.WriteLine("Squares upto 625");
            for (int i=0;i<26;i++)
            {
                Console.Write($"{i*i}, ");
            }
        }
        static void Q8()
        {
            Console.WriteLine("Enter number to get factorial of a number");
            int fact = 1; 
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                fact = fact * i;
            }
            Console.Write(fact);

        }
        static void Q9()
        {
            Console.WriteLine("factorial series less than 40");
            int fact = 1;
            int num = 40;
            for (int i=1; i<=num; i++)
            {
                fact = fact * i;
                Console.Write($"{fact} ");
            }
        }
        static void Q11()
        {
            Console.WriteLine("multiplication table");
            int num1 = Convert.ToInt32(Console.ReadLine());
            for (int i=1; i<=20; i++)
            {
                int val = num1 * i;
                Console.WriteLine(" {0} * {1} = {2} ", num1, i, val);
            }
        }
        static void Q10()
        {
            Console.WriteLine("Fibnonacii series");
            int a = 0;int b = 1;
            int num=40;int c;
            Console.Write(b);
            for (c = 0; c <= num; c++)
            {
                c = a + b;
                Console.Write($" {c}");
                a = b;
                b = c;
            }
        }
        static void Q12()
        {
            Console.WriteLine(" values divisible by 7");
            int minVal = 200; int maxVal = 300;
            for (int i = minVal; i <= maxVal; i++)
            {
                if (i % 7==0)
                {
                    Console.Write($"{i} ");
                }
                    
            }
        }
        static void Q13()
        {
            Console.WriteLine("Enter 3 values and check greater value");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            if (a>b)
            {
                if (a>c)
                {
                    Console.WriteLine(a);
                }
                else
                {
                    Console.WriteLine(c);
                }
            }
            else
            {
                Console.WriteLine(b);
            }
        }
        static void Q15()
        {
            Console.WriteLine("Smaller Number \n Enter Array values");
            int[] arrList = new int[10];
            for (int i = 0; i < 10; i++)
            {
                arrList[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(arrList);
            Console.WriteLine((arrList[0]));
            for(int i = 0; i < arrList.Length; i++)
            {
                Console.Write($"{arrList[i]} ");
            }
            Array.Reverse(arrList);
            Console.WriteLine($"\n{(arrList[0])}");
            for(int i = 0; i < arrList.Length; i++)
            {
                Console.Write($"{arrList[i]} ");
            }
            double avg = Queryable.Average(arrList.AsQueryable());
            Console.WriteLine($"\n{(avg)}");
            int sum = arrList.Sum();
            Console.WriteLine(sum);
        }
        static void Q14()
        {
            Console.WriteLine("Smaller Number \n Enter Array values");
            int[] a = new int[5];
            for (int i = 0; i < 5; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());               
            }
            Array.Sort(a);
            Console.WriteLine(a[0]);
        }
        static void Q16()
        {
            Console.WriteLine("Enter word");
            string word = Console.ReadLine();
            Console.WriteLine(word.Length);    
        }
        static void Q17()
        {
            Console.WriteLine("Enter Word");
            string originalWord = Console.ReadLine();
            string reverseWord = string.Empty;
            for(int c=originalWord.Length-1;c>=0; c--)
            {
                reverseWord += originalWord[c];
            }
            Console.WriteLine(reverseWord);
        }
        static void Q18()
        {
            Console.WriteLine("Enter Word1");
            string word1 = Console.ReadLine();
            Console.WriteLine("Enter Word2");
            string Word2 = Console.ReadLine();
            if (word1 == Word2)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }
        static void Q19()
        {
            Console.WriteLine("Enter Word");
            string originalWord = Console.ReadLine();
            string reverseWord = string.Empty;
            for (int c = originalWord.Length - 1; c >= 0; c--)
            {
                reverseWord += originalWord[c];
            }
            Console.WriteLine(reverseWord);
            if(reverseWord == originalWord)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }

        }
        static void Main(string[] args)
        {
            Q1();
            Q2();
            Q3();
            Q4();
            Q5();
            Q6();
            Q7();
            Q8();
            Q9();
            Q10();
            Q11();
            Q12();
            Q13();
            Q15();
            Q14();
            Q16();
            Q17();
            Q18();
            Q19();
        }
    }
}
