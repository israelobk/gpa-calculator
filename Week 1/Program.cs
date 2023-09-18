using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1. Enter Course & Code: ");
            string course = Console.ReadLine();
            Console.Write("1. Enter Course Unit: ");
            int courseUnit = int.Parse(Console.ReadLine());
            Console.Write("1. Enter Course Score: ");
            int courseScore = int.Parse(Console.ReadLine());

            Console.Write("2. Enter Course & Code: ");
            string course1 = Console.ReadLine();
            Console.Write("2. Enter Course Unit: ");
            int courseUnit1 = int.Parse(Console.ReadLine());
            Console.Write("2. Enter Course Score: ");
            int courseScore1 = int.Parse(Console.ReadLine());

            Console.Write("3. Enter Course & Code: ");
            string course2 = Console.ReadLine();
            Console.Write("3. Enter Course Unit: ");
            int courseUnit2 = int.Parse(Console.ReadLine());
            Console.Write("3. Enter Course Score: ");
            int courseScore2 = int.Parse(Console.ReadLine());

            Console.Write("4. Enter Course & Code: ");
            string course3 = Console.ReadLine();
            Console.Write("4. Enter Course Unit: ");
            int courseUnit3 = int.Parse(Console.ReadLine());
            Console.Write("4. Enter Course Score: ");
            int courseScore3 = int.Parse(Console.ReadLine());

            Console.Write("5. Enter Course & Code: ");
            string course4 = Console.ReadLine();
            Console.Write("5. Enter Course Unit: ");
            int courseUnit4 = int.Parse(Console.ReadLine());
            Console.Write("5. Enter Course Score: ");
            int courseScore4 = int.Parse(Console.ReadLine());

            int[] Unitnum = { courseScore, courseScore1, courseScore2, courseScore3, courseScore4 };

            for (int i = 0; i < Unitnum.Length; i++)
            {
                if (Unitnum[i] >= 70 && Unitnum[i] < 100)
                {
                    Console.WriteLine("A");
                }else if (Unitnum[i] >=60 && Unitnum[i] < 69)
                {
                    Console.WriteLine("B");
                }else if (Unitnum[i] >=50 && Unitnum[i] < 59)
                {
                    Console.WriteLine("C");
                }else if (Unitnum[i] >=45 && Unitnum[i] < 49)
                {
                    Console.WriteLine("D");
                }else if (Unitnum[i] >=40 && Unitnum[i] < 44)
                {
                    Console.WriteLine("E");
                }else 
                { 
                    Console.WriteLine("F");
                }
            }

            Console.WriteLine("|-----------------|-------------|-------|------------|------------|------------|");
            Console.WriteLine("{0} {1, -15} {2} {3, -11} {4} {5, -5} {6} {7, -10} {8} {9, -9} {10} {11, -10} {12}", "|", "COURSE & CODE", "|", "COURSE UNIT", "|", "GRADE", "|", "GRADE-UNIT", "|", "WEIGHT Pt.", "|", "REMARK", "|");
            Console.WriteLine("|-----------------|-------------|-------|------------|------------|------------|");
            Console.WriteLine("{0} {1, -15} {2} {3, -11} {4} {5, -5} {6} {7, -10} {8} {9, -9} {10} {11, -10} {12}", "|", course, "|", courseUnit, "|", Unitnum, "|", course, "|", courseUnit, " |", courseScore, "|");
            Console.WriteLine("|-----------------|-------------|-------|------------|------------|------------|");
            Console.WriteLine("{0} {1, -15} {2} {3, -11} {4} {5, -5} {6} {7, -10} {8} {9, -9} {10} {11, -10} {12}", "|", course1, "|", courseUnit1, "|", Unitnum, "|", course, "|", courseUnit, " |", courseScore, "|");
            Console.WriteLine("|-----------------|-------------|-------|------------|------------|------------|");
            Console.WriteLine("{0} {1, -15} {2} {3, -11} {4} {5, -5} {6} {7, -10} {8} {9, -9} {10} {11, -10} {12}", "|", course2, "|", courseUnit2, "|", Unitnum, "|", course, "|", courseUnit, " |", courseScore, "|");
            Console.WriteLine("|-----------------|-------------|-------|------------|------------|------------|");
            Console.WriteLine("{0} {1, -15} {2} {3, -11} {4} {5, -5} {6} {7, -10} {8} {9, -9} {10} {11, -10} {12}", "|", course3, "|", courseUnit3, "|", Unitnum, "|", course, "|", courseUnit, " |", courseScore, "|");
            Console.WriteLine("|-----------------|-------------|-------|------------|------------|------------|");
            Console.WriteLine("{0} {1, -15} {2} {3, -11} {4} {5, -5} {6} {7, -10} {8} {9, -9} {10} {11, -10} {12}", "|", course4, "|", courseUnit4, "|", Unitnum, "|", course, "|", courseUnit, " |", courseScore, "|");
            Console.WriteLine("|-----------------|-------------|-------|------------|------------|------------|");

            

             //if ((courseScore >= 70) && (courseScore <= 100))
            //{
            //    Console.WriteLine("A"); 
            //}
            //else if((courseScore >= 60) && (courseScore <= 69))
            //{
            //    Console.WriteLine("B");

            //}
            //else { 
            //}


            Console.ReadLine();
        }

    }
}
