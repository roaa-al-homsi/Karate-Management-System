using KarateBusiness;
using Microsoft.Win32;
using System;
using System.Windows.Forms;

namespace KarateSystem.GlobalClasses
{
    internal class LoginUser
    {
        public static User CurrentUser;
        public const string path = @"HKEY_CURRENT_USER\SOFTWARE\Karate";
        public const string UsernameKarate = "Username";
        public const string PasswordKarate = "Password";

        public static bool RememberUsernameAndPassword(string username, string password)
        {
            #region Save them to Registry file.

            try
            {
                //write to Registry file.
                Registry.SetValue(path, UsernameKarate, username, RegistryValueKind.String);
                Registry.SetValue(path, PasswordKarate, password, RegistryValueKind.String);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                return false;
            }
            #endregion
        }

        public static bool GetStoredCredential(ref string username, ref string password)
        {
            //this will get the stored username and password and will return true if found and false if not found from file.

            #region Get from Registry file.
            try
            {
                username = Registry.GetValue(path, UsernameKarate, null) as string;
                password = Registry.GetValue(path, PasswordKarate, null) as string;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                return false;
            }
            #endregion

        }
    }
}
