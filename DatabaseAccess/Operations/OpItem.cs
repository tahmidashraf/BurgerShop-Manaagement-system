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
    public class OpItem
    {
        public bool existId;
        SqlConnection conItm = new SqlConnection(@"Data Source=DESKTOP-19J1URI;Initial Catalog=BS;Integrated Security=True");
         
        public bool ConnectAddItem(StoreItem strItm1)
        {
            try
            {
                string queryItm1 = @"INSERT INTO [dbo].[ItemList]
           ([ID]
           ,[CATEGORY]
           ,[ITEMNAME]
           ,[PRICE])
     VALUES
           (@id, @cat, @itm, @prc)";
                conItm.Open();
                SqlCommand cmd1 = new SqlCommand(queryItm1, conItm);
                cmd1.Parameters.AddWithValue("@id", strItm1.ItemId);
                cmd1.Parameters.AddWithValue("@cat", strItm1.ItemCategory);
                cmd1.Parameters.AddWithValue("@itm", strItm1.ItemName);
                cmd1.Parameters.AddWithValue("@prc", strItm1.ItemPrice);
                cmd1.ExecuteNonQuery();
                existId = true;
                conItm.Close();
            }
            catch(Exception)
            {
                existId = false;
            }
            return existId;
        }

        public void ConnectUpdateItem(StoreItem strItm2)
        {
            string queryItm3 = @"UPDATE [dbo].[ItemList]
                   SET [CATEGORY] = @cat
                      ,[ITEMNAME] = @itm
                      ,[PRICE] = @prc
                 WHERE [ID] = @id";
            conItm.Open();
            SqlCommand cmd2 = new SqlCommand(queryItm3, conItm);
            cmd2.Parameters.AddWithValue("@id", strItm2.ItemId);
            cmd2.Parameters.AddWithValue("@cat", strItm2.ItemCategory);
            cmd2.Parameters.AddWithValue("@itm", strItm2.ItemName);
            cmd2.Parameters.AddWithValue("@prc", strItm2.ItemPrice);
            cmd2.ExecuteNonQuery();
            conItm.Close();
        }

        public bool ConnectUpdateItemSelect(StoreItem strItm02)
        {
            try
            {
                string queryItm02 = "SELECT * FROM [dbo].[ItemList] WHERE ID = @id";
                conItm.Open();
                SqlCommand cmd02 = new SqlCommand(queryItm02, conItm);
                cmd02.Parameters.AddWithValue("@id", strItm02.ItemId);
                SqlDataReader dr02 = cmd02.ExecuteReader();

                if (dr02.HasRows.Equals(true))
                {
                    existId = true;
                    conItm.Close();
                }
                else
                {
                    existId = false;
                    conItm.Close();
                }
            }
            catch (Exception)
            {
                existId = false;
            }

            return existId;
        }

        public void ConnectRemoveItem(StoreItem strItm3)
        {
            string queryItm4 = @"DELETE FROM [dbo].[ItemList] WHERE ID = @id";
            conItm.Open();
            SqlCommand cmd3 = new SqlCommand(queryItm4, conItm);
            cmd3.Parameters.AddWithValue("@id", strItm3.ItemId);
            cmd3.ExecuteNonQuery();
            conItm.Close();
        }

        public bool ConnectRemoveItemSelect(StoreItem strItm03)
        {
            try
            {
                string queryItm03 = "SELECT * FROM [dbo].[ItemList] WHERE ID = @id";
                conItm.Open();
                SqlCommand cmd03 = new SqlCommand(queryItm03, conItm);
                cmd03.Parameters.AddWithValue("@id", strItm03.ItemId);
                SqlDataReader dr03 = cmd03.ExecuteReader();

                if(dr03.HasRows.Equals(true))
                {
                    existId = true;
                    conItm.Close();
                }
                else
                {
                    existId = false;
                    conItm.Close();
                }
            }
            catch(Exception)
            {
                existId = false;
            }

            return existId;
        }

        public SqlDataAdapter ConnectShowItem()
        {
            string queryItm2 = "SELECT * FROM [dbo].[ItemList]";
            conItm.Open();
            SqlDataAdapter sda1 = new SqlDataAdapter(queryItm2, conItm);
            conItm.Close();
            return sda1;
        }

        public DataSet ConnectShowItemList(StoreItem strItm4)
        {
            string queryItmList1 = @"SELECT ITEMNAME FROM [dbo].[ItemList] WHERE CATEGORY = '" + strItm4.ItemCategory + "' COLLATE SQL_Latin1_General_CP1_CS_AS";
            conItm.Open();
            SqlDataAdapter sdaList1 = new SqlDataAdapter(queryItmList1, conItm);
            DataSet ds1 = new DataSet();
            sdaList1.Fill(ds1);
            conItm.Close();
            return ds1;
        }

        public DataSet ConnectFillUpTxt(StoreItem storeItmFill1)
        {
            string queryFillTxt1 = @"SELECT PRICE FROM [dbo].[ItemList] WHERE ITEMNAME = '" + storeItmFill1.ItemName + "' COLLATE SQL_Latin1_General_CP1_CS_AS";
            conItm.Open();
            SqlDataAdapter sdaFill1 = new SqlDataAdapter(queryFillTxt1, conItm);
            DataSet ds2 = new DataSet();
            sdaFill1.Fill(ds2);
            conItm.Close();
            return ds2;
        }
    }
}
