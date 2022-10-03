using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Grade_System
{
    public class Student
    {
        private readonly string r_FirstName;
        private readonly string r_LastName;
        private readonly string r_ID;
        private readonly string r_PhoneNumber;
        SortedList<float, List<Course>> m_Grades;

        public Student(string i_FirstName, string i_LastName, string i_ID, string i_PhoneNumber)
        {
            r_FirstName = i_FirstName;
            r_LastName = i_LastName;
            r_ID = i_ID;
            r_PhoneNumber = i_PhoneNumber;
            m_Grades = new SortedList<float, List<Course>>();
        }

        public string FirstName
        {
            get
            {
                return r_FirstName;
            }
        }

        public string LastName
        {
            get
            {
                return r_LastName;
            }
        }

        public string ID
        {
            get
            {
                return r_ID;
            }
        }

        public string PhoneNumber
        {
            get
            {
                return r_PhoneNumber;
            }
        }

        public SortedList<float, List<Course>> CoursesInfo
        {
            get
            {
                return m_Grades;
            }
        }

        public void AddCourse(string i_Name, int i_Credit, float i_FinalGrade)
        {
            Course newCourse = new Course(i_Name, i_Credit, i_FinalGrade);
            if (!m_Grades.ContainsKey(newCourse.FinalGrade))
            {
                m_Grades.Add(newCourse.FinalGrade, new List<Course>());
            }
            m_Grades[newCourse.FinalGrade].Add(newCourse);
        }

        public string GetLowestGrade()
        {
            float gradeToReturn = 0;
            if (m_Grades.Keys.Count > 0)
            {
                gradeToReturn = m_Grades.Keys.First();
            }
            return gradeToReturn.ToString();
        }

        public string GetHighestGrade()
        {
            float gradeToReturn = 0;
            if (m_Grades.Keys.Count > 0)
            {
                gradeToReturn = m_Grades.Keys.Last();
            }
            return gradeToReturn.ToString();
        }

        public string GetAvgGrade()
        {
            int creditCounter = 0;
            float avgScore = 0;
            float totalAvg = 0;
            foreach (KeyValuePair<float, List<Course>> courseInfo in m_Grades)
            {
                foreach (Course course in courseInfo.Value)
                {
                    avgScore += course.Credit * course.FinalGrade;
                    creditCounter += course.Credit;
                }
            }
            if (creditCounter > 0)
            {
                totalAvg = (avgScore / creditCounter);
            }
            return totalAvg.ToString();
        }

        public void DeleteCourse(int i_Index)
        {
            int index = 0;
            while (index <= i_Index)
            {
                foreach (KeyValuePair<float, List<Course>> courseInfo in m_Grades.ToList())
                {
                    foreach (Course course in courseInfo.Value.ToList())
                    {
                        if (index == i_Index)
                        {
                            courseInfo.Value.Remove(course);
                            if (m_Grades[courseInfo.Key].Count == 0)
                            {
                                m_Grades.Remove(courseInfo.Key);
                            }
                        }
                        index++;
                    }
                }
            }
        }
    }
}