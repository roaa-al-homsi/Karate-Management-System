using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;


namespace KarateDataAccess
{
    public static class BeltRankData
    {
        public static int Add(string name, decimal testFees)
        {
            int newId = 0;
            string query = "insert into BeltRanks (name,testFees) values (@name,@testFees) SELECT SCOPE_IDENTITY(); ";
            using (SqlConnection connection = new SqlConnection(SettingData.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@testFees", testFees);

                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            newId = insertedID;
                        }

                    }
                    catch (Exception ex) { GenericData.LogException(ex.Message, EventLogEntryType.Error); }
                }
            }

            return newId;
        }
        public static bool Update(int id, string name, decimal testFees)
        {
            int RowsAffected = 0;
            string query = "update BeltRanks set name = @name,testFees = @testFees  WHERE id=@id;";
            using (SqlConnection connection = new SqlConnection(SettingData.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@testFees", testFees);

                    try
                    {
                        connection.Open();
                        RowsAffected = command.ExecuteNonQuery();
                    }
                    catch (Exception ex) { GenericData.LogException(ex.Message, EventLogEntryType.Error); }
                }
            }

            return RowsAffected > 0;
        }
        public static bool Get(int id, ref string name, ref decimal testFees)
        {
            bool IsFound = false;
            string query = "select * from BeltRanks  WHERE id=@id;";

            try
            {
                using (SqlConnection connection = new SqlConnection(SettingData.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);


                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsFound = true;
                                id = (int)reader["id"];
                                name = (string)reader["name"];
                                testFees = (decimal)reader["testFees"];


                            }
                            else
                            {
                                IsFound = false;
                            }
                        }
                    }
                }
            }
            catch (Exception ex) { GenericData.LogException(ex.Message, EventLogEntryType.Error); }
            return IsFound;
        }

        static public DataTable All()
        {
            return GenericData.All("select * from BeltRanks");
        }
        static public bool Delete(int id)
        {
            return GenericData.Delete("delete BeltRanks where id = @id", "@id", id);
        }
        static public bool Exist(int id)
        {
            return GenericData.Exist("select Found=1 from BeltRanks where id= @id", "@id", id);
        }


    }


}
