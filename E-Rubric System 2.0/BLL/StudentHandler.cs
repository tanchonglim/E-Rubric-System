using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using E_Rubric_System.DLL.ERSDataSetTableAdapters;
using System.Data;
using System.Collections;

namespace E_Rubric_System.BLL
{
    public class StudentHandler
    {
        private StudentTableAdapter sta;
        public StudentHandler()
        {
            sta = new StudentTableAdapter();
        }

        public Student getStudentByID(int studentID)
        {
            Student student = null;
            var result = sta.selectStudentByID(studentID);

            foreach(DataRow row in result)
            {
                var studentName = row["StudentName"].ToString();
                student = new Student();
                student.StudentName = studentName;
                student.StudentID = studentID;
            }
            return student;
        }

        public ArrayList getAllStudent()
        {
            ArrayList students = new ArrayList();
            Student student = null;
            var result = sta.selectAllStudent();

            foreach (DataRow row in result)
            {
                var studentName = row["StudentName"].ToString();
                var studentID = row["StudentID"].ToString();
                student = new Student();
                student.StudentName = studentName;
                student.StudentID = Int32.Parse(studentID);
                students.Add(student);
            }
            return students;
        }
    }
}