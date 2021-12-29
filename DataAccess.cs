using studentEFConsole.Data;
using studentEFConsole.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 Things to remember
    dotnet ef migrations add someName       -these two codes you could run in the begining
    dotnet ef database update
 
 
 */
namespace studentEFConsole
{
    class DataAccess
    {
       static  Context context = new Context();             //needed.   Needed to turn this into static to make something work..
        List<Student> studentsList = new List<Student>();   //maybe needed
          
        public void RecreateDatabase()      //we skip doing dotnet ef database update
        {
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
        }
        public void AddStudent()
        {
           
            Student student1 = new Student();
            student1.FirstName = "Imad";
            student1.LastName = "yousef";
            student1.Grade = 55;

            Student student2 = new Student();
            student2.FirstName = "Joe";
            student2.LastName = "Fisher";
            student2.Grade = -10;

            studentsList.Add(student1);
            studentsList.Add(student2);
            foreach (Student student in studentsList)
            {
                context.Students.Add(student);
            }
            context.SaveChanges();                  //this part is important everytime you do a change.
        }


        public void RemoveStudent(int id)
        {
            if (id < 0 || id == null || id > studentsList.Count)        //to catch errors
            {
                throw new ArgumentException("blblblblabb");
            }
            context.Students.Remove(studentsList[id]);
            //studentsList.RemoveAt(id);
            //for (int i = 0; i < studentsList.Count; i++)
            //{
            //    if (i== id)
            //    {

            //    }         
            //}
            context.SaveChanges();
        }
    }
}


