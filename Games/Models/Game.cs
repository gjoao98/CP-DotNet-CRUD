using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Games.Models
{
    public class Game
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Developer { get; set; }
        public string? Publisher { get; set; }
        public string? Category { get; set; }

        [Column("Dt_Lancamento"), Display(Name = "Release Date"), DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public Genre Genre { get; set; }
        public Review Review { get; set; }
        public bool FreeToPlay { get; set; }
    }

    public enum Genre
    {
        Aventura, FPS, MMO, RPG, Souls, Simulador, Corrida, Esporte
    }

    public enum Review
    {
        Otima, Bom, Medio, Ruim, Pessimo
    }
}
