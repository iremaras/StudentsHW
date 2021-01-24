using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentClass Gryffindor = new StudentClass();
            Gryffindor.Add(new Student { Id = 1, Name = "Harry", Surname = "Potter" });
            Gryffindor.Add(new Student { Id = 2, Name = "Hermione", Surname = "Granger" });
            Gryffindor.Add(new Student { Id = 3, Name = "Ron", Surname = "Weasley" });
            Gryffindor.Add(new Student { Id = 4, Name = "George", Surname = "Weasley" });
            Gryffindor.Add(new Student { Id = 5, Name = "Fred", Surname = "Weasley" });
            StudentClass Ravenclaw = new StudentClass();
            Ravenclaw.Add(new Student { Id = 1, Name = "Luna", Surname = "Lovegood" });
            Ravenclaw.Add(new Student { Id = 2, Name = "Cho", Surname = "Chang" });

            var Weasley = Gryffindor.GetStudentbySurname("Weasley");
            Weasley.ForEach(w => Console.WriteLine($"{w.Id} - {w.Name} {w.Surname}"));

            Ravenclaw.Add(new Student { Id = 3, Name = "Luna", Surname = "Lovegood" });
            Console.ReadLine();
        }

    }
}
