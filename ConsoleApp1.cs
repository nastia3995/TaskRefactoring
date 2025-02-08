using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ConsoleApp1
{
    class Program
    {
static Student EnterStudentInfo()
        {
            Console.Write("Enter name of the student:"); string Name = Console.ReadLine();
            Console.Write("Enter surname of the student:"); string Surname = Console.ReadLine();
            Console.Write("Enter day of birth of the student:"); int.TryParse(Console.ReadLine(), out int birthday);
            Console.Write("Enter month of birth of the student:"); int.TryParse(Console.ReadLine(), out int birthMonth);
            Console.Write("Enter year of birth of the student:"); int.TryParse(Console.ReadLine(), out int birthYear);
            Console.Write("Enter year of studying of the student:"); int.TryParse(Console.ReadLine(), out int course);
            Console.Write("Enter name of the group of the student:"); string group = Console.ReadLine();
            Console.Write("Enter name of the faculty of the student:"); string faculty = Console.ReadLine();
            Console.Write("Enter name of the university of the student:"); string universityName = Console.ReadLine();
            Student student = new Student(Name, Surname, birthday, birthMonth, birthYear, course, group, faculty, universityName);
            return student;
        }
        static Applicant EnterApplicantInfo()
        {
            Console.Write("Enter name of the applicant:"); string Name = Console.ReadLine();
            Console.Write("Enter surname of the applicant:"); string Surname = Console.ReadLine();
            Console.Write("Enter day of birth of the applicant:"); int.TryParse(Console.ReadLine(), out int birthday);
            Console.Write("Enter month of birth of the applicant:"); int.TryParse(Console.ReadLine(), out int birthMonth);
            Console.Write("Enter year of birth of the applicant:"); int.TryParse(Console.ReadLine(), out int birthYear);
            Console.Write("Enter the ZNO grade of the applicant:"); int.TryParse(Console.ReadLine(), out int FinalExamGrade);
            Console.Write("Enter the number of points for a document about education of the applicant:"); int.TryParse(Console.ReadLine(), out int schoolGrade);
            Console.Write("Enter name of the school of the applicant:"); string schoolName = Console.ReadLine();
            Applicant applicant = new Applicant(Name, Surname, birthday, birthMonth, birthYear,  FinalExamGrade, schoolGrade, schoolName );
            return applicant;
        }
        static Professor EnterProfessorInfo()
        {
            Console.Write("Enter name of the profesor:"); string Name = Console.ReadLine();
            Console.Write("Enter surname of the professor:"); string Surname = Console.ReadLine();
            Console.Write("Enter day of birth of the professor:"); int.TryParse(Console.ReadLine(), out int birthday);
            Console.Write("Enter month of birth of the professor:"); int.TryParse(Console.ReadLine(), out int birthMonth);
            Console.Write("Enter year of birth of the professor:"); int.TryParse(Console.ReadLine(), out int birthYear);
            Console.Write("Enter the position name of the professor:"); string position = Console.ReadLine();
            Console.Write("Enter the chair name of the professor"); string chair = Console.ReadLine();
            Console.Write("Enter name of the university of the professor:"); string university = Console.ReadLine();
            Professor professor = new Professor(Name, Surname, birthday, birthMonth, birthYear, position, chair, university );
            return professor;
        }
        static LibraryUser EnterLibraryUserInfo()
        {
            Console.Write("Enter name of the library user:"); string Name = Console.ReadLine();
            Console.Write("Enter surname of the library user:"); string Surname = Console.ReadLine();
            Console.Write("Enter day of birth of the library user:"); int.TryParse(Console.ReadLine(), out int birthday);
            Console.Write("Enter month of birth of the library user:"); int.TryParse(Console.ReadLine(), out int birthMonth);
            Console.Write("Enter year of birth of the library user:"); int.TryParse(Console.ReadLine(), out int birthYear);
            DateTime issue;
            string issuestr;
            do
            {
                Console.Write("Enter issue date in format dd.mm.yyyy (day.month.year):");
                issuestr = Console.ReadLine();
            }
            while (!DateTime.TryParseExact(issuestr, "dd.MM.yyyy", null, DateTimeStyles.None, out issue));
            Console.Write("Enter reader card id:"); int.TryParse(Console.ReadLine(), out int idReaderCard);
            Console.Write("Enter monthly cost of the library:"); int.TryParse(Console.ReadLine(), out int cost);
            LibraryUser lUser = new LibraryUser(Name, Surname, birthday, birthMonth, birthYear, idReaderCard, issue, cost);
            return lUser;
        }
        static void Main(string[] args)
        {
            Applicant applicant = new Applicant();
            Student student = new Student();
            Professor professor = new Professor();
            LibraryUser libraryUser = new LibraryUser();
            int n;
            do
            {
                Console.Write("Enter 1 to enter applicant info\nEnter 2 to enter student info\nEnter 3 to enter professor`s info\n" +
                    "Enter 4 to enter info about library user\nEnter 5 to see applicant info\nEnter 6 to see student info\nEnter 7 to see professor info\n" +
                    "Enter 8 to see library user info\nEnter 0 to exit\n");
               
                int.TryParse(Console.ReadLine(), out n);
                switch (n)
                {
                    case 0: break;
                    case 1:
                        applicant = EnterApplicantInfo();
                        break;
                    case 2:
                        student = EnterStudentInfo();
                        break;
                    case 3:
                        professor = EnterProfessorInfo();
                        break;
                    case 4:
                        libraryUser = EnterLibraryUserInfo();
                        break;
                    case 5:
                        applicant.ShowInfo();
                        break;
                    case 6:
                        student.ShowInfo();
                        break;
                    case 7:
                        professor.ShowInfo();
                        break;
                    case 8:
                        libraryUser.ShowInfo();
                        break;
                }
            } while (n != 0);
        }
    }

}
 


