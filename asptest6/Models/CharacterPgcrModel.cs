using asptest6.Objects;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace asptest6.Models
{
    public class CharacterPgcrModel
    {
        readonly Database Database = new();

        public CharacterPgcr GetCharacterPgcr(string characterId, long pgcrId)
        {
            CharacterPgcr characterPgcr = null;
            string sql = $"SELECT json_object('id', id, 'character_id', character_id, 'pgcr_id', pgcr_id, 'kills', kills, 'deaths', deaths, 'completed', completed) from Character_pgcrs WHERE character_id = @character_id AND pgcr_id = @pgcr_id;";
            MySqlCommand cmd = new(sql, Database.Db);
            cmd.Parameters.AddWithValue("@character_id", characterId);
            cmd.Parameters.AddWithValue("@pgcr_id", pgcrId);
            try
            {
                Database.Db.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        characterPgcr = JsonConvert.DeserializeObject<CharacterPgcr>(reader.GetValue(0).ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Database.Db.Close();
            return characterPgcr;
        }

        public CharacterPgcr InsertCharacterPgcr(CharacterPgcr characterPgcr)
        {
            string sql = $"INSERT INTO character_pgcrs (character_id, pgcr_id, kills, deaths, completed) VALUES (@character_id, @pgcr_id, @kills, @deaths, @completed);";
            MySqlCommand cmd = new(sql, Database.Db);
            cmd.Parameters.AddWithValue("@character_id", characterPgcr.CharacterId);
            cmd.Parameters.AddWithValue("@pgcr_id", characterPgcr.PgcrId);
            cmd.Parameters.AddWithValue("@kills", characterPgcr.Kills);
            cmd.Parameters.AddWithValue("@deaths", characterPgcr.Deaths);
            cmd.Parameters.AddWithValue("@completed", characterPgcr.Completed);
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
            return characterPgcr;
        }
    }
}
