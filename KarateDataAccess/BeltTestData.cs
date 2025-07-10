using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace KarateDataAccess
{
    public static class BeltTestData
    {
        public static int Add(int rankId, int memberId, bool result, DateTime date, int testedByInstructorID, int paymentId)
        {
            int newId = 0;
            string query = "insert into BeltTests (rankId,memberId,result,date,testedByInstructorID,paymentId) values (@rankId,@memberId,@result,@date,@testedByInstructorID,@paymentId) SELECT SCOPE_IDENTITY(); ";
            using (SqlConnection connection = new SqlConnection(SettingData.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@rankId", rankId);
                    command.Parameters.AddWithValue("@memberId", memberId);
                    command.Parameters.AddWithValue("@result", result);
                    command.Parameters.AddWithValue("@date", date);
                    command.Parameters.AddWithValue("@testedByInstructorID", testedByInstructorID);
                    command.Parameters.AddWithValue("@paymentId", paymentId);

                    try
                    {
                        connection.Open();
                        object execResult = command.ExecuteScalar();
                        if (execResult != null && int.TryParse(execResult.ToString(), out int insertedID))
                        {
                            newId = insertedID;
                        }

                    }
                    catch (Exception ex) { GenericData.LogException(ex.Message, EventLogEntryType.Error); }
                }
            }

            return newId;
        }
        public static bool Update(int id, int rankId, int memberId, bool result, DateTime date, int testedByInstructorID, int paymentId)
        {
            int RowsAffected = 0;
            string query = "update BeltTests set rankId = @rankId,memberId = @memberId,result = @result,date = @date,testedByInstructorID = @testedByInstructorID,paymentId = @paymentId  WHERE id=@id;";
            using (SqlConnection connection = new SqlConnection(SettingData.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@rankId", rankId);
                    command.Parameters.AddWithValue("@memberId", memberId);
                    command.Parameters.AddWithValue("@result", result);
                    command.Parameters.AddWithValue("@date", date);
                    command.Parameters.AddWithValue("@testedByInstructorID", testedByInstructorID);
                    command.Parameters.AddWithValue("@paymentId", paymentId);

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
        public static bool Get(int id, ref int rankId, ref int memberId, ref bool result, ref DateTime date, ref int testedByInstructorID, ref int paymentId)
        {
            bool IsFound = false;
            string query = "select * from BeltTests  WHERE id=@id;";

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
                                rankId = (int)reader["rankId"];
                                memberId = (int)reader["memberId"];
                                result = (bool)reader["result"];
                                date = (DateTime)reader["date"];
                                testedByInstructorID = (int)reader["testedByInstructorID"];
                                paymentId = (int)reader["paymentId"];


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
            return GenericData.All("select * from view_BeltTests_Info");
        }
        static public bool Delete(int id)
        {
            return GenericData.Delete("delete BeltTests where id = @id", "@id", id);
        }
        static public bool Exist(int id)
        {
            return GenericData.Exist("select Found=1 from BeltTests where id= @id", "@id", id);
        }

        public static int GetBeltTestsCount()
        {
            return GenericData.GetFieldsCount("GetBeltTestsCount");
        }


    }


}

