using System;
using System.Collections.Generic;
using System.Text;

namespace ArtifyStore.Models
{
    class Pelanggan
    {
        private string nama;
        private string noHp;

        public string Nama
        {
            get { return nama; }
            set { nama = value; }
        }

        public string NoHp
        {
            get { return noHp; }
            set { noHp = value; }
        }
    }
}
