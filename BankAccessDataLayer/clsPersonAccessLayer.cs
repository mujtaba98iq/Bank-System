using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BankAccessDataLayer.clsClientBankAccessData;

namespace BankAccessDataLayer
{
    public class clsPersonAccessLayer
    {
        public struct stPerson
        {
            public string FirstName;
            public string LastName;
            public string Email;
            public string Phone;
            public string Address;
            public string Gendor;
            public DateTime DateOfBirth;
        }
        static public int AddPerson(stPerson PersonInfo)
        {
            int ID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connection);

            string query = @"INSERT INTO [dbo].[Persons]
           ([FirstName]
           ,[LastName]
           ,[Email]
           ,[Phone]
           ,[Address]
           ,[Gendor]
           ,[DateOfBirth])
             VALUES
          (@FirstName,@LastName, @Email,@Phone,@Address,@Gendor,@DateOfBirth);
           SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@FirstName", PersonInfo.FirstName);
            command.Parameters.AddWithValue("@LastName", PersonInfo.LastName);
            command.Parameters.AddWithValue("@Email", PersonInfo.Email);
            command.Parameters.AddWithValue("@Phone", PersonInfo.Phone);
            command.Parameters.AddWithValue("@Address", PersonInfo.Address);
            command.Parameters.AddWithValue("@Gendor", PersonInfo.Gendor);
            command.Parameters.AddWithValue("@DateOfBirth", PersonInfo.DateOfBirth);

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

        public static bool GetPersonInfo(int ID, ref stPerson PersonInfo)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connection);

            string query = @"select * from Persons where ID=@ID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", ID);

            try
            {
                connection.Open();

                SqlDataReader result = command.ExecuteReader();

                if (result.Read())
                {
                    isFound = true;

                    PersonInfo.FirstName = (string)result["FirstName"];
                    PersonInfo.LastName = (string)result["LastName"];
                    PersonInfo.Email = (string)result["Email"];
                    PersonInfo.Phone = (string)result["Phone"];
                    PersonInfo.Address = (string)result["Address"];
                    PersonInfo.Gendor = (string)result["Gendor"];
                    PersonInfo.DateOfBirth = (DateTime)result["DateOfBirth"];
                     
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

        public static bool UpdatePerson(int ID, stPerson Person)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connection);

            string query = @"UPDATE [dbo].[Persons]
             SET [FirstName] = @FirstName
                ,[LastName] = @LastName
                ,[Email] = @Email
                ,[Phone] = @Phone
                ,[Address] =@Address
                ,[Gendor] = @Gendor
                ,[DateOfBirth] = @DateOfBirth
                    WHERE ID=@ID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", ID);
            command.Parameters.AddWithValue("@FirstName",Person.FirstName);
            command.Parameters.AddWithValue("@LastName", Person.LastName);
            command.Parameters.AddWithValue("@Email", Person.Email);
            command.Parameters.AddWithValue("@Phone", Person.Phone);
            command.Parameters.AddWithValue("@Address", Person.Address);
            command.Parameters.AddWithValue("@Gendor",Person.Gendor);
            command.Parameters.AddWithValue("@DateOfBirth", Person.DateOfBirth);

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

        public static bool DeletePerson(int PersonID)
        {
            bool IsDeleted = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connection);

            string query = @"DELETE FROM[dbo].[Persons]
                               WHERE ID=@PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

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
    }
}
