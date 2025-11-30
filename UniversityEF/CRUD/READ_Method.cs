using UniversityEF.Data;
using UniversityEF.Models;

namespace UniversityEF.CRUD
{
    class READ_Method
    {

        //READ yvela students wamoigebs


        public static void ReadAllMethod()
        {
            using var context = new UniversityContext();


            var list = context.Students
                //.Where(s => s.Age > 18)
                //.OrderBy(s => s.FirstName)
                .ToList();

            foreach (var s in list)
            {
                Console.WriteLine($"\t\t\t|   ID: {s.StudentId} Name: {s.FirstName} LastName: {s.LastName} Age: {s.Age} PhoneNumber: {s.PhoneNumber}");
                Console.WriteLine();
                Thread.Sleep(20);
            }
        }

    }
}



