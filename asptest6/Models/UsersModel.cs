using asptest6.Objects;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace asptest6.Models
{
    public class UsersModel
    {
        readonly Database Database = new();
        public User GetUser(int userId)
        {
            User user = null;
            string sql = $"SELECT json_object('user_id', user_id, 'username', username) from Users WHERE user_id = @user_id;";
            MySqlCommand cmd = new(sql, Database.Db);
            cmd.Parameters.AddWithValue("@user_id", userId);
            try
            {
                Database.Db.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        user = JsonConvert.DeserializeObject<User>(reader.GetValue(0).ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Database.Db.Close();
            return user;
        }

        public User InsertUser(string username)
        {
            User user = new(0, username); 
            string sql = $"INSERT INTO Users (username) VALUES (@username); SELECT LAST_INSERT_ID();";
            MySqlCommand cmd = new(sql, Database.Db);
            cmd.Parameters.AddWithValue("@username", username);
            try
            {
                Database.Db.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        _ = int.TryParse(reader.GetValue(0).ToString(), out int id);
                        user.UserID = id;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Database.Db.Close();
            return user;
        }
    }
}
