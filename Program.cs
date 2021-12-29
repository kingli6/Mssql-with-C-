using System;

namespace studentEFConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            DataAccess dataAccess = new DataAccess();

            dataAccess.RecreateDatabase();
            dataAccess.AddStudent();
            dataAccess.RemoveStudent(0);
        }
    }
}
