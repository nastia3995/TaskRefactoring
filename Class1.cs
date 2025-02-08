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
        public virtual void ShowInfo()
        {
            Console.WriteLine($"Name:{name}\nSurname:{surname}\nDate of birth: {birthDay}:{birthMonth}:{birthYear}");
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
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Final exam grade:{finalExamGrade}\nSchool grade:{schoolGrade}\nUniversity: {schoolName}");
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
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Course:{course}\n:Group: {group}\nFaculty: {faculty}\nUniversity: {universityName}");
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
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Position:{position}\n:Chair: {chair}\nUniversity: {universityName}\n");
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
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Reader card number:{idReaderCard}\n:Issue date: {issue}\nMonthly cost: {cost}\n");
        }
    }
}
