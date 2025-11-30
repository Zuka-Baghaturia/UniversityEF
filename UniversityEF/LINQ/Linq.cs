using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityEF.Data;
using UniversityEF.Models;

namespace UniversityEF.LINQ
{
    class Linq
    {
        public static void StudentAttendances()
        {
            using var context = new UniversityContext();

            var studentAttendances = context.Students
                .Select(s => new
                {
                    s.FirstName,
                    s.LastName,
                    s.Age,
                    s.Faculty.FacultyName,
                    Attendances = s.Attendances.Select(a => new
                    {
                        a.Status,
                        a.ClassDate
                    }).ToList()
                })
                .ToList();

            foreach (var item in studentAttendances)
            {
                Console.WriteLine($"Student: {item.FirstName} {item.LastName}"); 
                Console.WriteLine();
                Console.WriteLine($"Age: {item.Age}");
                Console.WriteLine();
                Console.WriteLine($"Faculty: {item.FacultyName}");
                Console.WriteLine();

                foreach (var attendance in item.Attendances)
                {
                    Console.WriteLine($"   Status: {attendance.Status}, Date: {attendance.ClassDate}");
                }

                Console.WriteLine("\n\n\n");
            }
        }


        public static void StudentPayments()
        {
            using var context = new UniversityContext();

            var studentPayments = context.Students
                .Select(s => new
                {
                    s.FirstName,
                    s.LastName,
                    s.Faculty.FacultyName,
                    Payments = s.Payments.Select(p => new
                    {
                        p.PaymentType,
                        p.Amount,
                        p.PaymentDate
                    }).ToList()
                })
                .ToList();

            foreach (var item in studentPayments)
            {
                Console.WriteLine($"Student: {item.FirstName} {item.LastName}");
                Console.WriteLine();
                Console.WriteLine($"FacultyName: {item.FacultyName}");
                Console.WriteLine();

                foreach (var type in item.Payments)
                {
                    Console.WriteLine($"   PaymentType: {type.PaymentType}");
                    Console.WriteLine($"   Amount: {type.Amount}");
                    Console.WriteLine($"   Date: {type.PaymentDate}");
                }

                Console.WriteLine("\n\n\n");
            }
        }


        public static void TopStudents()
        {
            using var context = new UniversityContext();

            var topStudents = context.Students
                .Where(s => s.Grades.Any(g => g.GradeValue > 85))
                .Select(s => new
                {
                    s.FirstName,
                    s.LastName,
                    s.Age,
                    Grades = s.Grades
                        .Where(g => g.GradeValue > 85)
                        .Select(g => g.GradeValue)
                        .ToList()
                })
                .OrderBy(s => s.Age)
                .ToList();

            foreach (var item in topStudents)
            {
                Console.WriteLine($"Students: {item.FirstName} {item.LastName}");
                Console.WriteLine($"Age: {item.Age}");

                foreach (var grade in item.Grades)
                {
                    Console.WriteLine($"Grade: {grade}");
                }
                Console.WriteLine();
            }
        }


        public static void StudentExamGrades()
        {
            using var context = new UniversityContext();

            var studentExamGrades = context.Students
                .Select(s => new
                {
                    s.FirstName,
                    s.LastName,
                    s.Age,
                    Exams = s.Grades.Select(g => new
                    {
                        SubjectName = g.Exam.Subject,
                        g.GradeValue
                    }).ToList()
                })
                .ToList();

            foreach (var item in studentExamGrades)
            {
                Console.WriteLine($"FirstName: {item.FirstName} {item.LastName}");
                Console.WriteLine($"Age: {item.Age}");

                foreach (var grade in item.Exams)
                {
                    Console.WriteLine($"SubjectName: {grade.SubjectName}");
                    Console.WriteLine($"GradeValue: {grade.GradeValue}");
                }

                Console.WriteLine("\n\n\n");
            }
        }


        public static void FacultyStats()
        {
            using var context = new UniversityContext();

            var facultyStats = context.Faculties
                .Select(f => new
                {
                    f.FacultyName,
                    StudentCount = f.Students.Count(),
                    AverageAge = f.Students.Average(s => s.Age),
                    TotalPayments = f.Students.Sum(s => s.Payments.Sum(p => p.Amount))
                })
                .ToList();

            foreach (var item in facultyStats)
            {
                Console.WriteLine($"FacultyName: {item.FacultyName}");
                Console.WriteLine($"StudentCount: {item.StudentCount}");
                Console.WriteLine($"AverageAge: {item.AverageAge}");
                Console.WriteLine($"TotalPayments: {item.TotalPayments}");
                Console.WriteLine();
            }
        }
    }
}
