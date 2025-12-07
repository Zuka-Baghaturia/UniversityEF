using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityEF.Data;

namespace UniversityEF.CRUD
{
    class UPDATE_Method
    {



        public static void UpdateMethod()
        {

            using var context = new UniversityContext();

            var student = context.Students.FirstOrDefault(s => s.FirstName == "Zuka");

            if (student != null)
            {
                student.Age = 28;
                context.SaveChanges();
                Console.WriteLine("Student updated!");
            }
        }



        public static void UpdateTeacherMethod()
        {
            using var context = new UniversityContext();

            var teacher = context.Teachers.FirstOrDefault(s => s.FirstName == "Nino");

            if (teacher != null)
            {
                teacher.Age = 43;
                context.SaveChanges();
                Console.WriteLine("Teacher updated!");
            }
        }



        

        public static void UpdatePaymentsMethod()
        {
            using var context = new UniversityContext();

            var payment = context.Payments.FirstOrDefault(s => s.StudentId == 5);

            if (payment != null)
            {
                payment.Amount = 2000;
                context.SaveChanges();
                Console.WriteLine("Payment updated!");
            }
        }


    }
}










