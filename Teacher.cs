using System;

namespace Teacher
{
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
}
