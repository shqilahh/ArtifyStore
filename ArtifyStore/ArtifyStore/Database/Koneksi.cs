using System;
using System.Collections.Generic;
using System.Text;
using Npgsql;

namespace ArtifyStore.Database
{
    class Koneksi
    {
        public static NpgsqlConnection GetConnection()
        {
            NpgsqlConnection conn = new NpgsqlConnection(
                "Host=localhost;Port=5432;Username=postgres;Password=Qilahss20;Database=ArtifyDB"
            );

            return conn;
        }
    }
}
