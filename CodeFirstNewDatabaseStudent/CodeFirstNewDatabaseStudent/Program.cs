using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstNewDatabaseStudent
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new StudentContext())
            {
                Console.WriteLine("Enter Student name: ");
                var name = Console.ReadLine();

                var student = new Student { StudentName = name };
                db.Students.Add(student);
                db.SaveChanges();

                var query = from b in db.Students
                            orderby b.StudentName
                            select b;

                foreach (var item in query)
                {
                    Console.WriteLine(item.StudentName);
                }
            }
        }
    }
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        
        public virtual List<Subject> Subjects { get; set; }
    }

    public class Subject
    {
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        
        public int StudentId { get; set; }
        public virtual Student Student { get; set; }
    }

    public class StudentContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }
    }
}
