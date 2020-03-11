using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Web_Api_FrameWork.Models;

namespace Web_Api_FrameWork.Data
{
    public class StudentData
    {
        // creating an isntance of the model class......!!!!
        StudentModel student = new StudentModel();

        // connection string.................................!!@@...............//
        string ConnectionString = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
        public DataSet GetData() // method to fetching the data
        {
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand("select * from student", sqlConnection);

                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                return dataSet;

            }
        }
        public DataSet GetData(int id) // method to fetching the data of one student
        {
            StudentModel student = new StudentModel();
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand("select * from student where ROLL_No=" + id + " ", sqlConnection);

                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                return dataSet;

            }
        }
        public bool InsertData(StudentModel student) //method to insert the data of a student
        {
            try
            {


                SqlConnection sqlConnection = new SqlConnection(ConnectionString);
                sqlConnection.Open();
                SqlCommand command = new SqlCommand("insert into student(ROLL_NO,NAME,MARKS) values(@roll,@name,@marks)", sqlConnection);
                command.Parameters.AddWithValue("@roll", student.Roll_No);
                command.Parameters.AddWithValue("@name", student.NAME);
                command.Parameters.AddWithValue("@marks", student.MARKS);

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

        public bool UpdateData(int id, StudentModel student) //method to update a student's record
        {
            try
            {

                SqlConnection sqlConnection = new SqlConnection(ConnectionString);
                
                SqlCommand command = new SqlCommand("update student set NAME=@name where ROLL_NO="+id, sqlConnection);
                command.Parameters.AddWithValue("@id", student.Roll_No);
                command.Parameters.AddWithValue("@name", student.NAME);
                //command.Parameters.AddWithValue("@marks",student.MARKS);
                sqlConnection.Open();
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

        public bool DeleteData(int id) // student to delete a student record..
        { 
            try
            {
                StudentModel student = new StudentModel();
                SqlConnection sqlConnection = new SqlConnection(ConnectionString);
                sqlConnection.Open();
                SqlCommand command = new SqlCommand("delete from student where Roll_No=" + id + " ", sqlConnection);

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