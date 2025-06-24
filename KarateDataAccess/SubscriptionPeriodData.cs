using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace KarateDataAccess
{
    public static class SubscriptionPeriodData
    {
        public static int Add(DateTime startDate, DateTime endDate, decimal fees, int memberId, int paymentId, byte issueReason)
        {
            int newId = 0;
            string query = "insert into SubscriptionPeriods (startDate,endDate,fees,memberId,paymentId,issueReason) values (@startDate,@endDate,@fees,@memberId,@paymentId,@issueReason) SELECT SCOPE_IDENTITY(); ";
            using (SqlConnection connection = new SqlConnection(SettingData.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@startDate", startDate);
                    command.Parameters.AddWithValue("@endDate", endDate);
                    command.Parameters.AddWithValue("@fees", fees);
                    command.Parameters.AddWithValue("@memberId", memberId);
                    command.Parameters.AddWithValue("@paymentId", paymentId);
                    command.Parameters.AddWithValue("@issueReason", issueReason);
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
        public static bool Update(int id, DateTime startDate, DateTime endDate, decimal fees, int memberId, int paymentId, byte issueReason)
        {
            int RowsAffected = 0;
            string query = "update SubscriptionPeriods set startDate = @startDate,endDate = @endDate,fees = @fees,memberId = @memberId,paymentId = @paymentId ,issueReason=@issueReason WHERE id=@id;";
            using (SqlConnection connection = new SqlConnection(SettingData.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@startDate", startDate);
                    command.Parameters.AddWithValue("@endDate", endDate);
                    command.Parameters.AddWithValue("@fees", fees);
                    command.Parameters.AddWithValue("@memberId", memberId);
                    command.Parameters.AddWithValue("@paymentId", paymentId);
                    command.Parameters.AddWithValue("@issueReason", issueReason);
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
        public static bool Get(int id, ref DateTime startDate, ref DateTime endDate, ref decimal fees, ref int memberId, ref int paymentId, ref byte issueReason, ref bool isActive)
        {
            bool IsFound = false;
            string query = "select * from SubscriptionPeriods  WHERE id=@id;";

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
                                startDate = (DateTime)reader["startDate"];
                                endDate = (DateTime)reader["endDate"];
                                fees = (decimal)reader["fees"];
                                memberId = (int)reader["memberId"];
                                paymentId = (int)reader["paymentId"];
                                issueReason = (byte)reader["issueReason"];
                                isActive = (bool)reader["IsActive"];
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
            return GenericData.All("select * from view_SubscriptionPeriods_Info");
        }
        static public bool Delete(int id)
        {
            return GenericData.Delete("delete SubscriptionPeriods where id = @id", "@id", id);
        }
        static public bool Exist(int id)
        {
            return GenericData.Exist("select Found=1 from SubscriptionPeriods where id= @id", "@id", id);
        }


    }

}

