using System.Threading.Tasks;
using UniversityEF.Data;

namespace UniversityEF.CRUD
{
    class DELETE_Method
    {
        public static void DeleteMethod()
        {

            //DELETE             shlis studentebs


            using var context = new UniversityContext();


            var student = context.Students.FirstOrDefault(s => s.StudentId == 52);



            if (student != null)
            {
                context.Students.Remove(student);
                context.SaveChanges();
                Console.WriteLine("Student deleted!");
            }
        }
    }
}
