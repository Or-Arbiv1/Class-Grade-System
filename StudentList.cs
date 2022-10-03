using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class_Grade_System
{

    public class StudentList
    {
        private SortedList<string, Student> m_Students;

        public StudentList()
        {
            m_Students = new SortedList<string, Student>();
        }

        public SortedList<string, Student> AllStudentsInfo
        {
            get
            {
                return m_Students;
            }
        }


        public void AddStudent(string i_FirstName, string i_LastName, string i_ID, string i_PhoneNumber)
        {
            Student newStudent = new Student(i_FirstName, i_LastName, i_ID, i_PhoneNumber);
            if (!m_Students.ContainsKey(newStudent.ID))
            {
                m_Students.Add(newStudent.ID, newStudent);
            }
            else
            {
                MessageBox.Show("Invalid input! You alreay have a student with this ID in the system!");
            }
        }

        public void DeleteStudent(int i_Index)
        {
            int index = 0;
            while (index <= i_Index)
            {
                foreach (KeyValuePair<string, Student> studentInfo in m_Students.ToList())
                {
                    if (index == i_Index)
                    {
                        m_Students.Remove(studentInfo.Key);
                    }
                    index++;
                }
            }
        }

        public Student GetStudentInfo(int i_Index)
        {
            int index = 0;
            while (index <= i_Index)
            {
                foreach (KeyValuePair<string, Student> studentInfo in m_Students.ToList())
                {
                    if (index == i_Index)
                    {
                        return studentInfo.Value;
                    }
                    index++;
                }
            }
            return null;
        }

    }
}
