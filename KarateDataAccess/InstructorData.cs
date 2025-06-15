using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace KarateDataAccess
{
    public static class InstructorData
    {
        public static int Add(int personId, string qualifications)
        {
            int newId = 0;
            string query = "insert into Instructors (personId,qualifications) values (@personId,@qualifications) SELECT SCOPE_IDENTITY(); ";
            using (SqlConnection connection = new SqlConnection(SettingData.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@personId", personId);
                    command.Parameters.AddWithValue("@qualifications", qualifications);

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
        public static bool Update(int id, int personId, string qualifications)
        {
            int RowsAffected = 0;
            string query = "update Instructors set personId = @personId,qualifications = @qualifications  WHERE id=@id;";
            using (SqlConnection connection = new SqlConnection(SettingData.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@personId", personId);
                    command.Parameters.AddWithValue("@qualifications", qualifications);

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
        public static bool Get(int id, ref int personId, ref string qualifications)
        {
            bool IsFound = false;
            string query = "select * from Instructors  WHERE id=@id;";

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
                                qualifications = (string)reader["qualifications"];


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
            return GenericData.All("select * from view_Instructor_Info");
        }
        static public bool Delete(int id)
        {
            return GenericData.Delete("delete Instructors where id = @id", "@id", id);
        }
        static public bool Exist(int id)
        {
            return GenericData.Exist("select Found=1 from Instructors where id= @id", "@id", id);
        }

        static public bool ExistByPersonId(int personId)
        {
            return GenericData.Exist("select Found=1 from Instructors where PersonId= @personId", "@personId", personId);
        }
    }


}

