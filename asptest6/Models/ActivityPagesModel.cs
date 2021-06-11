using asptest6.Objects;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace asptest6.Models
{
    public class ActivityPagesModel
    {
        readonly Database Database = new();

        public ActivityPage GetActivityPage(string membershipId, string characterId, int page)
        {
            ActivityPage activityPage = null;
            string sql = $"SELECT json_object('id', id, 'json', json, 'membership_id', membership_id, 'character_id', character_id, 'start_date', start_date, 'end_date', end_date, 'count', count, 'page', page) from Activity_Pages WHERE membership_id = @membership_id AND character_id = @character_id AND page = @page AND handled = 0;";
            MySqlCommand cmd = new(sql, Database.Db);
            cmd.Parameters.AddWithValue("@membership_id", membershipId);
            cmd.Parameters.AddWithValue("@character_id", characterId);
            cmd.Parameters.AddWithValue("@page", page);
            try
            {
                Database.Db.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        activityPage = JsonConvert.DeserializeObject<ActivityPage>(reader.GetValue(0).ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Database.Db.Close();
            return activityPage;
        }

        public List<ActivityPage> GetActivityPages(string membershipId, string characterId)
        {
            List<ActivityPage> activityPages = new List<ActivityPage>();
            string sql = $"SELECT json_object('id', id, 'json', json, 'membership_id', membership_id, 'character_id', character_id, 'start_date', start_date, 'end_date', end_date, 'count', count, 'page', page) from Activity_Pages WHERE membership_id = @membership_id AND character_id = @character_id;";
            MySqlCommand cmd = new(sql, Database.Db);
            cmd.Parameters.AddWithValue("@membership_id", membershipId);
            cmd.Parameters.AddWithValue("@character_id", characterId);
            try
            {
                Database.Db.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        activityPages.Add(JsonConvert.DeserializeObject<ActivityPage>(reader.GetValue(0).ToString()));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Database.Db.Close();
            return activityPages;
        }

        public ActivityPage InsertActivityPage(ActivityPage activityPage)
        {
            string sql = $"INSERT INTO Activity_Pages (json, membership_id, character_id, start_date, end_date, count, page) VALUES (@json, @membership_id, @character_id, @start_date, @end_date, @count, @page);";
            MySqlCommand cmd = new(sql, Database.Db);
            cmd.Parameters.AddWithValue("@json", activityPage.Json);
            cmd.Parameters.AddWithValue("@membership_id", activityPage.MembershipId);
            cmd.Parameters.AddWithValue("@character_id", activityPage.CharacterId);
            cmd.Parameters.AddWithValue("@start_date", activityPage.StartDate);
            cmd.Parameters.AddWithValue("@end_date", activityPage.EndDate);
            cmd.Parameters.AddWithValue("@count", activityPage.Count);
            cmd.Parameters.AddWithValue("@page", activityPage.Page);
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
            return activityPage;
        }

        public bool UpdateActivityPageHandled(int id, bool handled)
        {
            string sql = $"UPDATE Activity_Pages SET handled = @handled WHERE id = @id";
            MySqlCommand cmd = new(sql, Database.Db);
            cmd.Parameters.AddWithValue("@handled", handled);
            cmd.Parameters.AddWithValue("@id", id);
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
            return true;
        }
    }
}
