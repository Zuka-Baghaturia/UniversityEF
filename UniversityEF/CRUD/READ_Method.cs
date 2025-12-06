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
                Console.WriteLine($"\t\t\t|   Student_ID: {s.StudentId} Name: {s.FirstName} LastName: {s.LastName} Age: {s.Age} PhoneNumber: {s.PhoneNumber}");
                Console.WriteLine();
                Thread.Sleep(10);
            }
        }

        public static void ReadTeacherMethod()
        {
            using var context = new UniversityContext();


            var list = context.Teachers
                .ToList();

            foreach (var t in list)
            {
                Console.WriteLine($"\t|   Teacher_ID: {t.TeacherId} Name: {t.FirstName} LastName: {t.LastName} Age: {t.Age} PhoneNumber: {t.PhoneNumber} Subject: {t.Subject}");
                Console.WriteLine();
                Thread.Sleep(20);
            }
        }

        public static void ReadPaymentsMethod()
        {
            using var context = new UniversityContext();


            var list = context.Payments
                .ToList();

            foreach (var p in list)
            {
                Console.WriteLine($"\t\t|   Payment_ID: {p.PaymentId} Student_ID: {p.StudentId} Amount: {p.Amount} Payment_Date: {p.PaymentDate} Payment_Type: {p.PaymentType}");
                Console.WriteLine();
                Thread.Sleep(10);
            }
        }


        public static void ReadAttendanceMethod()
        {
            using var context = new UniversityContext();


            var list = context.Attendances
                .ToList();

            foreach (var a in list)
            {
                Console.WriteLine($"\t\t|   Attendance_ID: {a.AttendanceId} Student_ID: {a.StudentId} Class_Date: {a.ClassDate} Status: {a.Status} Teacher_ID: {a.TeacherId}");
                Console.WriteLine();
                Thread.Sleep(10);
            }
        }


        public static void ReadExamsMethod()
        {
            using var context = new UniversityContext();


            var list = context.Exams
                .ToList();

            foreach (var e in list)
            {
                Console.WriteLine($"\t\t|   Exam_ID: {e.ExamId} Subject: {e.Subject} Exam_Date: {e.ExamDate} Teacher_ID: {e.TeacherId} Classroom_ID {e.ClassRoomId}");
                Console.WriteLine();
                Thread.Sleep(10);
            }
        }
    }


}