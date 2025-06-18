using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace KarateDataAccess
{
    public static class MemberInstructorsData
    {
        public static int Add(int memberId, int instructorId, DateTime assignDate)
        {
            int newId = 0;
            string query = "insert into MemberInstructors (memberId,instructorId,assignDate) values (@memberId,@instructorId,@assignDate) SELECT SCOPE_IDENTITY(); ";
            using (SqlConnection connection = new SqlConnection(SettingData.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@memberId", memberId);
                    command.Parameters.AddWithValue("@instructorId", instructorId);
                    command.Parameters.AddWithValue("@assignDate", assignDate);

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
        public static bool Update(int id, int memberId, int instructorId, DateTime assignDate)
        {
            int RowsAffected = 0;
            string query = @"update MemberInstructors set
               memberId = @memberId,
               instructorId = @instructorId,
               assignDate = @assignDate 
              WHERE id=@id;";
            using (SqlConnection connection = new SqlConnection(SettingData.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@memberId", memberId);
                    command.Parameters.AddWithValue("@instructorId", instructorId);
                    command.Parameters.AddWithValue("@assignDate", assignDate);

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
        public static bool Get(int id, ref int memberId, ref int instructorId, ref DateTime assignDate)
        {
            bool IsFound = false;
            string query = "select * from MemberInstructors  WHERE id=@id;";

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
                                memberId = (int)reader["memberId"];
                                instructorId = (int)reader["instructorId"];
                                assignDate = (DateTime)reader["assignDate"];


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
            return GenericData.All("select * from view_MembersInstructors_Info");
        }
        static public bool Delete(int id)
        {
            return GenericData.Delete("delete MemberInstructors where id = @id", "@id", id);
        }
        static public bool Exist(int id)
        {
            return GenericData.Exist("select Found=1 from MemberInstructors where id= @id", "@id", id);
        }
        static public DataTable GetAllMembersBySpecificInstructor(int instructorId)
        {
            return GenericData.GetAllBySpecificField("EXEC sp_GetMembersByInstructor @InstructorId", "@InstructorId", instructorId);
        }



    }


}

