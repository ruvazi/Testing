using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingFirstAssignment
{
    class Program
    {
        
        static void Main(string[] args)
        {

            int a,b,c;
            string Type;

            try
            {
                Console.WriteLine(" write first lengt of triangle:");
                a = Int32.Parse(Console.ReadLine());
                Console.WriteLine(" second length:");
                b = Int32.Parse(Console.ReadLine());
                Console.WriteLine(" third length:");
                c = Int32.Parse(Console.ReadLine());
                if (ValidInteger(a) && ValidInteger(b) && ValidInteger(c))
                {
                    if (IsItATriangle(a, b, c))
                    {
                        Type = triangleType(a, b, c);
                        Console.WriteLine("the type is" + Type);
                    }
                    else
                    {
                        Console.WriteLine("its not a triangle");
                    }
                }
                else
                {
                    Console.WriteLine(" the the input integers need to be positive and not null");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Not a validInput", e);
                Console.ReadKey();
            }
            Console.WriteLine("--done--");
            Console.ReadKey();
        }

        //is it positive side lengths
        public static bool ValidInteger(int a)
        {
            if (a > 0) { return true; }
            else { return false; }
        }

        //is the triangle doable?
        public static bool IsItATriangle(int a, int b, int c)
        {
            if (a + b >= c && a + c >= b && b + c >= a)
                return true;
            
            return false;
        }

        //determine triangle type
        public static String triangleType(int a, int b, int c)
        {
            if (a == b && a == c)
            {
                return " a equal sided triangle";
            }
            if(a==b && a!= c || a== c && a!=b || b == c && b!=a)
            {
                return " a two siddes are equal in the triangle";
            }
            return " a scalene triangle";
        }

        // not done, main funktion connecting the other funktions
        public static void newTriangle()
        {
            //need to move central funktion down here, and while loop it
        }
    }
}
