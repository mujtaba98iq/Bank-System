using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BankAccessDataLayer.clsUsersBankAccessData;
using static BankAccessDataLayer.clsClientBankAccessData;

namespace BankAccessDataLayer
{
    public class clsCurrenciesAccessLayer
    {
        public struct stCurrecncyInfo
        {
            public decimal Rate;
            public string CountryName;
            public string CurrencyName;
        }

        public static bool GetCurrencyInfoByCurrencyCode(string CurrencyCode, ref stCurrecncyInfo CurrencyInfo)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connection);

            string query = @"select * from temp where CurrencyCode=@CurrencyCode;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@CurrencyCode", CurrencyCode);

            try
            {
                connection.Open();

                SqlDataReader result = command.ExecuteReader();

                if (result.Read())
                {
                    isFound = true;

                    CurrencyInfo.CurrencyName = (string)result["CurrencyName"];
                    CurrencyInfo.CountryName = (string)result["CountryName"];
                    CurrencyInfo.Rate = (decimal)result["Rate"];

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
        public static DataTable GetCurrenciessList()
        {
            DataTable dataTable = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connection);

            string query = @"select * from temp;";

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

        public static DataTable GetCurrenciessCodeList()
        {
            DataTable dataTable = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connection);

            string query = @"select CurrencyCode from temp;";

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
        public static bool UpdateCurrency(string CurrencyCode, decimal UpdatedRate)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connection);

            string query = @"UPDATE [dbo].[temp]
                      SET [Rate] =@UpdatedRate
                    WHERE CurrencyCode=@CurrencyCode";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@CurrencyCode", CurrencyCode);
            command.Parameters.AddWithValue("@UpdatedRate", UpdatedRate);

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

    }
}
