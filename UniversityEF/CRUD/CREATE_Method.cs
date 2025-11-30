using UniversityEF.Data;
using UniversityEF.Models;

namespace UniversityEF.CRUD
{
    class CREATE_Method
    {

        // CREATE amatebs axal students


        public static void CreateMethod()
        {

            using var context = new UniversityContext();


            var students = new List<Student> // list shi chavsvi ro cal calke ar shemeqmna 
            {
                new Student
                {
                    StudentId = 51,
                    FirstName = "NAME_1",
                    LastName = "LASTNAME_1",
                    BirthDate = DateOnly.FromDateTime(new DateTime(2004, 6, 1)),
                    Age = 21,
                    PhoneNumber = "593-48-70-30",
                    TeacherId = 1,
                    ExamId = 1,
                    FacultyId = 1,
                    ClassRoomId = 1
                },
                new Student
                {
                    StudentId = 52,
                    FirstName = "NAME_2",
                    LastName = "LASTNAME_2",
                    BirthDate = DateOnly.FromDateTime(new DateTime(2004, 6, 1)),
                    Age = 21,
                    PhoneNumber = "593-48-70-30",
                    TeacherId = 1,
                    ExamId = 1,
                    FacultyId = 1,
                    ClassRoomId = 1
                }
            };

            context.Students.AddRange(students);
            context.SaveChanges();
            Console.WriteLine("Students added successfully!");

        }
    }
}
