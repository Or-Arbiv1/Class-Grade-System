using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class_Grade_System
{
    public partial class StudentGradesForm : Form
    {
        private Student m_SelectedStudent;
        public StudentGradesForm(Student i_SelectedStudent)
        {
            InitializeComponent();
            m_SelectedStudent = i_SelectedStudent;
            this.Text = "Grades Sheet " + m_SelectedStudent.FirstName + " " + m_SelectedStudent.LastName;
            initUI();
        }

        private void initUI()
        {
            initDataGrid();
            initStudentStatistics();
        }

        private void initStudentStatistics()
        {
            LowestGradeValuelbl.Text = m_SelectedStudent.GetLowestGrade();
            HighestGradeValuelbl.Text = m_SelectedStudent.GetHighestGrade();
            AvgGradeValuelbl.Text = m_SelectedStudent.GetAvgGrade();
        }

        private void initDataGrid()
        {
            GradeDisplayGrid.Rows.Clear();
            foreach (KeyValuePair<float, List<Course>> courseInfo in m_SelectedStudent.CoursesInfo)
            {
                foreach (Course course in courseInfo.Value)
                {
                    GradeDisplayGrid.Rows.Add(course.Name, course.FinalGrade, course.Credit);
                }
            }

        }

        private void SaveCoursebtn_Click(object sender, EventArgs e)
        {
            if (!(checkIfAllLetters(CourseNametxtbox.Text) && checkGrade(CourseGradetxtbox.Text) && checkCredit(CourseCredittxtbox.Text)))
            {
                MessageBox.Show("Invalid input! Try again");
            }
            else
            {
                float grade = float.Parse(CourseGradetxtbox.Text, CultureInfo.InvariantCulture.NumberFormat);
                int credit = Convert.ToInt32(CourseCredittxtbox.Text);
                m_SelectedStudent.AddCourse(CourseNametxtbox.Text, credit, grade);
                initUI();
            }
            resetCourseInput();

        }

        private bool checkIfAllLetters(string i_Input)
        {
            if (!string.IsNullOrEmpty(i_Input))
            {
                foreach (char charecter in i_Input)
                {
                    if (!Char.IsLetter(charecter) && charecter != ' ')
                    {
                        return false;
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        private void resetCourseInput()
        {
            CourseGradetxtbox.Text = "";
            CourseCredittxtbox.Text = "";
            CourseNametxtbox.Text = "";
        }

        private bool checkCredit(string i_Number)
        {
            if (!string.IsNullOrEmpty(i_Number))
            {
                foreach (char character in i_Number)
                {
                    if (!Char.IsNumber(character))
                    {
                        return false;
                    }
                }
                return checkRanges(2, 8, float.Parse(i_Number, CultureInfo.InvariantCulture.NumberFormat));
            }
            return false;
        }

        private bool checkIfFloat(string i_Number)
        {
            bool sawADot = false;
            if (!string.IsNullOrEmpty(i_Number))
            {
                foreach (char character in i_Number)
                {
                    if (!((character == '.' && !sawADot) || Char.IsNumber(character)))
                    {
                        return false;
                    }
                    if (character == '.')
                    {
                        sawADot = true;
                    }
                }
                return true;
            }
            return false;
        }

        private bool checkRanges(float i_LowerBound, float i_HigherBound, float i_Number)
        {
            return (i_LowerBound <= i_Number && i_HigherBound >= i_Number) ? true : false;
        }

        private bool checkGrade(string i_Grade)
        {
            if (!checkIfFloat(i_Grade))
            {
                return false;
            }
            return checkRanges(0, 100, float.Parse(i_Grade, CultureInfo.InvariantCulture.NumberFormat));
        }

        private void CancelCoursebtn_Click(object sender, EventArgs e)
        {
            resetCourseInput();
        }

        private void DeleteCoursebtn_Click(object sender, EventArgs e)
        {
            if (GradeDisplayGrid.SelectedRows.Count != 1)
            {
                MessageBox.Show("Please select 1 row at a time");
                return;
            }
            foreach (DataGridViewRow courseInfo in GradeDisplayGrid.SelectedRows)
            {
                m_SelectedStudent.DeleteCourse(courseInfo.Index);
                initUI();
            }
        }
    }


}
