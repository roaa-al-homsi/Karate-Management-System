using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace KarateDataAccess
{
    public static class UserData
    {
        public static int Add(int personId, string username, string password, bool isActive)
        {
            int newId = 0;
            string query = "insert into Users (personId,username,password,isActive) values (@personId,@username,@password,@isActive) SELECT SCOPE_IDENTITY(); ";
            using (SqlConnection connection = new SqlConnection(SettingData.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@personId", personId);
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);
                    command.Parameters.AddWithValue("@isActive", isActive);

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
        public static bool Update(int id, int personId, string username, string password, bool isActive)
        {
            int RowsAffected = 0;
            string query = "update Users set personId = @personId,username = @username,password = @password,isActive = @isActive  WHERE id=@id;";
            using (SqlConnection connection = new SqlConnection(SettingData.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@personId", personId);
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);
                    command.Parameters.AddWithValue("@isActive", isActive);

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
        public static bool Get(int id, ref int personId, ref string username, ref string password, ref bool isActive)
        {
            bool IsFound = false;
            string query = "select * from Users  WHERE id=@id;";
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
                                personId = (int)reader["personId"];
                                username = (string)reader["username"];
                                password = (string)reader["password"];
                                isActive = (bool)reader["isActive"];
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
            return GenericData.All("select * from view_User_Info");
        }
        static public bool Delete(int id)
        {
            return GenericData.Delete("delete Users where id = @id", "@id", id);
        }
        static public bool Exist(int id)
        {
            return GenericData.Exist("select Found=1 from Users where id= @id", "@id", id);
        }
        static public bool ExistByPersonId(int personId)
        {
            return GenericData.Exist("select Found=1 from Users where PersonId= @personId", "@personId", personId);
        }
        static public bool ChangePassword(int userId, string newPassword)
        {
            int rowsAffected = 0;
            string query = "update Users set Password=@newPassword WHERE id=@id;";
            using (SqlConnection connection = new SqlConnection(SettingData.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", userId);
                    command.Parameters.AddWithValue("@newPassword", newPassword);

                    try
                    {
                        connection.Open();
                        rowsAffected = command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        GenericData.LogException(ex.Message, EventLogEntryType.Error);
                    }
                }
            }

            return rowsAffected > 0;
        }
        public static bool GetByUsernameAndPassword(string username, string password, ref int id, ref int personId, ref bool isActive)
        {
            bool IsFound = false;
            string query = "select * from Users  WHERE Username=@username and Password=@password;";
            try
            {
                using (SqlConnection connection = new SqlConnection(SettingData.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", password);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsFound = true;
                                id = (int)reader["id"];
                                personId = (int)reader["personId"];
                                username = (string)reader["username"];
                                password = (string)reader["password"];
                                isActive = (bool)reader["isActive"];
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
        public static int GetUsersCount()
        {
            return GenericData.GetFieldsCount("GetUsersCount");
        }


    }

}

