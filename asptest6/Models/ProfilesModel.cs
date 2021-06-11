using asptest6.Objects;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace asptest6.Models
{
    public class ProfilesModel
    {
        readonly Database Database = new();
        public Profile GetProfile(string membershipId)
        {
            Profile profile = null;
            string sql = $"SELECT json_object('membership_id', membership_id, 'membership_type', membership_type, 'user_id', user_id, 'last_updated', last_updated, 'username', username) from Profiles WHERE membership_id = @membership_id;";
            MySqlCommand cmd = new(sql, Database.Db);
            cmd.Parameters.AddWithValue("@membership_id", membershipId);
            try
            {
                Database.Db.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        profile = JsonConvert.DeserializeObject<Profile>(reader.GetValue(0).ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Database.Db.Close();

            return profile;
        }

        public List<Profile> GetProfiles(string membershipId)
        {
            List<Profile> profiles = new();
            string sql = "SELECT json_object('membership_id', membership_id, 'membership_type', membership_type, 'user_id', user_id, 'last_updated', last_updated, 'username', username) FROM `profiles` WHERE (SELECT user_id from profiles where membership_id = @membership_id) = profiles.user_id";
            MySqlCommand cmd = new(sql, Database.Db);
            cmd.Parameters.AddWithValue("@membership_id", membershipId);
            try
            {
                Database.Db.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        profiles.Add(JsonConvert.DeserializeObject<Profile>(reader.GetValue(0).ToString()));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Database.Db.Close();
            return profiles;
        }

        public Profile InsertProfile(Profile profile)
        {
            string sql = $"INSERT INTO Profiles (membership_id, membership_type, user_id, last_updated, username) VALUES (@membership_id, @membership_type, @user_id, @last_updated, @username);";
            MySqlCommand cmd = new(sql, Database.Db);
            cmd.Parameters.AddWithValue("@membership_id", profile.MembershipId);
            cmd.Parameters.AddWithValue("@membership_type", profile.MembershipType);
            cmd.Parameters.AddWithValue("@user_id", profile.UserId);
            cmd.Parameters.AddWithValue("@last_updated", profile.LastUpdated);
            cmd.Parameters.AddWithValue("@username", profile.Username);
            try
            {
                Database.Db.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read()){}
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Database.Db.Close();
            return profile;
        }

        public void UpdateProfileLastUpdated(string membershipId, DateTime lastUpdate)
        {
            string sql = "UPDATE Profiles SET last_updated = @last_updated WHERE membership_id = @membership_id";
            MySqlCommand cmd = new(sql, Database.Db);
            cmd.Parameters.AddWithValue("@last_updated", lastUpdate);
            cmd.Parameters.AddWithValue("@membership_id", membershipId);
            try
            {
                Database.Db.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read()) { }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Database.Db.Close();
        }
    }
}