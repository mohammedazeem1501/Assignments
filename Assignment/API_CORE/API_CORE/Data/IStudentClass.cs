using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_CORE.Model;
using API_CORE.Data;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Extensions.Options;

namespace API_CORE.Data
{
    public class IStudentClass:IStudent
    {
        Model.Student student = new Student();
        
        private readonly IOptions<Connection> _connection;


        public IStudentClass(IOptions<Connection> connection)
        {
            _connection = connection;
        }


        public DataSet GetData()
        {
            string con = _connection.Value.ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(con);
            SqlCommand command = new SqlCommand("select * from student", sqlConnection);

            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            return dataSet;

        }

        public DataSet GetDataId(int id)
        {
            string con = _connection.Value.ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(con);
            SqlCommand command = new SqlCommand("select * from student where ROLL_No=" + id, sqlConnection);

            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            return dataSet;
        }

        public bool InsertData(Student student)
        {
            string con = _connection.Value.ConnectionString;

            try
            {


                SqlConnection sqlConnection = new SqlConnection(con);
                sqlConnection.Open();
                SqlCommand command = new SqlCommand("insert into student(ROLL_No,NAME,MARKS) values(@roll,@name,@marks)", sqlConnection);
                command.Parameters.AddWithValue("@roll", student.Roll_No);
                command.Parameters.AddWithValue("@name", student.Name);
                command.Parameters.AddWithValue("@marks", student.Marks);

                int result = command.ExecuteNonQuery();
                sqlConnection.Close();
                if (result > 0)
                    return true;
                else
                    return false;

            }
            catch (Exception ex)
            {

                throw ex;

            }
            finally
            {

            }
        }

        public bool UpdateData(int id, Student student)
        {
            string con = _connection.Value.ConnectionString;

            try
            {
                SqlConnection sqlConnection = new SqlConnection(con);
                sqlConnection.Open();
                SqlCommand command = new SqlCommand("update student set NAME=@name where ROLL_No=  " + id, sqlConnection);

                command.Parameters.AddWithValue("@roll", student.Roll_No);
                command.Parameters.AddWithValue("@name", student.Name);


                int result = command.ExecuteNonQuery();
                sqlConnection.Close();
                if (result > 0)
                    return true;
                else
                    return false;

            }
            catch (Exception ex)
            {

                throw ex;

            }
            finally
            {

            }
        }

        public bool DeleteData(int id)
        {
            string con = _connection.Value.ConnectionString;
            try
            {
                Student student = new Student();
                SqlConnection sqlConnection = new SqlConnection(con);
                sqlConnection.Open();
                SqlCommand command = new SqlCommand("delete from student where ROLL_No=" + id + " ", sqlConnection);

                int result = command.ExecuteNonQuery();
                sqlConnection.Close();
                if (result > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
