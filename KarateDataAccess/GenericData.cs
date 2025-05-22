using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace KarateDataAccess
{
    public static class GenericData
    {
        static public DataTable All(string query)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(SettingData.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {


                        using (SqlDataReader Reader = command.ExecuteReader())
                        {
                            if (Reader.HasRows)
                            {
                                dt.Load(Reader);
                            }
                        }
                    }
                }
            }
            catch (Exception ex) { LogException(ex.Message, EventLogEntryType.Error); }
            return dt;
        }
        static public bool Delete<T>(string query, string parameterName, T deleteBy)
        {
            int RowsAffected = 0;
            using (SqlConnection connection = new SqlConnection(SettingData.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue(parameterName, deleteBy);

                    try
                    {
                        connection.Open();
                        RowsAffected = command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        LogException(ex.Message, EventLogEntryType.Error);
                        return false;
                    }
                }
            }

            return RowsAffected > 0;
        }
        static public bool Exist<T>(string query, string parameterName, T parameterValue)
        {
            bool IsFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(SettingData.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue(parameterName, parameterValue);

                        connection.Open();
                        using (SqlDataReader Reader = command.ExecuteReader())
                        {
                            IsFound = Reader.HasRows;
                        }
                    }
                }

            }
            catch (Exception ex) { LogException(ex.Message, EventLogEntryType.Error); }
            return IsFound;

        }
        static public void LogException(string eventMessage, EventLogEntryType eventLogEntryType)
        {
            string sourceName = ConfigurationManager.AppSettings["SourceAppName"];
            try
            {
                if (!EventLog.SourceExists(sourceName))
                {
                    EventLog.CreateEventSource(sourceName, ConfigurationManager.AppSettings["EventLogName"]);

                }
                EventLog.WriteEntry(sourceName, eventMessage, eventLogEntryType);
            }
            catch (Exception ex)
            {
                EventLog.WriteEntry(sourceName, $"Exception in logException method is : {ex.Message}", EventLogEntryType.Error);

            }
        }
        static public string GetNameById(string query, string ParameterName, int ParameterValue)
        {
            string name = string.Empty;
            using (SqlConnection connection = new SqlConnection(SettingData.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue(ParameterName, ParameterValue);
                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            name = result.ToString();
                        }
                    }
                    catch (Exception ex) { }
                }
            }
            return name;
        }
    }

}














