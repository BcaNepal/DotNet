using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BcaConsoleApp
{
    //LINQ  (Language Integrated Query)
    internal class LinqDemo
    {

        public void teacherLinq()
        {
           //Teacher teacherObj = new Teacher { Name = "Seeta", Subject = "Java" };

            List<Teacher> teachers = new List<Teacher>()
            {
                new Teacher{ Name="Seeta", Subject = "Java", Email="seetag@gmail.com"},
                new Teacher{ Name="Geeta", Subject = "Scripting", Email = "geetag@hotmail.com"},
                new Teacher{ Name="Reeta", Subject = "Computer Network", Email = "reetag@hotmail.com"},
                new Teacher{ Name="Neeta", Subject = "C#.net", Email = "neetag@hotmail.com"}

            };

            var t = (from ts in teachers
                    where ts.Email.Contains("hotmail")
                    select  new { ts.Name, ts.Email }).ToList(); // Query syntax + Method Syntax (Mixed Syntax)
           
            t.ForEach(x => Console.WriteLine($" Name: {x.Name} \t Email: {x.Email}"));
            
            
            // var t = teachers.Where(y=> y.Email.Contains("gmail")).Select(x => new { x.Name, x.Email }); // Method syntax
            //foreach (var tx in t) 
            //{
            //    Console.WriteLine($" Teacher's Name: {tx.Name}  Email: {tx.Email}"); 
            //}
        }

        public void showLinq2()
        {

            string[] programs = new string[]
            {
                "C# Tutorials",
                "VB.NET Tutorials",
                "Learn C++",
                "MVC Tutorials" ,
                "Java"
            };

            var prog = programs.Where(x =>x.StartsWith("Java"));
            foreach (var item in prog)
            {
                Console.WriteLine(item);
            }
        }
        public void showLinq()
        {

            List<int> numArr = new List<int> { 23, 54, 23, 32, 77, 43 };
            List<int> nums = (from n in numArr
                       where n > 30
                       select n * 2).ToList();

            var nums2 = nums.Where(x => x > 30).Select(x => x * 2).ToList();
            //foreach (var n in nums)
            //{
            //    Console.WriteLine(n);
            //}
            // nums.forEach()
            nums.ForEach(x => {
                //Console.WriteLine(x);
                // double y = Math.Pow((double)x, 3);
                double y = Math.Pow(double.Parse(x.ToString()), 3);
                Console.WriteLine(y);
                }
            );
        }
        public void demo()
        {
            List<Person> people = new List<Person>()
            {
                new Person{ Name="Seeta", Age=23},
                new Person{Name="Reeta", Age=32}
            };

            foreach (Person person in people)
            {
                Console.WriteLine(person.Name);
                   Console.WriteLine(person.Age);
            }


            List<int> numArr = new List<int> { 23, 54, 23, 32, 77, 43 };
            var nums = from n in numArr
                       where n > 30
                       select n * 2;
            foreach (var n in nums)
            {
                Console.WriteLine(n);
            }

            /**List<string> stringList = new List<string>() 
            {
                "C# Tutorials",
                "VB.NET Tutorials",
                "Learn C++",
                "MVC Tutorials" ,
                "Java"
            };**/

            string[] stringList = new string[]
            {
                "C# Tutorials",
                "VB.NET Tutorials",
                "Learn C++",
                "MVC Tutorials" ,
                "Java"
            };

            string[] stringList2 =  
                {
                "C# Tutorials",
                "VB.NET Tutorials",
                "Learn C++",
                "MVC Tutorials" ,
                "Java"
           };

            var result = from s in stringList
                         where s.Contains("Tutorials")
                         select s;

            //foreach(var strList in stringList)
            //{
            //    Console.WriteLine(strList);
            //}

            foreach (var strList in result)
            {
                Console.WriteLine(strList);
            }

            /*
                 * from <range variable> in <IEnumerable<T> or IQueryable<T> Collection>

                <Standard Query Operators> <lambda expression>

                <select or groupBy operator> <result formation>
            */


        }
    }
}
