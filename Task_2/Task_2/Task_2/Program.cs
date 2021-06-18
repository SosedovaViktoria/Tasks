using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Task_2
{

    class Program
    {
     
        static void Main()
        {
            
            List<Man> men = new List<Man>();
            men.Add(new Man() { LastName = "Диржинцев", FirstName = "Валентин", Age = 20, Weight = 20.5, Height = 120 }); ;
            men.Add(new Man() { LastName = "Плюшкин", FirstName = "Кузьма", Age = 32, Weight = 45.5, Height = 150 }); ;

            foreach (Man m in men)
            {

                Console.WriteLine(m.GetInfoMan());
            }
            Console.WriteLine("Добавим нового человека:");
            Add_man(men);
            foreach (Man m in men)
            {

                Console.WriteLine(m.GetInfoMan());
            }
            Console.ReadLine();
            List<Student> students = new List<Student>();
            Console.WriteLine("Добавим нового студента:");
            Add_stud(students);

            foreach (Student s in students)
            {

                Console.WriteLine(s.GetInfoStudent());
            }

        }
        public static bool IsAllLetters(string s)
        {
            foreach (char c in s)
            {
                if (!Char.IsLetter(c))
                    return false;
            }
            return true;
        }
        public static void Add_man(List<Man> men)
        {
            string[] words = Console.ReadLine().Split(' ');
            if (IsAllLetters(words[0]) == true && IsAllLetters(words[0]) == true)
            {
                if (int.Parse(words[2]) > 0 && int.Parse(words[2]) < 116 && double.Parse(words[3]) > 20 && double.Parse(words[3]) < 200)
                    men.Add(new Man()
                    {
                        LastName = words[0],
                        FirstName = words[1],
                        Age = int.Parse(words[2]),
                        Weight = double.Parse(words[3]),
                        Height = double.Parse(words[4])
                    });
                else
                {
                    Console.WriteLine("Введены некорректные данные!");
                }
            }
            else
            {
                Console.WriteLine("Для Фамилии/Имени вводить надо буквы!");
            }
        }
        public static void Add_stud(List<Student> students)
        {
            string[] words = Console.ReadLine().Split(' ');
            if (IsAllLetters(words[0]) == true && IsAllLetters(words[0]) == true)
            {
                if (int.Parse(words[2]) > 0 && int.Parse(words[2]) < 116 && double.Parse(words[3]) > 20 && double.Parse(words[3]) < 200)
                    students.Add(new Student()
                    {
                        LastName = words[0],
                        FirstName = words[1],
                        Age = int.Parse(words[2]),
                        Weight = double.Parse(words[3]),
                        Height = double.Parse(words[4]),
                        YearOfreceipt = int.Parse(words[5]),
                        Course = int.Parse(words[6]),
                        NumberGroup = int.Parse(words[7])
                    });
                else
                {
                    Console.WriteLine("Введены некорректные данные!");
                }
            }
            else
            {
                Console.WriteLine("Для Фамилии/Имени вводить надо буквы!");
            }
        }
    }

    class Man
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }

        public Man(string lastName, string firstName, int age, double weight, double height)
        {
            LastName = lastName;
            FirstName = firstName;
            Age = age;
            Weight = weight;
            Height = height;            
        }
        public Man() { }
        public string GetInfoMan()
        {
            return LastName + " " + FirstName + " "
                + Age + " " + Weight + " " + Height;
        }
     
    }
    class Student : Man
    {
        public int YearOfreceipt { get; set; }
        public int Course { get; set; }
        public int NumberGroup { get; set; }
        public Student(string LastName, string FirstName, int Age, float Weight, double Height, int yearOfreceipt, int course, int numbergroup)
       : base(LastName, FirstName, Age, Weight, Height)
        {
            YearOfreceipt = yearOfreceipt;
            Course = course;
            NumberGroup = numbergroup;
        }
        public Student() { }
        public string GetInfoStudent()
        {
            return LastName + " " + FirstName + " "
                + Age + " " + Weight + " " + Height + " " + YearOfreceipt + " " + Course + " " + NumberGroup;
        }
    }
  
   
}
