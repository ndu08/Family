using FullFamily.Data;
using FullFamily.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullFamily
{
    public class Program
    {
        static void Main(string[] args)
        {
            var context = new DataContext();

            #region 
            // this code can be done in two ways, just in one line instead of two

            //var families = context.Families;
            // var myTest = new MyTester(families);
            #endregion

            var myTest = new MyTester(context.Families);

            Console.WriteLine("-----------Get Family With Most Kids-----------");
            List<Family> f = myTest.GetFamilyWithMostKids();
            PrintFamilies(f);

            Console.WriteLine("-----------Get Family With No Kids------------");
            f = myTest.GetFamilyWithNoKids();
            PrintFamilies(f);

            Console.WriteLine("-----------Get Family By Name ------------");
            f = myTest.GetFamilyByName("Jim");
            PrintFamilies(f);

            Console.WriteLine("--------All Father's Names and Ages-----------");
            foreach (var family in context.Families)
            {
                Console.WriteLine($"{family.Father.Name} - {family.Father.Age}");
            }

            Console.WriteLine("--------Average Age of Each Family -----------");
            foreach (var family in context.Families)
            {
                Console.WriteLine(family.FamilyId + " " + family.AverageAge);              
            }

            Console.WriteLine("--------Get Youngest Family -----------");
            var youngestFamily = myTest.GetYoungestFamily();
            Console.WriteLine(youngestFamily.AverageAge);
            Console.WriteLine(youngestFamily.Age);

            Console.WriteLine("--------Get Family With Youngest Child -----------");
            f = myTest.GetFamilyWithYoungestChild();
            PrintFamilies(f);

            Console.WriteLine("--------Get Family With Oldest Child-----------");
            f = myTest.GetFamilyWithOldestChild();
            PrintFamilies(f);

            Console.WriteLine("------Get Family With Parent Name Starts With (N)------");
            f = myTest.GetFamilyParentNameStartsWith("N");
            PrintFamilies(f);

            #region
            //var myTest = new MyTester();
            //myTest.Run();
            //foreach (var family in collection)
            //{

            //  }
            #endregion

            Console.ReadLine();
        }
        public static void PrintFamily(Family family)
        {
            Console.WriteLine(family);
        }
        public static void PrintFamilies(List<Family> families)
        {
            foreach (var family in families)
            {
                PrintFamily(family);
            } 
        }



        #region
        //string obj = "!";               // my way 

        //for (int i = 0; i < obj.Length; i++)
        //{
        //    i+=100;
        //    Console.WriteLine("Orest is a nice guy " + i);
        //}

        //var person
        //var message = person.FirstName 

        //message = "Orest is a nice guy";
        //for (int i = 0; i < 100; i++)
        //{
        //    message += "!";
        //}
        //Console.WriteLine(message);

        //var builder = new StringBuilder("Orest is a nice guy");
        //for (int i = 0; i < 100; i++)
        //{
        //    builder.Append("!");
        //}

        //var context = new DataContext();
        //var families = context.Families;
        //foreach (var family in families)
        //{
        //    Console.WriteLine(family);
        //    Console.WriteLine("-----------------");
        //}
        #endregion
    }
}
