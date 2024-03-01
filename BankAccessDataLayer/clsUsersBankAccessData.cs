using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccessDataLayer
{
    public class clsUsersBankAccessData
    {
        public struct stUser
        {
            public string UserName;
            public string Password;
            public int Permissions;
            public int PersonID;
        }

            public static bool GetUserInfo(int ID,ref stUser User)
            {
                bool isFound = false;
                SqlConnection connection = new SqlConnection(clsDataAccessSettings.connection);

                string query = @"select * from Users where ID=@UserID;";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@UserID", ID);

                try
                {
                    connection.Open();

                    SqlDataReader result = command.ExecuteReader();

                    if (result.Read())
                    {
                        isFound = true;

                       User.UserName = (string)result["UserName"];
                       User.Password = (string)result["Password"];
                       User.Permissions = (int)result["Permissions"];
                       User.PersonID = (int)result["PersonID"];

                    }
                    else
                    {
                        // The record was not found
                        isFound = false;
                    }

                }

                catch (Exception ex)
                {
                    //Console.WriteLine("Error: " + ex.Message);

                }

                finally
                {
                    connection.Close();
                }


                return isFound;
            }

        public static bool GetUserInfoByUserName(ref int ID, ref stUser User,string UserName)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connection);

            string query = @"
                           SELECT *
                           FROM [dbo].[Users]
                           where UserName= @UserName;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserName", UserName);

            try
            {
                connection.Open();

                SqlDataReader result = command.ExecuteReader();

                if (result.Read())
                {
                    isFound = true;

                    ID = (int)result["ID"];

                    User.Password = (string)result["Password"];
                    User.Permissions = (int)result["Permissions"];
                    User.PersonID = (int)result["PersonID"];

                }
               

            }

            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);

            }

            finally
            {
                connection.Close();
            }


            return isFound;
        }

        public static bool IsUserExistingByID(int ID)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connection);

            string query = @"select Found=1 from Users where ID=@ID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", ID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                isFound = reader.HasRows;

            }

            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);

            }

            finally
            {
                connection.Close();
            }


            return isFound;
        }

        public static bool IsUserExistingByUserName(string UserName)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connection);

            string query = @"select Found=1 from Users where UserName=@UserName;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserName", UserName);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                isFound = reader.HasRows;

            }

            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);

            }

            finally
            {
                connection.Close();
            }


            return isFound;
        }

        public static DataTable GetUsersList()
        {
            DataTable dataTable = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connection);

            string query = @"Select * from FullUserInfoView;";

            SqlCommand command = new SqlCommand(query, connection);


            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dataTable.Load(reader);
                }
                else
                {
                    // The record was not found
                }

            }

            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);

            }

            finally
            {
                connection.Close();
            }


            return dataTable;
        }

        public static DataTable GetUserNamesList()
        {
            DataTable dataTable = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connection);

            string query = @"Select UserName from Users;";

            SqlCommand command = new SqlCommand(query, connection);


            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dataTable.Load(reader);
                }
                else
                {
                    // The record was not found
                }

            }

            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);

            }

            finally
            {
                connection.Close();
            }


            return dataTable;
        }

        public static int AddUser(stUser UserInfo)
            {
                int ID = -1;
                SqlConnection connection = new SqlConnection(clsDataAccessSettings.connection);

                string query = @"INSERT INTO [dbo].[Users]
                               ([UserName]
                               ,[Password]
                               ,[Permissions]
                               ,[PersonID])
                             VALUES
                          (@UserName,@Password, @Permissions, @PersonID);
                             SELECT SCOPE_IDENTITY();";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@UserName", UserInfo.UserName);
                command.Parameters.AddWithValue("@Password", UserInfo.Password);
                command.Parameters.AddWithValue("@Permissions", UserInfo.Permissions);
                command.Parameters.AddWithValue("@PersonID", UserInfo.PersonID);
    
                try
                {
                    connection.Open();

                    object result = command.ExecuteScalar();


                    if (result != null && int.TryParse(result.ToString(), out int insertedID))
                    {
                        ID = insertedID;
                    }
                }

                catch (Exception ex)
                {
                    //Console.WriteLine("Error: " + ex.Message);

                }

                finally
                {
                    connection.Close();
                }
                return ID;
            }
            public static bool DeleteUser(int UserID)
            {
                bool IsDeleted = false;
                SqlConnection connection = new SqlConnection(clsDataAccessSettings.connection);

                string query = @"DELETE FROM[dbo].[Users]
                               WHERE ID=@UserID";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@UserID", UserID);

                try
                {
                    connection.Open();

                    int RowEffected = command.ExecuteNonQuery();


                    if (RowEffected > 0)
                    {
                        IsDeleted = true;
                    }
                }

                catch (Exception ex)
                {
                    //Console.WriteLine("Error: " + ex.Message);

                }

                finally
                {
                    connection.Close();
                }


                return IsDeleted;
            }

        public static bool UpdateUser(int ID,stUser User)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connection);

            string query = @"UPDATE [dbo].[Users]
              SET [UserName] = @UserName
                 ,[Password] = @Password
                 ,[Permissions] = @Permissions
                 ,[PersonID] = @PersonID
                 WHERE ID=@ID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", ID);
            command.Parameters.AddWithValue("@UserName", User.UserName);
            command.Parameters.AddWithValue("@Password", User.Password);
            command.Parameters.AddWithValue("@Permissions", User.Permissions);
            command.Parameters.AddWithValue("@PersonID", User.PersonID);
           
            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                return false;
            }

            finally
            {
                connection.Close();
            }

            return (rowsAffected > 0);
        }

        public static bool Lgoin(string UserName,string Password)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connection);

            string query = @"select Found=1 from Users where UserName=@UserName  and Password=@Password;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                isFound = reader.HasRows;

            }

            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);

            }

            finally
            {
                connection.Close();
            }


            return isFound;
        }

        



    }
}