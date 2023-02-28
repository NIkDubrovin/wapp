using System.Diagnostics;
using wapp1.Models;

namespace wapp1.Data
{
    public class DbInitializer
    {
        public static void Initialize(ApplicationContext context)
        {
            context.Database.EnsureCreated();


            if (context.Students.Any())
            {
                return;   // DB has been seeded
            }

            var instructors = new Instructor[]
       {
                 new Instructor{Name="Carson"},
                 new Instructor{Name="Nicola"},
                 new Instructor{Name="Dboro"},
       };
            foreach (Instructor e in instructors)
            {
                context.Instructors.Add(e);
            }
            context.SaveChanges();

            var professions = new Profession[]
            {
                new Profession{ Name = "Програмная инженерия"},
                new Profession{ Name = "Информатика и вычислительная техника"},
                new Profession{ Name = "Информатика и Экономика"}
            };
            
            foreach (Profession p in professions)
            {
                context.Professions.Add(p);
            }

            context.SaveChanges();

            var groups = new Group[]
            {
                new Group{ Name = "22 - При - 1", Year = 1, ProfessionId = 1, },
                new Group{ Name = "19 - При", Year = 1, ProfessionId = 2, }
            };

            foreach (Group p in groups)
            {
                context.Groups.Add(p);
            }

            context.SaveChanges();

            var students = new Student[]
            {
                new Student{Name="Carson Alexander", GroupId = 1},
                new Student{Name = "Carson Alexander",GroupId = 1},
                new Student{Name = "Carson Alexander",GroupId = 1},
                new Student{Name = "Carson Alexander",GroupId = 1},
                new Student{Name = "Carson Alexander",GroupId = 2},
                new Student{Name = "Carson Alexander",GroupId = 2},
                new Student{Name = "Carson Alexander",GroupId = 2},
                new Student{Name = "Carson Alexander",GroupId = 3}
            };

            foreach (Student p in students)
            {
                context.Students.Add(p);
            }

            context.SaveChanges();

         

          //  var courses = new Course[]
          //{
          //      new Course{Name="Chemistry", StudentId=1, InstructorID=1},
          //      new Course{Name="Microeconomics",StudentId=1, InstructorID=2},
          //      new Course{Name="Macroeconomics",StudentId=1, InstructorID=3},
          //      new Course{Name="Calculus",StudentId=2, InstructorID=1},
          //      new Course{Name="Trigonometry",StudentId=3, InstructorID=2},
          //      new Course{Name="Composition",StudentId=2, InstructorID=2},
          //      new Course{ Name="Literature",StudentId=4, InstructorID=3}
          //};
          //  foreach (Course c in courses)
          //  {
          //      context.Courses.Add(c);
          //  }
          //  context.SaveChanges();

          

            var evaluations = new Evaluation[]
            {
                new Evaluation{EvaluationDate = DateTime.Parse("2022-09-01"), Number = 3, StudentId = 1, CourseId = 1 },
                new Evaluation{EvaluationDate = DateTime.Parse("2012-09-01"), Number = 5, StudentId = 1, CourseId = 2 },
                new Evaluation{EvaluationDate = DateTime.Parse("2022-10-15"), Number = 2, StudentId = 5, CourseId = 3 },

            };
            foreach (Evaluation s in evaluations)
            {
                context.Evaluations.Add(s);
            }
            context.SaveChanges();
        }
    }
}
