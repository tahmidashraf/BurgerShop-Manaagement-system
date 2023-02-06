using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseAccess.StorageData;
using System.Data;
using System.Data.SqlClient;

namespace DatabaseAccess.Operations
{
    public class OpSignUP
    {
        public bool status;
        SqlConnection conDta = new SqlConnection(@"Data Source=DESKTOP-19J1URI;Initial Catalog=BS;Integrated Security=True");

        public bool ConnectData1(StoreData str1) //Sign Up Query
        {
            try
            {
                string queryEmp1 = @"INSERT INTO [dbo].[bsSignUP]
               ([NAME]
               ,[EMAIL]
               ,[GENDER]
               ,[USERNAME]
               ,[PASSWORD])
            VALUES
            ('" + str1.FName + "', '" + str1.Email + "', '" + str1.Gender + "', '" + str1.UName + "', '" + str1.Password + "')";

                conDta.Open();
                SqlCommand cmdEmp1 = new SqlCommand(queryEmp1, conDta);
                cmdEmp1.ExecuteNonQuery();
                status = true;
                conDta.Close();
            }
            catch(Exception)
            {
                status = false;
            }

            return status;
        }

        public bool ConnectData2(StoreData str2) //Sign In Query
        {
            string queryEmp2 = @"SELECT USERNAME, PASSWORD FROM [dbo].[bsSignUP] WHERE USERNAME = @usr1 AND PASSWORD = @psd1 COLLATE SQL_Latin1_General_CP1_CS_AS";
            conDta.Open();
            SqlCommand cmdEmp2 = new SqlCommand(queryEmp2, conDta);
            cmdEmp2.Parameters.AddWithValue("@usr1", str2.UName);
            cmdEmp2.Parameters.AddWithValue("@psd1", str2.Password);
            SqlDataReader dr1 = cmdEmp2.ExecuteReader();

            if (dr1.HasRows.Equals(true))
            {
                status = true;
                conDta.Close();
            }
            else
            {
                status = false;
                conDta.Close();
            }

            return status;
        }

        public void ConnectData3(StoreData str3) //Update Password Query
        {
            string queryEmp3 = @"UPDATE [dbo].[bsSignUP] SET PASSWORD = @psd2 WHERE USERNAME = @usr2";
            conDta.Open();
            SqlCommand cmdEmp3 = new SqlCommand(queryEmp3, conDta);
            cmdEmp3.Parameters.AddWithValue("@psd2", str3.Password);
            cmdEmp3.Parameters.AddWithValue("@usr2", str3.UName);
            cmdEmp3.ExecuteNonQuery();
            conDta.Close();
        }

        public bool ConnectData4(StoreData str4)
        {
            try
            {
                string queryEmp4 = @"SELECT USERNAME FROM [dbo].[bsSignUP] WHERE USERNAME = @usr1 COLLATE SQL_Latin1_General_CP1_CS_AS";
                conDta.Open();
                SqlCommand cmdEmp4 = new SqlCommand(queryEmp4, conDta);
                cmdEmp4.Parameters.AddWithValue("@usr1", str4.UName);
                SqlDataReader dr1 = cmdEmp4.ExecuteReader();

                if (dr1.HasRows.Equals(true))
                {
                    status = true;
                    conDta.Close();
                }
                else
                {
                    conDta.Close();
                }
            }
            catch (Exception)
            {
                status = false;
            }

            return status;
        }

        public bool ConnectDataAdminSignIn(StoreData strAdm1)
        {
            string queryAd1 = @"SELECT USERNAME, PASSWORD FROM [dbo].[bsSignInAdmn] WHERE USERNAME = @usr1 AND PASSWORD = @psd1 COLLATE SQL_Latin1_General_CP1_CS_AS";
            conDta.Open();
            SqlCommand cmdAd1 = new SqlCommand(queryAd1, conDta);
            cmdAd1.Parameters.AddWithValue("@usr1", strAdm1.UName);
            cmdAd1.Parameters.AddWithValue("@psd1", strAdm1.Password);
            SqlDataReader dr1 = cmdAd1.ExecuteReader();

            if (dr1.HasRows.Equals(true))
            {
                status = true;
                conDta.Close();
            }
            else
            {
                status = false;
                conDta.Close();
            }

            return status;
        }
        public bool ConnectDataAdminUPas1(StoreData strAdm2)
        {
            string queryAd2 = @"SELECT USERNAME FROM [dbo].[bsSignInAdmn] WHERE USERNAME = @usr1 COLLATE SQL_Latin1_General_CP1_CS_AS";
            conDta.Open();
            SqlCommand cmdAd2 = new SqlCommand(queryAd2, conDta);
            cmdAd2.Parameters.AddWithValue("@usr1", strAdm2.UName);
            SqlDataReader dr1 = cmdAd2.ExecuteReader();

            if (dr1.HasRows.Equals(true))
            {
                status = true;
                conDta.Close();
                return status;
            }
            else
            {
                status = false;
                conDta.Close();
                return status;
            }
        }
        public void ConnectDataAdUPas2(StoreData strAdm3) //Update Password Query
        {
            string queryAd3 = @"UPDATE [dbo].[bsSignInAdmn] SET PASSWORD = @psd2 WHERE USERNAME = @usr2";
            conDta.Open();
            SqlCommand cmdAd3 = new SqlCommand(queryAd3, conDta);
            cmdAd3.Parameters.AddWithValue("@psd2", strAdm3.Password);
            cmdAd3.Parameters.AddWithValue("@usr2", strAdm3.UName);
            cmdAd3.ExecuteNonQuery();
            conDta.Close();
        }
    }
}
