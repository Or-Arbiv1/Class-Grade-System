using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class_Grade_System
{
    public partial class StudentListForm : Form
    {
        private StudentList m_StudentList;
        public StudentListForm(StudentList i_StudentList)
        {
            InitializeComponent();
            m_StudentList = i_StudentList;
            initDataGrid();
        }

        private void SaveStudentbtn_Click(object sender, EventArgs e)
        {
            if (checkCreateStudentInput())
            {
                m_StudentList.AddStudent(StudentNametxtbox.Text, StudentLastNametxtbox.Text, StutentIDtxtbox.Text, StudentPhoneNumbertxtbox.Text);
                initDataGrid();
            }
            else
            {
                MessageBox.Show("Invalid input! Try again!");
            }
            resetStudentInput();
        }

        private void resetStudentInput()
        {
            StudentNametxtbox.Text = "";
            StudentLastNametxtbox.Text = "";
            StutentIDtxtbox.Text = "";
            StudentPhoneNumbertxtbox.Text = "";
        }

        private bool checkCreateStudentInput()
        {
            return checkIfAllLetters(StudentNametxtbox.Text) && checkIfAllLetters(StudentLastNametxtbox.Text) && checkIfAllDigits(StudentPhoneNumbertxtbox.Text) && checkIfAllDigits(StutentIDtxtbox.Text) && checkLength(StudentPhoneNumbertxtbox.Text, 10) && checkLength(StutentIDtxtbox.Text, 9);
        }

        private bool checkLength(string i_Input, int i_Length)
        {
            return i_Input.Length == i_Length ? true : false;
        }

        private bool checkIfAllDigits(string i_Input)
        {
            if (!string.IsNullOrEmpty(i_Input))
            {
                foreach (char charecter in i_Input)
                {
                    if (!Char.IsDigit(charecter))
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

        private void DeleteStudentbtn_Click(object sender, EventArgs e)
        {
            if (StudentDisplayGrid.SelectedRows.Count != 1)
            {
                MessageBox.Show("Please select 1 row at a time");
                return;
            }
            foreach (DataGridViewRow studentInfo in StudentDisplayGrid.SelectedRows)
            {
                m_StudentList.DeleteStudent(studentInfo.Index);
                initUI();
            }
        }

        private void initUI()
        {
            initDataGrid();
        }

        private void initDataGrid()
        {
            StudentDisplayGrid.Rows.Clear();
            foreach (KeyValuePair<string, Student> studentInfo in m_StudentList.AllStudentsInfo)
            {
                StudentDisplayGrid.Rows.Add(studentInfo.Value.FirstName, studentInfo.Value.LastName, studentInfo.Value.ID, studentInfo.Value.PhoneNumber);
            }
        }

        private void ShowStudentbtn_Click(object sender, EventArgs e)
        {
            if (StudentDisplayGrid.SelectedRows.Count != 1)
            {
                MessageBox.Show("Please select 1 row at a time");
                return;
            }
            else
            {
                foreach (DataGridViewRow studentInfo in StudentDisplayGrid.SelectedRows)
                {
                    StudentGradesForm studentGradeSheet = new StudentGradesForm(m_StudentList.GetStudentInfo(studentInfo.Index));
                    studentGradeSheet.Show();
                }
            }
        }
    }
}
