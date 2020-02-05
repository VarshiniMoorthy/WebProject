using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
namespace WebApplication
{
    public class UserRespository
    {
        internal static void ExecuteInsert(User user)
        {
            try
            {

                using (SqlConnection sqlConn = new SqlConnection(Registeration.GetConnectionString()))
                {
                    SqlCommand sqlCmd = new SqlCommand("sp_RegisterationDetails", sqlConn);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    {
                        sqlCmd.Parameters.AddWithValue("@FirstName", Convert.ToString(user.FirstName));
                        sqlCmd.Parameters.AddWithValue("@LastName", Convert.ToString(user.LastName));
                        sqlCmd.Parameters.AddWithValue("@Age", Convert.ToInt16(user.Age));
                        sqlCmd.Parameters.AddWithValue("@SetPassword", Convert.ToString(user.SetPassword));
                        sqlCmd.Parameters.AddWithValue("@ConfirmPassword", Convert.ToString(user.ConfirmPassword));
                        sqlCmd.Parameters.AddWithValue("@Gender", Convert.ToString(user.Gender));
                        sqlCmd.Parameters.AddWithValue("@Email", Convert.ToString(user.Email));
                        sqlCmd.Parameters.AddWithValue("@LocationAddress", Convert.ToString(user.LocationAddress));
                        sqlCmd.Parameters.AddWithValue("@City", Convert.ToString(user.City));
                        sqlCmd.Parameters.AddWithValue("@Pincode", Convert.ToString(user.Pincode));
                        sqlConn.Open();
                        sqlCmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine("problem in opening connection" + exception.Message);
            }

        }
        internal void ExecuteLogin()
        {
            using (SqlConnection sqlConn = new SqlConnection(Registeration.GetConnectionString()))
            {
                SqlCommand sqlCmd = new SqlCommand("sp_RegisterationDetails", sqlConn);
                sqlCmd.CommandType = CommandType.StoredProcedure;
            }

    }

}