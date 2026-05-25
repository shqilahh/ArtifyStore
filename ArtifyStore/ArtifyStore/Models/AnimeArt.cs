using System;
using System.Collections.Generic;
using System.Text;

namespace ArtifyStore.Models
{
    class AnimeArt : Product
    {
        public override int HitungTotal(int harga, int jumlah)
        {
            return harga * jumlah;
        }
    }
}
