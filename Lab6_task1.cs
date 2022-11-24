using System;
using System.Collections;
using System.Security.Cryptography;
using System.Text;


namespace Lab6
{
    public class Person: IComparable<Person>
    {
        private string surname;
        private int birth;
        private string status;
        
        public Person(string surname, int birth, string status)
        {
            this.surname = surname;
            this.birth = birth;
            this.status = status;

        }
        public string Surname 
        { 
            get 
            { return surname; } 
            set 
            { surname = value; } 
        }
        public int Birthday 
        { 
            get 
            { return birth; } 
            set 
            { birth = value; } 
        }
        public string Status 
        { 
            get
            { return status; } 
            set 
            { status = value; } 
        }
        public void Output()
        {
            string separator = new StringBuilder().Insert(0, "-", 50).ToString();
            Console.WriteLine(separator);
            Console.WriteLine($"Surname: {surname}\nDate of birth: {birth}\nStatus: {status}");
            Info();
        }
        public virtual void Info()
        {
            Console.WriteLine($"Current Age: {2022 - birth}");
        }
        public int CompareTo(Person person)
        {
            return this.Birthday.CompareTo(person.birth);
        }
    }
    public class Student : Person
    {
        private int mathMark;
        private int physicsMark;
        private int historyMark;

        public Student(string surname, int birthday, string status, int mathMark, int physicsMark, int historyMark) : base(surname, birthday, status)
        {
            this.mathMark = mathMark;
            this.physicsMark = physicsMark;
            this.historyMark = historyMark;
        }

        public int MathMark 
        { 
            get 
            { return mathMark; } 
            set 
            { mathMark = value; } 
        }
        public int PhysicsMark 
        {
            get 
            { return physicsMark; } 
            set 
            { physicsMark = value; } 
        }
        public int HistoryMark 
        { 
            get 
            { return historyMark; } 
            set 
            { historyMark = value; } 
        }

        public float averageMark()
        {
            return (mathMark + physicsMark + historyMark) / 3;
        }

        public override void Info()
        {
            base.Info();
            int maxMark = physicsMark;
            if (maxMark < mathMark)
            {
                maxMark = mathMark;
            }
            if (maxMark < historyMark)
            {
                maxMark = historyMark;
            }
            Console.WriteLine($"Maximal mark: {maxMark}");
            string separator = new StringBuilder().Insert(0, "-", 50).ToString();
            Console.WriteLine(separator);
        }
    }
    interface IComparer<person>
    {
        int Compare(person o1, person o2);
    }    
    public class Comparer: IComparer<Person>
    {
        public int Compare(Person p1, Person p2)
        {
            if (String.Compare(p1.Surname, p2.Surname) > 0)
                return 1;
            else if (String.Compare(p1.Surname, p2.Surname) < 0)
                return -1;
            else
                return 0;
        }
    }
    public class Program
    {
        private static void Main()
        {
            Person[] personArray = new Person[]
            {
                new Student("Zanko", 2002, "Student", 9, 7, 8),
                new Student("Einstein", 1879, "Student", 10, 10, 8),
                new Student("Belov", 1999, "Student", 4, 6, 7)
            };
          
            Console.WriteLine("Sorted by date of birth:");
            Array.Sort(personArray);
            foreach (Person person in personArray)
            {
                Console.WriteLine($"{person.Surname}, {person.Birthday}");
            }
            Console.WriteLine("\nSorted by surname:");
            Comparer personComparer = new Comparer();
            Array.Sort(personArray, personComparer.Compare);
            foreach (Person person in personArray)
            {
                Console.WriteLine($"{person.Surname}, {person.Birthday}");
            }
            
            foreach (Person person in personArray)
            {
                person.Output();
            }
        }
    }
}
