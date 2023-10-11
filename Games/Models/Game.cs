using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Games.Models
{
    [Table("Tb_Games")]
    public class Game
    {
        [Column("Id"), HiddenInput]
        public int GameId { get; set; }
        [Required]
        public string? Title { get; set; }
        [Required]
        public string? Developer { get; set; }
        public string? Publisher { get; set; }
        [Required]
        public string? Category { get; set; }

        [Display(Name = "Release Date"), DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        [Required]
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
