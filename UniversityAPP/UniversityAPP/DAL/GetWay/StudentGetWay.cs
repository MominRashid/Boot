using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityAPP.DAL.DAO;

namespace UniversityAPP.DAL.GetWay
{
    class StudentGetWay
    {
        public string Save(Student aStudent)
        {
            SqlConnection connection = new SqlConnection();
            string conn = @"server=BITM-401-PC28\SQLEXPRESS; database=University; integrated security=true";
            connection.ConnectionString = conn;
            connection.Open();
            string query = string.Format("INSERT INTO  Student VALUES('{0}','{1}','{2}')", aStudent.Regno,aStudent.Email,aStudent.Address);
            SqlCommand command = new SqlCommand(query, connection);

            int affectedRows = command.ExecuteNonQuery();
            connection.Close();
            if (affectedRows > 0)
                return "Save success";
            return "Unsuccess";
        }

        public List<Student> GetAllCourse()
        {
            Student aStudent;
            SqlConnection connection = new SqlConnection();
            string conn = @"server=BITM-401-PC28\SQLEXPRESS; database=University; integrated security=true";
            connection.ConnectionString = conn;
            connection.Open();
            string qurey = string.Format("SELECT * FROM Student ");
            SqlCommand cmd = new SqlCommand(qurey, connection);
            SqlDataReader aReader = cmd.ExecuteReader();
            List<Student> students = new List<Student>();
            bool HasRow = aReader.HasRows;

            if (HasRow)
            {
                while (aReader.Read())
                {

                    aStudent = new Student();
                    aStudent.Regno = aReader[1].ToString();
                    students.Add(aStudent);
                }
                connection.Close();
            }
            return students;
        }
    }
}
