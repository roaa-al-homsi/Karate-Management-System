using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace KarateDataAccess
{
    public static class MemberData
    {
        public static int Add(int personId, string emergencyContactInfo, int lastBeltRank, bool isActive)
        {
            int newId = 0;
            string query = "insert into Members (personId,emergencyContactInfo,lastBeltRank,isActive) values (@personId,@emergencyContactInfo,@lastBeltRank,@isActive) SELECT SCOPE_IDENTITY(); ";
            using (SqlConnection connection = new SqlConnection(SettingData.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@personId", personId);
                    command.Parameters.AddWithValue("@emergencyContactInfo", emergencyContactInfo);
                    command.Parameters.AddWithValue("@lastBeltRank", lastBeltRank);
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
        public static bool Update(int id, int personId, string emergencyContactInfo, int lastBeltRank, bool isActive)
        {
            int RowsAffected = 0;
            string query = "update Members set personId = @personId,emergencyContactInfo = @emergencyContactInfo,lastBeltRank = @lastBeltRank,isActive = @isActive  WHERE id=@id;";
            using (SqlConnection connection = new SqlConnection(SettingData.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@personId", personId);
                    command.Parameters.AddWithValue("@emergencyContactInfo", emergencyContactInfo);
                    command.Parameters.AddWithValue("@lastBeltRank", lastBeltRank);
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
        public static bool Get(int id, ref int personId, ref string emergencyContactInfo, ref int lastBeltRank, ref bool isActive)
        {
            bool IsFound = false;
            string query = "select * from Members  WHERE id=@id;";

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
                                emergencyContactInfo = (string)reader["emergencyContactInfo"];
                                lastBeltRank = (int)reader["lastBeltRank"];
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
            return GenericData.All("select * from view_Member_Info");
        }
        static public DataTable GetAllPeriodsHistoryForSpecificMember(int memberId)
        {
            return GenericData.GetAllBySpecificField("select * from SubscriptionPeriods where MemberId=@memberId", "@memberId", memberId);
        }
        static public DataTable GetAllTestsForSpecificMember(int memberId)
        {
            return GenericData.GetAllBySpecificField("select * from view_BeltTests_Info where [Member Id]=@memberId", "@memberId", memberId);
        }

        static public bool Delete(int id)
        {
            return GenericData.Delete("delete Members where id = @id", "@id", id);
        }
        static public bool Exist(int id)
        {
            return GenericData.Exist("select Found=1 from Members where id= @id", "@id", id);
        }

        static public bool ExistByPersonId(int personId)
        {
            return GenericData.Exist("select Found=1 from Members where PersonId= @personId", "@personId", personId);
        }





    }

}

