using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace asptest6.Objects
{
    public class Database
    {
        public MySqlConnection Db { get; }
        public Database()
        {
            Db = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=lowmanreportv2");
        }
    }
}
