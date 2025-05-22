using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace KarateDataAccess
{
    public class PersonData
    {
        public static int Add(string firstName, string secondName, string thirdName, string lastName, string nationalNumber, int countryId, DateTime dateOfBirth, string email, string address, string phone, byte gender, string imagePath)
        {
            int newId = 0;
            string query = "insert into People (firstName,secondName,thirdName,lastName,nationalNumber,countryId,dateOfBirth,email,address,phone,gender,imagePath) values (@firstName,@secondName,@thirdName,@lastName,@nationalNumber,@countryId,@dateOfBirth,@email,@address,@phone,@gender,@imagePath) SELECT SCOPE_IDENTITY(); ";
            using (SqlConnection connection = new SqlConnection(SettingData.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@firstName", firstName);
                    command.Parameters.AddWithValue("@secondName", secondName);
                    command.Parameters.AddWithValue("@thirdName", !string.IsNullOrWhiteSpace(thirdName) ? thirdName : (object)DBNull.Value);
                    command.Parameters.AddWithValue("@lastName", lastName);
                    command.Parameters.AddWithValue("@nationalNumber", nationalNumber);
                    command.Parameters.AddWithValue("@countryId", countryId);
                    command.Parameters.AddWithValue("@dateOfBirth", dateOfBirth);
                    command.Parameters.AddWithValue("@email", !string.IsNullOrWhiteSpace(email) ? email : (object)DBNull.Value);
                    command.Parameters.AddWithValue("@address", address);
                    command.Parameters.AddWithValue("@phone", phone);
                    command.Parameters.AddWithValue("@gender", gender);
                    command.Parameters.AddWithValue("@imagePath", !string.IsNullOrWhiteSpace(imagePath) ? imagePath : (object)DBNull.Value);

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
        public static bool Update(int id, string firstName, string secondName, string thirdName, string lastName, string nationalNumber, int countryId, DateTime dateOfBirth, string email, string address, string phone, byte gender, string imagePath)
        {
            int RowsAffected = 0;
            string query = "update People set firstName = @firstName,secondName = @secondName,thirdName = @thirdName,lastName = @lastName,nationalNumber = @nationalNumber,countryId = @countryId,dateOfBirth = @dateOfBirth,email = @email,address = @address,phone = @phone,gender = @gender,imagePath = @imagePath  WHERE id=@id;";
            using (SqlConnection connection = new SqlConnection(SettingData.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@firstName", firstName);
                    command.Parameters.AddWithValue("@secondName", secondName);
                    command.Parameters.AddWithValue("@thirdName", !string.IsNullOrWhiteSpace(thirdName) ? thirdName : (object)DBNull.Value);
                    command.Parameters.AddWithValue("@lastName", lastName);
                    command.Parameters.AddWithValue("@nationalNumber", nationalNumber);
                    command.Parameters.AddWithValue("@countryId", countryId);
                    command.Parameters.AddWithValue("@dateOfBirth", dateOfBirth);
                    command.Parameters.AddWithValue("@email", !string.IsNullOrWhiteSpace(email) ? email : (object)DBNull.Value);
                    command.Parameters.AddWithValue("@address", address);
                    command.Parameters.AddWithValue("@phone", phone);
                    command.Parameters.AddWithValue("@gender", gender);
                    command.Parameters.AddWithValue("@imagePath", !string.IsNullOrWhiteSpace(imagePath) ? imagePath : (object)DBNull.Value);

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
        public static bool Get(int id, ref string firstName, ref string secondName, ref string thirdName, ref string lastName, ref string nationalNumber, ref int countryId, ref DateTime dateOfBirth, ref string email, ref string address, ref string phone, ref byte gender, ref string imagePath)
        {
            bool IsFound = false;
            string query = "select * from People  WHERE id=@id;";

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
                                firstName = (string)reader["firstName"];
                                secondName = (string)reader["secondName"];
                                thirdName = reader["thirdName"] != DBNull.Value ? (string)reader["thirdName"] : string.Empty;
                                lastName = (string)reader["lastName"];
                                nationalNumber = (string)reader["nationalNumber"];
                                countryId = (int)reader["countryId"];
                                dateOfBirth = (DateTime)reader["dateOfBirth"];
                                email = reader["email"] != DBNull.Value ? (string)reader["email"] : string.Empty;
                                address = (string)reader["address"];
                                phone = (string)reader["phone"];
                                gender = (byte)reader["gender"];
                                imagePath = reader["imagePath"] != DBNull.Value ? (string)reader["imagePath"] : string.Empty;


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
        public static bool Get(string nationalNumber, ref int personId, ref string firstName, ref string secondName, ref string thirdName, ref string lastName, ref DateTime dateOfBirth, ref byte gender, ref string address, ref string phone, ref string email, ref int countryId, ref string imagePath)
        {
            bool IsFound = false;
            string query = "select * from People  WHERE NationalNo=@NationalNo;";
            using (SqlConnection connection = new SqlConnection(SettingData.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NationalNo", nationalNumber);
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            IsFound = true;
                            personId = (int)reader["id"];
                            firstName = (string)reader["firstName"];
                            secondName = (string)reader["secondName"];
                            thirdName = reader["thirdName"] != DBNull.Value ? (string)reader["thirdName"] : string.Empty;
                            lastName = (string)reader["lastName"];
                            nationalNumber = (string)reader["nationalNumber"];
                            countryId = (int)reader["countryId"];
                            dateOfBirth = (DateTime)reader["dateOfBirth"];
                            email = reader["email"] != DBNull.Value ? (string)reader["email"] : string.Empty;
                            address = (string)reader["address"];
                            phone = (string)reader["phone"];
                            gender = (byte)reader["gender"];
                            imagePath = reader["imagePath"] != DBNull.Value ? (string)reader["imagePath"] : string.Empty;


                        }
                        else
                        {
                            IsFound = false;
                        }
                    }
                    catch (Exception ex) { GenericData.LogException(ex.Message, EventLogEntryType.Error); }
                }
            }

            return IsFound;
        }

        static public DataTable All()
        {
            return GenericData.All("select * from People");
        }
        static public bool Delete(int id)
        {
            return GenericData.Delete("delete People where id = @id", "@id", id);
        }
        static public bool Exist(int id)
        {
            return GenericData.Exist("select Found=1 from People where id= @id", "@id", id);
        }
        static public string GetNameCountryById(int id)
        {
            return GenericData.GetNameById("select Name from Countries where Id=@Id", "@Id", id);
        }
    }



}







