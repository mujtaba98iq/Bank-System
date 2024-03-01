using System;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Security.Policy;
using System.Web;

namespace BankAccessDataLayer
{
    public class clsClientBankAccessData
    {
        public struct stClient
        {
           public int PersonID,  Balance;
            public string AccNumber, PinCode;
        }

        public static bool GetClientInfo(int ID,ref stClient Client)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connection);

            string query = @"select * from Clients where ID=@ID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", ID);

            try
            {
                connection.Open();

                 SqlDataReader result = command.ExecuteReader();

                if (result.Read())
                {
                    isFound = true; 

                    Client.AccNumber = (string)result["AccNumber"];
                    Client.Balance = (int)result["Balance"];
                    Client.PinCode = (string)result["PinCode"];
                    Client.PersonID = (int)result["PersonID"];             
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

        public static bool GetClientInfoByAccNumber(ref int ID, ref stClient Client)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connection);

            string query = @"select * from Clients where AccNumber=@AccNumber;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@AccNumber", Client.AccNumber);

            try
            {
                connection.Open();

                SqlDataReader result = command.ExecuteReader();

                if (result.Read())
                {
                    isFound = true;
                    ID = (int)result["ID"];
                    Client.AccNumber = (string)result["AccNumber"];
                    Client.Balance = (int)result["Balance"];
                    Client.PinCode = (string)result["PinCode"];
                    Client.PersonID = (int)result["PersonID"];
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

        public static string GetAccNumebrByID(int ID)
        {
            string AccNumber="";
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connection);

            string query = @"select AccNumber from Clients where ID=@ID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", ID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result!=null)
                {
                   AccNumber=result.ToString();
                }
                else
                {
                    // The record was not found
                    AccNumber = null;
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


            return AccNumber;
        }

        public static bool IsClientExistingByID(int ID)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connection);

            string query = @"select Found=1 from Clients where ID=@ID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", ID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                isFound= reader.HasRows;
              
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

        public static bool IsClientExistingByAccNumber(string AccNumber)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connection);

            string query = @"select Found=1 from Clients where AccNumber=@AccNumber;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@AccNumber", AccNumber);

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

        public static bool Login(string AccNumber,string PinCode)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connection);

            string query = @"select Found=1 from Clients where AccNumber=@AccNumber and PinCode=@PinCode;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@AccNumber", AccNumber);
            command.Parameters.AddWithValue("@PinCode", PinCode);

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

        public static int AddClient(stClient ClientInfo)
        {
            int ID=-1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connection);

            string query = @"INSERT INTO [dbo].[Clients]
           ([AccNumber]
           ,[Balance]
           ,[PinCode]
           ,[PersonID])
             VALUES
          (@AccNumber,@Balance, @PinCode,@PersonID);
           SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@AccNumber", ClientInfo.AccNumber);
            command.Parameters.AddWithValue("@Balance", ClientInfo.Balance);
            command.Parameters.AddWithValue("@PinCode", ClientInfo.PinCode);
            command.Parameters.AddWithValue("@PersonID", ClientInfo.PersonID);

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

      

        public static bool DeleteClient(int ClientID)
        {
            bool IsDeleted=false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connection);

            string query = @"DELETE FROM[dbo].[Clients]
                               WHERE ID=@ClientID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ClientID", ClientID);
        
            try
            {
                connection.Open();

                int RowEffected = command.ExecuteNonQuery();


                if (RowEffected>0)
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

        public static bool UpdateClient(int ID,stClient ClientInfo)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connection);

            string query = @"UPDATE [dbo].[Clients]
                      SET [AccNumber] =@AccNumber
                         ,[Balance] = @Balance
                         ,[PinCode] = @PinCode
                         ,[PersonID] = @PersonID
                    WHERE ID=@ID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", ID);
            command.Parameters.AddWithValue("@AccNumber", ClientInfo.AccNumber);
            command.Parameters.AddWithValue("@Balance", ClientInfo.Balance);
            command.Parameters.AddWithValue("@PinCode", ClientInfo.PinCode);
            command.Parameters.AddWithValue("@PersonID", ClientInfo.PersonID);
          
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

        public static bool Transfers(int IDFrom,int IDTo,int Ammont)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connection);

            string query = @"UPDATE [dbo].[Clients]
                       SET 
                       [Balance] = Balance-@Ammont  
                       WHERE ID=@ClientIDFrom
                       UPDATE [dbo].[Clients]
                       SET 
                       [Balance] = Balance+@Ammont   
                        WHERE ID=@ClienIDTO";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ClientIDFrom", IDFrom);
            command.Parameters.AddWithValue("@ClienIDTO", IDTo);
            command.Parameters.AddWithValue("@Ammont", Ammont);

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

        public static bool WithDraw(int ID, int Ammont)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connection);

            string query = @"UPDATE [dbo].[Clients]
                       SET 
                       [Balance] = Balance-@Ammont  
                       WHERE ID=@ClientID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ClientID", ID);
            command.Parameters.AddWithValue("@Ammont", Ammont);

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

        public static bool Deposit(int ID, int Ammont)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connection);

            string query = @"UPDATE [dbo].[Clients]
                       SET 
                       [Balance] = Balance+@Ammont  
                       WHERE ID=@ClientID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ClientID", ID);
            command.Parameters.AddWithValue("@Ammont", Ammont);

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

        public static DataTable GetClientsList()
        {
            DataTable dataTable = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connection);

            string query = @"select * from FullClientInfoView;";

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

        public static DataTable GetClientsIDsList()
        {
            DataTable dataTable = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connection);

            string query = @"select ID from Clients ;";

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

        public static DataTable GetClientsAccNumbersList()
        {
            DataTable dataTable = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connection);

            string query = @"select AccNumber from Clients ;";

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



    }
}
