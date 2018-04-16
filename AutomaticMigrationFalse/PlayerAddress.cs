using System.ComponentModel.DataAnnotations.Schema;

namespace AutomaticMigrationFalse
{
    partial class Program
    {
        public class PlayerAddress
        {
            [ForeignKey("Player")]
            public int PlayerAddressID { get; set; }
            public string City { get; set; }

            public string Street { get; set; }

            public string PostCode { get; set; }

            // Her bir adres sadece bir futbolcuya aittir.
            public virtual Player Player { get; set; } // Buraya bir tane Player_Id ekler!


        }
    }
}
