using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class_Grade_System
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Data simulation
            Random rand = new Random();
            StudentList studentListFromDB = new StudentList();
            IDictionary<string, int> courses = new Dictionary<string, int>();
            courses.Add("Java", 5);
            courses.Add("Logic", 4);
            courses.Add("C++", 3);
            courses.Add("C#", 5);
            courses.Add("English", 2);
            studentListFromDB.AddStudent("Amir", "Sapir", "209101175", "0547938475");
            studentListFromDB.AddStudent("Shira", "Sapir", "409101175", "0537938475");
            studentListFromDB.AddStudent("Ami", "Sapir", "358746685", "0547788475");
            studentListFromDB.AddStudent("Gal", "Sapir", "379846685", "0547964475");
            foreach (KeyValuePair<string, Student> student in studentListFromDB.AllStudentsInfo)
            {
                foreach (KeyValuePair<string, int> entry in courses)
                {
                    float grade = (float)rand.NextDouble() + rand.Next(0, 100);
                    student.Value.AddCourse(entry.Key, entry.Value, grade);
                }
            }


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new StudentListForm(studentListFromDB));
        }
    }
}
