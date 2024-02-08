using System.ComponentModel.DataAnnotations;

namespace ProvaVSComMDB.Model
{
    public class Animais
    {
        public int Id { get; set; }

        [MaxLength(100)]
        public string Nome { get; set;}
        [MaxLength(100)]
        public string? NomeCientifico { get; set;}
        [MaxLength(100)]
        public string? HabitatNatural { get; set;} 

    }
}
