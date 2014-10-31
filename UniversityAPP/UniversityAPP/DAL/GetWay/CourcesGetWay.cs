using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityAPP.DAL.DAO;

namespace UniversityAPP.DAL.GetWay
{
    class CourcesGetWay
    {
        private SqlConnection connection;
        private Coursce aCoursce;
        public string Save(Coursce aCoursce)
        {

            SqlConnection connection = new SqlConnection();
            string conn = @"server=BITM-401-PC28\SQLEXPRESS; database=University; integrated security=true";
            connection.ConnectionString = conn;
            connection.Open();
            string query = string.Format("INSERT INTO  Cources VALUES('{0}','{1}','{2}')", aCoursce.Code, aCoursce.Name, aCoursce.Cradit);
            SqlCommand command = new SqlCommand(query, connection);

            int affectedRows = command.ExecuteNonQuery();
            connection.Close();
            if (affectedRows > 0)
                return "Save success";
            return "Unsuccess";
        }


        public List<Coursce> GetAllCourse()
        {
            Coursce aCoursce;
            SqlConnection connection = new SqlConnection();
            string conn = @"server=BITM-401-PC28\SQLEXPRESS; database=University; integrated security=true";
            connection.ConnectionString = conn;
            connection.Open();
            string qurey = string.Format("SELECT * FROM Cources ");
            SqlCommand cmd = new SqlCommand(qurey, connection);
            SqlDataReader aReader = cmd.ExecuteReader();
            List<Coursce> courses = new List<Coursce>();
            bool HasRow = aReader.HasRows;

            if (HasRow)
            {
                while (aReader.Read())
                {

                    aCoursce = new Coursce();
                    aCoursce.Name = aReader[1].ToString();
                    courses.Add(aCoursce);
                }
                connection.Close();
            }
            return courses;
        }
    }
}
