using System;

namespace person
{
    
        internal class Person
        {
            private string nama;
            private int usia;
            private int ID;
            private string Status;
            private string Email;

            public void GetNameAndAge() => Console.WriteLine("Nama: {0},Usia: {1} ", nama, usia, ID, Status, Email);
            public Person(string nama, int usia)
            {
                this.nama = nama;
                this.usia = usia;
            }
        }
    
}