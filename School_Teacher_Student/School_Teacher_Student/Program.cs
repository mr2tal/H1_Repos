using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Teacher_Student
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            menu.PrintMenu();

            //List<Teacher> teacherList = new List<Teacher>();
            //Teacher t1 = new Teacher("jan", 40, Person.SchoolType.College);
            //Teacher t2 = new Teacher("Bo", 39, Person.SchoolType.HighSchool);
            //Teacher t3 = new Teacher("flemming", 30, Person.SchoolType.University);
            //Teacher t4 = new Teacher("John", 45, Person.SchoolType.PrimarySchool);
            //teacherList.Add(t1);
            //teacherList.Add(t2);
            //teacherList.Add(t3);
            //teacherList.Add(t4);
            //t1.MakeStudent("niels", 29, Person.SchoolType.HighSchool);
            //t1.MakeStudent("mark", 21, Person.SchoolType.College);
            //t2.MakeStudent("Joakim", 24, Person.SchoolType.HighSchool);
            //t2.MakeStudent("Oliver", 22, Person.SchoolType.HighSchool);
            //t3.MakeStudent("Patrick", 19, Person.SchoolType.University);
            //t3.MakeStudent("Jonas", 27, Person.SchoolType.University);
            //t4.MakeStudent("Mikkel", 25, Person.SchoolType.PrimarySchool);
            //t4.MakeStudent("alex", 17, Person.SchoolType.PrimarySchool);

            //Console.WriteLine("Teacher: {0}", t1.GetName());
            //t1.PrintStudents();

            //Console.WriteLine("Teacher: {0}", t2.GetName());
            //t2.PrintStudents();

            //Console.WriteLine("Teacher: {0}", t3.GetName());
            //t3.PrintStudents();

            //Console.WriteLine("Teacher: {0}", t4.GetName());
            //t4.PrintStudents();
            //t1.GetStudent(0).Skipping();
            //t1.GetStudent(0).Skipping();
            //t1.GetStudent(0).Skipping();
            //t1.GetStudent(0).Skipping();

            //t3.GetStudent(0).Criticize(t3);
        }
    }
    class School
    {
        List<Teacher> teacherList = new List<Teacher>();
        public void SetTeacherList()
        {
            Teacher t1 = new Teacher("jan", 40, Person.SchoolType.College);
            Teacher t2 = new Teacher("Bo", 39, Person.SchoolType.HighSchool);
            Teacher t3 = new Teacher("flemming", 30, Person.SchoolType.University);
            Teacher t4 = new Teacher("John", 45, Person.SchoolType.PrimarySchool);
            teacherList.Add(t1);
            teacherList.Add(t2);
            teacherList.Add(t3);
            teacherList.Add(t4);
        }
        public Teacher GetTeacher(int i)
        {
            return teacherList[i];
        }
    }
    class Menu : School
    {
        int teacherChoice = 0;
        public void PrintMenu()
        {
            SetTeacherList();
            while (true)
            {
                Console.WriteLine("Welcome to school system");
                Console.WriteLine("Enter your choice");
                Console.WriteLine("Teacher choice:{0}",GetTeacher(teacherChoice).GetName());
                Console.WriteLine("1. Choose teacher");
                Console.WriteLine("2. Create student");
                Console.WriteLine("3. Print out students");
                Console.WriteLine("8. exit");
                string inputMenu = Console.ReadLine();
                MenuChoice(inputMenu);
               
            }
        }
        public void MenuChoice(string input)
        {
            switch (input)
            {
                case "1":
                    Console.WriteLine("Input index of teacher");
                    Console.WriteLine("0. {0}", GetTeacher(0));
                    Console.WriteLine("1. {0}", GetTeacher(1));
                    Console.WriteLine("2. {0}", GetTeacher(2));
                    Console.WriteLine("3. {0}", GetTeacher(3));
                    String inputTeacher = Console.ReadLine();
                    if (int.TryParse(inputTeacher, out int i) && i <= 3 && i >= 0)
                    {
                        teacherChoice = i;
                    }else
                    {
                        Console.WriteLine("invalid input");
                    }
                    break;
                case "2":
                    Console.WriteLine("Input Name");
                    string inputN = Console.ReadLine();
                    Console.WriteLine("Input Age");
                    string inputA = Console.ReadLine();
                    Console.WriteLine("Input School");
                    string inputS = Console.ReadLine();
                    Enum.TryParse<Person.SchoolType>(inputS, out Person.SchoolType s);
                    GetTeacher(teacherChoice).MakeStudent(inputN, int.Parse(inputA), s);

                    break;
                case "3":
                    GetTeacher(teacherChoice).PrintStudents();
                    break;
                case "8":
                    System.Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Choose valid input");
                    break;
            }
        }
        
    }
    abstract class Person
    {
        //fields
        private string _Name;
        private int _Age;
        public enum SchoolType
        {
            PrimarySchool,
            HighSchool,
            College,
            University
        }
        private SchoolType _School;
        //getset methods
        public string GetName()
        {
            return _Name;
        }
        public void SetName(string n)
        {
            _Name = n;
        }
        public int GetAge()
        {
            return _Age;
        }
        public void SetAge(int a)
        {
            _Age = a;
        }
        public SchoolType GetSchool()
        {
            return _School;
        }
        public void SetSchool(SchoolType s)
        {
            _School = s;
        }
        //Constructor
        public Person()
        {

        }
        public Person(string n, int a, SchoolType s)
        {
            SetName(n);
            SetAge(a);
            SetSchool(s);
        }
        //override
        public override string ToString()
        {
            return string.Format("name: {0}, age: {1}, school: {2}", GetName(), GetAge(), GetSchool());
        }

      
    }

    class Teacher : Person
    {
        List<Student> teacherStudent = new List<Student>();


        //Constructor
        public Teacher()
        {

        }
        public Teacher (string n, int a, SchoolType s) : base(n, a, s)
        {

        }

        //methods
        public void MakeStudent (string n, int a , SchoolType s)
        {
            if (this.GetSchool() == s)
            {
                teacherStudent.Add(new Student(n, a, s, 0));
            }else
            {
                Console.WriteLine("{0} not attending teacher {1} class in school: {2}", n ,this.GetName(), this.GetSchool());
            }
        }

        public void PrintStudents()
        {
            foreach (Student item in teacherStudent)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public Student GetStudent(int i)
        {
            return teacherStudent[i];
        }

    }
    interface IStudent
    {
      
        void Skipping();

        void Criticize(Teacher t);

        void Sleep();

    }
    class Student : Person, IStudent
    {
        //Fields
        private int _Absence;

        //getset methods
        public int GetAbsence()
        {
            return _Absence;
        }
        public void SetAbsence(int a)
        {
            _Absence = a;
        }

        //Constructor
        public Student (string n, int a, SchoolType s, int abs) : base(n, a, s)
        {
            SetAbsence(abs);
        }

        //interface methods
        public void Skipping()
        {
            SetAbsence(GetAbsence() + 1);
            Console.WriteLine("{0} is skipping class in {1} and has been absent {2} times", GetName(), GetSchool(), GetAbsence());
        }

        public void Criticize(Teacher t)
        {
            Console.WriteLine("{0} is criticizeing {1}", GetName(), t.GetName());
        }
        public void Sleep()
        {
            Console.WriteLine("{0} is sleeping", GetName());
        }

    }
}
