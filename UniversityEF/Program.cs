using UniversityEF.CRUD;
using UniversityEF.Data;
using UniversityEF.LINQ;
using UniversityEF.Models;


class Program
{


    public static void ChooseMethod()
    {
        Console.WriteLine("\n\t\t\t\t\t       C# <Welcome To EF Core Project /> C#");
        Console.WriteLine();
        Console.WriteLine("\t\t\t\t\t\t<-------------------------------->");
        Console.WriteLine("\t\t\t\t\t\t<|Choose a method to execute:   |>");
        Console.WriteLine("\t\t\t\t\t\t<|                              |>");
        Console.WriteLine("\t\t\t\t\t\t<|1.     READ Method            |>");
        Console.WriteLine("\t\t\t\t\t\t<|2.     CREATE Method          |>");
        Console.WriteLine("\t\t\t\t\t\t<|3.     UPDATE Method          |>");
        Console.WriteLine("\t\t\t\t\t\t<|4.     DELETE Method          |>");
        Console.WriteLine("\t\t\t\t\t\t<|                              |>");
        Console.WriteLine("\t\t\t\t\t\t<|        LINQ Methods          |>");
        Console.WriteLine("\t\t\t\t\t\t<|                              |>");
        Console.WriteLine("\t\t\t\t\t\t<|5.     Student Attendances    |>");
        Console.WriteLine("\t\t\t\t\t\t<|6.     Student Payments       |>");
        Console.WriteLine("\t\t\t\t\t\t<|7.     Top Students           |>");
        Console.WriteLine("\t\t\t\t\t\t<|8.     Student Exam Grades    |>");
        Console.WriteLine("\t\t\t\t\t\t<|9.     Student Faculty Stats  |>");
        Console.WriteLine("\t\t\t\t\t\t<-------------------------------->\n");
        Console.Write("\t\t\t\t\t\t    Enter your choice (1-9): ");





        string? choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                Console.WriteLine();
                Console.WriteLine("\t\t\t\t\t\t    <----------------------->");
                Console.WriteLine("\t\t\t\t\t\t    <|  Which Read Method?  |>");
                Console.WriteLine("\t\t\t\t\t\t    <|                      |>");
                Console.WriteLine("\t\t\t\t\t\t    <|1. Read_Students      |>");
                Console.WriteLine("\t\t\t\t\t\t    <|2. Read_Teachers      |>");
                Console.WriteLine("\t\t\t\t\t\t    <|3. Read_Payments      |>");
                Console.WriteLine("\t\t\t\t\t\t    <|4. Read_Attendances   |>");
                Console.WriteLine("\t\t\t\t\t\t    <|5. Read_Exams         |>");
                Console.WriteLine("\t\t\t\t\t\t    <----------------------->\n");
                Console.Write("\t\t\t\t\t\t    Enter your choice (1-5): ");
                string? readChoice = Console.ReadLine();

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("\t\t\t\t\t\t\t Method executed!");
                Console.WriteLine();
                Console.WriteLine();

                switch (readChoice)
                {
                    case "1":
                        READ_Method.ReadAllMethod();
                        break;
                    case "2":
                        READ_Method.ReadTeacherMethod();
                        break;
                    case "3":
                        READ_Method.ReadPaymentsMethod();
                        break;
                    case "4":
                        READ_Method.ReadAttendanceMethod();
                        break;
                    case "5":
                        READ_Method.ReadExamsMethod();
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please select a number between 1 and 5.");
                        break;
                }
                break;
            case "2":
                CREATE_Method.CreateMethod();
                break;
            case "3":
                UPDATE_Method.UpdateMethod();
                break;
            case "4":
                DELETE_Method.DeleteMethod();
                break;


            case "5":
                Linq.StudentAttendances();
                break;
            case "6":
                Linq.StudentPayments();
                break;
            case "7":
                Linq.TopStudents();
                break;
            case "8":
                Linq.StudentExamGrades();
                break;
            case "9":
                Linq.FacultyStats();
                break;
            default:
                Console.WriteLine("Invalid choice. Please select a number between 1 and 6.");
                break;
        }
    }



}













