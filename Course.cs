using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Grade_System
{
    public class Course
    {
        private readonly string r_Name;
        private readonly int r_Credit;
        private float m_FinalGrade;

        public Course(string i_Name, int i_Credit, float i_FinalGrade)
        {
            r_Name = i_Name;
            r_Credit = i_Credit;
            m_FinalGrade = i_FinalGrade;
        }

        public string Name
        {
            get
            {
                return r_Name;
            }
        }

        public int Credit
        {
            get
            {
                return r_Credit;
            }
        }

        public float FinalGrade
        {
            get
            {
                return m_FinalGrade;
            }
        }
    }
}
