using EntityFrameworkDemo.Data;

namespace EntityFrameworkDemo.Models
{
    public class StudentDAL
    {
        ApplicationDbContext db;

        public StudentDAL(ApplicationDbContext db)
        {
            this.db = db;
        }

        public IEnumerable<Student> GetStudents()
        {
            var result = from s in db.Students
                         select s;
            return result;
        }

        public Student GetStudentById(int id)
        {
            var result = db.Students.Where(x => x.Id == id).FirstOrDefault();
            return result;
            
        }

        public int AddStudent(Student student)
        {
            db.Students.Add(student);
            int result = db.SaveChanges();
            return result;
        }

        public int UpdateStudent(Student student)
        {
            int res = 0;
            var result = db.Students.Where(x => x.Id == student.Id).FirstOrDefault();

            if(result != null)
            {
                result.Sname = student.Sname;
                result.Spercentage = student.Spercentage;
                result.City = student.City;

                res = db.SaveChanges();
            }
            return res;
        }

        public int DeleteStudent(int id)
        {
            int res = 0;
            var result = db.Students.Where(x => x.Id ==id).FirstOrDefault();    
            if(result != null)
            {
                db.Students.Remove(result);
                res = db.SaveChanges();
            }
            return res;
        }
    }
}
