using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apkOnline_shop
{
    internal class Koneksi
    {
        public static MySqlConnection conn = new MySqlConnection("Server=localhost;Port=3306;UID=root;PWD=;Database=dbkasironline");

    }
}
