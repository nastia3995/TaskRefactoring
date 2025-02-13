using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Person
    {
        private string name;
        private string surname;
        private int birthDay;
        private int birthMonth;
        private int birthYear;
        public Person()
        {
        }
        public Person(string Name, string Surname, int BirthDate, int BirthMonth, int BirthYear)
        {
            name = Name;
            surname = Surname;
            birthDay = BirthDate;
            birthMonth = BirthMonth;
            birthYear = BirthYear;
        }
        public Person(string Name, string Surname)
        {
            name = Name;
            surname = Surname;
        }
        public string Name
        {
            set
            {
                if (value != null || value.Length > 2)
                {
                    name = value;
                }
            }
            get
            {
                return name;
            }
        }
        public string Surname
        {
            set
            {
                if (value != null || value.Length > 2)
                {
                    surname = value;
                }
            }
            get
            {
                return surname;
            }
        }
        public int BirthDay
        {
            set
            {
                if (value != 0)
                {
                    birthDay = value;
                }
            }
            get
            {
                return birthDay;
            }
        }
        public int BirthMonth
        {
            set
            {
                if (value != 0)
                {
                    birthMonth = value;
                }
            }
            get
            {
                return birthMonth;
            }
        }
        public int BirthYear
        {
            set
            {
                if (value != 0)
                {
                    birthYear = value;
                }
            }
            get
            {
                return birthYear;
            }
        }
    }
    public class Applicant:Person
    {
        private int finalExamGrade;
        private double schoolGrade;
        private string schoolName;
        public Applicant()
        {

        }
        public Applicant(string Name, string Surname, int BirthDate, int BirthMonth, int BirthYear, int FinalExamGrade, double SchoolGrade, string SchoolName):base(Name, Surname, BirthDate, BirthYear, BirthMonth)
        {
            finalExamGrade = FinalExamGrade;
            schoolGrade = SchoolGrade;
            schoolName = SchoolName;
        }
        public Applicant(int FinalExamGrade)
        {
            finalExamGrade = FinalExamGrade;
        }    
        public int FinalExamGrade
        {
            set { if(value>0&&value<201)
                    finalExamGrade=value;
                        }
            get { return finalExamGrade; }
        }
        public double SchoolGrade
        {
            set
            {
                if (value > 0 && value <=12)
                
                    schoolGrade=value;
                
            }
            get { return schoolGrade; }
        }
        public string SchoolName
        {
            set { if(value != null)
                    schoolName=value;}
            get
            {
                return schoolName;
            }
        }
    }
    public class Student : Person
    {
        private int course;
        private string group;
        private string faculty;
        private string universityName;
        public Student()
        {

        }
        public Student(string Name, string Surname, int BirthDate, int BirthMonth, int BirthYear, int course, string group, string faculty, string universityName) : base(Name, Surname, BirthDate, BirthYear, BirthMonth)
        {
            this.course = course;
            this.group = group;
            this.faculty = faculty;
            this.universityName = universityName;
            
        }
        public Student(int course)
        {
            this.course=course;
        }
        public int Course
        {
            set
            {
                if(value>0&&value<7) course = value;
            }
            get
            {
                return course;
            }
        }
        public string Group
        {
            set { group = value; }
            get
            {
                return group;
            }
        }
        public string Faculty { set { faculty = value; }
            get
            {return faculty;
            }
        }
        public string UniversityName
        {
            set { universityName = value; }
            get
            {
                return universityName;
            }
        }
    }
    
    public class Professor : Person
    {
        private string position;
        private string chair;
        private string universityName;
        public Professor()
        {

        }
        public Professor(string Name, string Surname, int BirthDate, int BirthMonth, int BirthYear, string position, string chair, string universityName) : base(Name, Surname, BirthDate, BirthYear, BirthMonth)
        {
            
            this.position = position;
            this.chair = chair;
            this.universityName = universityName;

        }
        public Professor(string position)
        {
            this.position = position;
        }
        public string Position
        {
            set
            {
                 position = value;
            }
            get
            {
                return position;
            }
        }
        public string Chair
        {
            set { chair = value; }
            get
            {
                return chair;
            }
        }
        public string UniversityName
        {
            set { universityName = value; }
            get
            {
                return universityName;
            }
        }
    }
    public class LibraryUser : Person
    {
 
        public LibraryUser() { }
        public LibraryUser(string Name, string Surname, int BirthDate, int BirthMonth, int BirthYear, int idReaderCard, DateTime issue, int cost):base(Name, Surname, BirthDate, BirthMonth, BirthYear) 
        {
            this.idReaderCard = idReaderCard;
            this.cost = cost;
            this.issue = issue;
        }
        public int idReaderCard
        {
            set;get;
        }
        public DateTime issue { set; get; }
        public int cost {  set; get; }
    }
    public static class UserInput
{
    public static string GetString(string message)
    {
        Console.Write(message);
        return Console.ReadLine();
    }

    public static int GetInt(string message)
    {
        int value;
        while (true)
        {
            Console.Write(message);
            if (int.TryParse(Console.ReadLine(), out value))
                return value;
            Console.WriteLine("Ошибка: введите целое число!");
        }
    }

    public static DateTime GetDate(string message)
    {
        DateTime date;
        while (true)
        {
            Console.Write(message);
            string input = Console.ReadLine();
            if (DateTime.TryParseExact(input, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
                return date;
            Console.WriteLine("Ошибка: введите дату в формате dd.MM.yyyy!");
        }
    }
}
public static class DataValidator
{
    public static bool IsValidName(string name)
    {
        return !string.IsNullOrWhiteSpace(name) && name.Length >= 2;
    }
}
public static class EntityFactory
{
    public static Student CreateStudent()
    {
        string name = UserInput.GetString("Enter name of the student: ");
        string surname = UserInput.GetString("Enter surname of the student: ");
        int birthday = UserInput.GetInt("Enter day of birth: ");
        int birthMonth = UserInput.GetInt("Enter month of birth: ");
        int birthYear = UserInput.GetInt("Enter year of birth: ");
        int course = UserInput.GetInt("Enter year of studying: ");
        string group = UserInput.GetString("Enter name of the group: ");
        string faculty = UserInput.GetString("Enter name of the faculty: ");
        string university = UserInput.GetString("Enter name of the university: ");
        return new Student(name, surname, birthday, birthMonth, birthYear, course, group, faculty, university);
    }

    public static Applicant CreateApplicant()
    {
        string name = UserInput.GetString("Enter name of the applicant: ");
        string surname = UserInput.GetString("Enter surname of the applicant: ");
        int birthday = UserInput.GetInt("Enter day of birth: ");
        int birthMonth = UserInput.GetInt("Enter month of birth: ");
        int birthYear = UserInput.GetInt("Enter year of birth: ");
        int finalExamGrade = UserInput.GetInt("Enter the ZNO grade: ");
        int schoolGrade = UserInput.GetInt("Enter the number of points for a document: ");
        string schoolName = UserInput.GetString("Enter name of the school: ");
        return new Applicant(name, surname, birthday, birthMonth, birthYear, finalExamGrade, schoolGrade, schoolName);
    }

    public static Professor CreateProfessor()
    {
        string name = UserInput.GetString("Enter name of the professor: ");
        string surname = UserInput.GetString("Enter surname of the professor: ");
        int birthday = UserInput.GetInt("Enter day of birth: ");
        int birthMonth = UserInput.GetInt("Enter month of birth: ");
        int birthYear = UserInput.GetInt("Enter year of birth: ");
        string position = UserInput.GetString("Enter position: ");
        string chair = UserInput.GetString("Enter chair name: ");
        string university = UserInput.GetString("Enter university name: ");
        return new Professor(name, surname, birthday, birthMonth, birthYear, position, chair, university);
    }

    public static LibraryUser CreateLibraryUser()
    {
        string name = UserInput.GetString("Enter name of the library user: ");
        string surname = UserInput.GetString("Enter surname of the library user: ");
        int birthday = UserInput.GetInt("Enter day of birth: ");
        int birthMonth = UserInput.GetInt("Enter month of birth: ");
        int birthYear = UserInput.GetInt("Enter year of birth: ");
        DateTime issueDate = UserInput.GetDate("Enter issue date (dd.MM.yyyy): ");
        int idReaderCard = UserInput.GetInt("Enter reader card id: ");
        int cost = UserInput.GetInt("Enter monthly cost: ");
        return new LibraryUser(name, surname, birthday, birthMonth, birthYear, idReaderCard, issueDate, cost);
    }
}
}
