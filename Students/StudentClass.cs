using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    public class StudentClass
    {
        public List<Student> Class = new List<Student>();

        public void Add(Student student)
        {
            if (Class.Where(s => s.Name.Contains(student.Name)).Any() && Class.Where(s => s.Surname.Contains(student.Surname)).Any())
            {
                Console.WriteLine($"{student.Name} isminde ve {student.Surname} soyadında, Id numarası {student.Id} olan bir öğrenci var. Eklemek istediğine emin misin?");
                string answer = Console.ReadLine();
                answer = answer.ToLower();
                if (answer == "evet")
                {
                    Class.Add(student);
                }
            }
            else
            {
                Class.Add(student);
            }
        }

        public List<Student> GetStudentByName(string name)
        {
            return Class.Where(s => s.Name.Contains(name)).ToList();
        }
        public Student GetStudentById(int id)
        {
            return Class.FirstOrDefault(p => p.Id == id);
        }
        public List<Student> GetStudentbySurname(string surname)
        {
            return Class.Where(p => p.Surname.Contains(surname)).ToList();
        }

    }
}
