using System;
using System.Collections.Generic;
using System.Text;

namespace ArtifyStore.Models
{
    abstract class Product
    {
        public abstract int HitungTotal(int harga, int jumlah);
    }
}
