using asptest6.Objects;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace asptest6.Models
{
    public class PgcrsModel
    {
        readonly Database Database = new();

        public Pgcr GetPgcr(long pgcrId)
        {
            Pgcr pgcr = null;
            string sql = $"SELECT json_object('pgcr_id', pgcr_id, 'pgcr', pgcr, 'flawless', flawless, 'starting_phase_index', starting_phase_index, 'raid_id', raid_id, 'player_count', player_count) from pgcrs WHERE pgcr_id = @pgcr_id";
            MySqlCommand cmd = new(sql, Database.Db);
            cmd.Parameters.AddWithValue("@pgcr_id", pgcrId);
            try
            {
                Database.Db.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        pgcr = JsonConvert.DeserializeObject<Pgcr>(reader.GetValue(0).ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Database.Db.Close();
            return pgcr;
        }

        public Pgcr InsertPgcr(Pgcr pgcr)
        {
            string sql = "INSERT INTO pgcrs (pgcr_id, pgcr, flawless, starting_phase_index, raid_id, player_count) VALUES (@pgcr_id, @pgcr, @flawless, @starting_phase_index, @raid_id, @player_count)";
            MySqlCommand cmd = new(sql, Database.Db);
            cmd.Parameters.AddWithValue("@pgcr_id", pgcr.PcgrId);
            cmd.Parameters.AddWithValue("@pgcr", pgcr.Pcgr);
            cmd.Parameters.AddWithValue("@flawless", pgcr.Flawless); ;
            cmd.Parameters.AddWithValue("@starting_phase_index", pgcr.StartingPhaseIndex);
            cmd.Parameters.AddWithValue("@raid_id", pgcr.RaidId);
            cmd.Parameters.AddWithValue("@player_count", pgcr.PlayerCount);
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
            return pgcr;
        }
    }
}
