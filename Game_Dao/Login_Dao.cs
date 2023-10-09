using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Dao
{
    public class Login_Dao
    {
        public int login(string conn, string uid, string pwd)
        {
            SqlConnection sqlConnection = new SqlConnection(conn);
            try
            {
                ArrayList user_info = new ArrayList();
                sqlConnection.Open();
                string query = $"SELECT A.G_Uid, A.G_Pwd FROM G_USER AS A WHERE A.G_Uid COLLATE Korean_Wansung_CS_AS = '{uid}'";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                SqlDataReader dr = sqlCommand.ExecuteReader();

                if (dr.Read())
                {
                    string g_uid = dr.GetString(0);
                    string g_pwd = dr.GetString(1);
                    user_info.Add(g_uid);
                    user_info.Add(g_pwd);
                }
                
                if(user_info.Count == 0)
                {
                    return 0;
                }
                else
                {
                    if (user_info[0].ToString() == uid && user_info[1].ToString() == pwd)
                    {
                        return 1;
                    }
                    else if(user_info[0].ToString() != uid)
                    {
                        return -1;
                    }
                    else if(user_info[1].ToString() != pwd)
                    {
                        return -2;
                    }
                    else
                    {
                        return -3;
                    }
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        public int signup(string conn, string uid, string pwd)
        {
            using (SqlConnection sqlConnection = new SqlConnection(conn))
            {
                try
                {
                    sqlConnection.Open();
                    string insert = $"INSERT INTO G_USER(G_Uid, G_Pwd) VALUES ('{uid}', '{pwd}')";
                    using (SqlCommand cmd = sqlConnection.CreateCommand())
                    {
                        cmd.CommandText = insert;
                        int result = cmd.ExecuteNonQuery();

                        return result;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return 0;
                }
                finally
                {
                    sqlConnection.Close();
                }
            }
        }
    }
}
