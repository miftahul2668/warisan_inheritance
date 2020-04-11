using System;

namespace program
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Aisyah", 21);
            person.GetNameAndAge();

            Teacher teacher = new Teacher("kamarudin", 38, 13355, "pemrogaman");
            teacher.GetNameAndAge();

            Student student = new Student("Hoiru Muflihun", 19, 2668, "mthulreal@gmail.com");
            student.GetNameAndAge();

            Console.ReadKey();

        }
    }
}