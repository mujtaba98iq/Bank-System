using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccessDataLayer
{
    public class clsTransferLogBankAccessData
    {
        public static int AddTransferLog(string FromAccNumber, string ToAccNumber,
            int Ammont, DateTime DateTransfer)
        {
            int ID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connection);

            string query = @"
             INSERT INTO [dbo].[TransferLog]
           ([Date]
           ,[Amount]
           ,[FromAccNumber]
           ,[ToAccNumber])
            VALUES(@Date,@Amount,@FromAccNumber,@ToAccNumber);
            SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Date", DateTransfer);
            command.Parameters.AddWithValue("@Amount", Ammont);
            command.Parameters.AddWithValue("@FromAccNumber", FromAccNumber);
            command.Parameters.AddWithValue("@ToAccNumber", ToAccNumber);

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

        public static DataTable TransferLogList()
        {
            DataTable dataTable=new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connection);

            string query = @"select * from TransferLog;";

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
