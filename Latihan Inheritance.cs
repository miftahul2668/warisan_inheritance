using System;

namespace Latihan_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Aisyah",21);
            person.GetNameAndAge();

            Teacher teacher = new Teacher("kamarudin",38,13355, "pemrogaman");
            teacher.GetNameAndAge();

            Student student = new Student("Hoiru Muflihun",19,2668, "mthulreal@gmail.com");
            student.GetNameAndAge();

            Console.ReadKey();

        }

        internal class Person
        {
            private string nama;
            private int usia;
            private int ID;
            private string Status;
            private string Email;

            public void GetNameAndAge() => Console.WriteLine("Nama: {0},usia: {1} ", nama, usia, ID, Status, Email);
            public Person(string nama, int usia)
            {
                this.nama = nama;
                this.usia = usia;
            }
        }

        internal class Teacher
        {
            private string nama;
            private int usia;
            private int ID;
            private string Status;

            public void GetNameAndAge() => Console.WriteLine("Nama: {0},Usia: {1},ID: {2},Anda Mengajar: {3} ", nama, usia, ID, Status);
            public Teacher(string nama, int usia, int ID, string Status)
            {
                this.nama = nama;
                this.usia = usia;
                this.ID = ID;
                this.Status = Status;
            }
        }

        internal class Student
        {
            private string nama;
            private int usia;
            private int ID;
            private string Email;

            public void GetNameAndAge() => Console.WriteLine("Nama: {0},usia: {1},ID: {2},Email: {3} ", nama, usia, ID, Email);
            public Student(string nama, int usia, int ID, string Email)
            {
                this.nama = nama;
                this.usia = usia;
                this.ID = ID;
                this.Email = Email;
            }
        }

    }
}