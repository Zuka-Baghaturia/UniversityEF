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

    /// <summary>
    /// 
    /// </summary>
        public static void UpdateMethod()
        {
            // UPDATE     anaxlebs studentebs

            using var context = new UniversityContext();

            var student = context.Students.FirstOrDefault(s => s.FirstName == "Zuka");

            if (student != null)
            {
                student.Age = 28;
                context.SaveChanges();
                Console.WriteLine("Student updated!");
            }
        }
    }
}
