using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccessDataLayer
{
    public class clsLoginUserLogAccessLayer
    {
        public static int AddLoginUserLog(int UserID, DateTime DateLog)
        {
            int ID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connection);

            string query = @"
             INSERT INTO [dbo].[UsersLoginLog]
           ([Date]
           ,[UserID])
             VALUES
           (@Date
           ,@UserID)
            SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Date", DateLog);
            command.Parameters.AddWithValue("@UserID", UserID);

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
        public static DataTable LoginUserLogList()
        {
            DataTable dataTable = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connection);

            string query = @"select * from FullLoginUserInfoView;";

            SqlCommand command = new SqlCommand(query, connection);


            try
            {
                connection.Open();

                SqlDataReader result = command.ExecuteReader();


                if (result.HasRows)
                {
                    dataTable.Load(result);
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
