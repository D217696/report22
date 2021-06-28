using asptest6.Objects;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace asptest6.Models
{
    public class RaidsModel
    {
        public Dictionary<long, int> RaidHashes { get; set; } = new Dictionary<long, int>();
        readonly Database Database = new();

        public void LoadRaidHashes()
        {
            string sql = $"SELECT json_object('hash', hashes.hash, 'raid_id', raids.id) FROM hashes inner join raids on hashes.raid_id = raids.id;";
            MySqlCommand cmd = new(sql, Database.Db);
            try
            {
                Database.Db.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        RaidHash raidHash = JsonConvert.DeserializeObject<RaidHash>(reader.GetValue(0).ToString());
                        RaidHashes.Add(raidHash.Hash, raidHash.RaidId);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Database.Db.Close();
        }

        public List<RaidCompletions> GetRaidCompletions(string membershipId)
        {
            List<RaidCompletions> raidCompletions = new();
            string sql = "SELECT json_object('name', raids.name, 'player_count', pgcrs.player_count, 'count', count(pgcrs.pgcr_id)) FROM pgcrs INNER JOIN raids ON raids.id = pgcrs.raid_id INNER JOIN character_pgcrs ON character_pgcrs.pgcr_id = pgcrs.pgcr_id INNER JOIN characters ON characters.character_id = character_pgcrs.character_id WHERE characters.membership_id = @membership_id AND pgcrs.player_count < 4 AND character_pgcrs.completed = 1 GROUP BY pgcrs.raid_id, pgcrs.player_count";
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
                        raidCompletions.Add(JsonConvert.DeserializeObject<RaidCompletions>(reader.GetValue(0).ToString()));
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return raidCompletions;
        }

        public List<Raid> GetRaids()
        {
            List<Raid> raids = new();
            string sql = "select json_object('id', raids.id, 'display_name', raids.display_name, 'name', raids.name, 'release_date', raids.release_date, 'img', img) from raids";
            MySqlCommand cmd = new(sql, Database.Db);
            try
            {
                Database.Db.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        raids.Add(JsonConvert.DeserializeObject<Raid>(reader.GetValue(0).ToString()));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return raids;
        }
    }
}
