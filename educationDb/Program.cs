using educationDb.Models;
using System;
using System.Linq;

namespace educationDb
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new EdDbContext();


            var studentswithmajors = from s in context.Students
                                     join m in context.Majors
                                     on s.MajorId equals m.Id
                                     where s.StateCode == "KY"
                                     orderby s.Lastname
                                     select new { s.Firstname, s.Lastname, Major = m.Description };
            foreach(var s in studentswithmajors)
            {
                Console.WriteLine($"{s.Firstname} {s.Lastname} || {s.Major}"); 
            }
                           
                            






            //var studentsKY = context.Students
            //                    .Where(s => s.StateCode == "KY")
            //                    .OrderBy(s => s.Lastname)
            //                    .ToList();
                                    
            
            //foreach(var s in studentsKY)
            //{
                
            //    Console.WriteLine($"{s.Firstname} {s.Lastname}");
            //}
        }
    }
}
