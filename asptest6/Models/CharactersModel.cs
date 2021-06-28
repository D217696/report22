using asptest6.Objects;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace asptest6.Models
{
    public class CharactersModel
    {
        readonly Database Database = new();

        public Character GetCharacter(string characterId)
        {
            Character character = null;
            string sql = $"SELECT json_object('character_id', character_id, 'membership_id', membership_id, 'deleted', deleted) from Characters WHERE character_id = @character_id;";
            MySqlCommand cmd = new(sql, Database.Db);
            cmd.Parameters.AddWithValue("@character_id", characterId);
            try
            {
                Database.Db.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        character = JsonConvert.DeserializeObject<Character>(reader.GetValue(0).ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Database.Db.Close();
            return character;
        }

        public List<Character> GetCharacters(string membershipId)
        {
            List<Character> characters = new List<Character>();
            string sql = $"SELECT json_object('character_id', character_id, 'membership_id', membership_id, 'deleted', deleted) from Characters WHERE membership_id = @membership_id AND deleted = 0;";
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
                        characters.Add(JsonConvert.DeserializeObject<Character>(reader.GetValue(0).ToString()));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Database.Db.Close();
            return characters;
        }

        public Character InsertCharacter(Character character)
        {
            string sql = $"INSERT INTO Characters (character_id, membership_id, deleted) VALUES (@character_id, @membership_id, @deleted);";
            MySqlCommand cmd = new(sql, Database.Db);
            cmd.Parameters.AddWithValue("@character_id", character.CharacterId);
            cmd.Parameters.AddWithValue("@membership_id", character.MembershipId);
            cmd.Parameters.AddWithValue("@deleted", character.Deleted);
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
            return character;
        }

        public List<Character> GetCharactersToUpdate(List<long> characterIds, string membershipId)
        {
            List<Character> characters = new();
            string sql = "SELECT json_object('character_id', character_id, 'membership_id', membership_id, 'deleted', deleted) FROM characters WHERE ";
            foreach (long characterId in characterIds)
            {
                sql += $"character_id != {characterId} and ";
            }
            sql += $"membership_id = {membershipId} and deleted = 0";
            MySqlCommand cmd = new(sql, Database.Db);
            try
            {
                Database.Db.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        characters.Add(JsonConvert.DeserializeObject<Character>(reader.GetValue(0).ToString()));
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Database.Db.Close();
            return characters;
        }

        public void UpdateCharacters(List<long> characterIds, string membershipId)
        {
            string sql = "UPDATE characters SET deleted = 1 where ";
            foreach(long characterId in characterIds)
            {
                sql += $"character_id != {characterId} and ";
            }
            sql += $"membership_id = {membershipId} and deleted = 0";
            MySqlCommand cmd = new(sql, Database.Db);
            try
            {
                Database.Db.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while(reader.Read()) { }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
