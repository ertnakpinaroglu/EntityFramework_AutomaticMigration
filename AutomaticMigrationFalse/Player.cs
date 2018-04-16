using System;

namespace AutomaticMigrationFalse
{
    partial class Program
    {
        public class Player
        {
            public int Id { get; set; }
            public string Ad { get; set; }
            public String Soyad { get; set; }
            public DateTime DogumYili { get; set; }

            // Her oyuncu sadece bir takımda oynayabilir!
            public virtual Team Team { get; set; } // Buraya bir Team_Id eklenecektir!

            public virtual PlayerAddress PlayerAddress { get; set; } // Her oyuncunun sadece bir adresi bulunur! 1-

        }
    }
}
