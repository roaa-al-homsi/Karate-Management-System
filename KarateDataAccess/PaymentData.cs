﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace KarateDataAccess
{
    public static class PaymentData
    {
        public static int Add(decimal amount, DateTime date, int memberId)
        {
            int newId = 0;
            string query = "insert into Payments (amount,date,memberId) values (@amount,@date,@memberId) SELECT SCOPE_IDENTITY(); ";
            using (SqlConnection connection = new SqlConnection(SettingData.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@amount", amount);
                    command.Parameters.AddWithValue("@date", date);
                    command.Parameters.AddWithValue("@memberId", memberId);

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
        public static bool Update(int id, decimal amount, DateTime date, int memberId)
        {
            int RowsAffected = 0;
            string query = "update Payments set amount = @amount,date = @date,memberId = @memberId  WHERE id=@id;";
            using (SqlConnection connection = new SqlConnection(SettingData.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@amount", amount);
                    command.Parameters.AddWithValue("@date", date);
                    command.Parameters.AddWithValue("@memberId", memberId);

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
        public static bool Get(int id, ref decimal amount, ref DateTime date, ref int memberId)
        {
            bool IsFound = false;
            string query = "select * from Payments  WHERE id=@id;";

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
                                amount = (decimal)reader["amount"];
                                date = (DateTime)reader["date"];
                                memberId = (int)reader["memberId"];


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
            return GenericData.All("select * from view_Payments_Info");
        }
        static public bool Delete(int id)
        {
            return GenericData.Delete("delete Payments where id = @id", "@id", id);
        }
        static public bool Exist(int id)
        {
            return GenericData.Exist("select Found=1 from Payments where id= @id", "@id", id);
        }

    }

}
