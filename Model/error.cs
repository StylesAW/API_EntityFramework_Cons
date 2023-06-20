using System.ComponentModel.DataAnnotations;

namespace APIMultimedios.Model
{
    public class Error
    {
        [Key]
        public int IdErrores { get; set; }

        public string Sentencia { get; set; }
        public string Controller { get; set; }
        

        public DateTime CreatedAt { get; set; }

        public int idUser { get; set; }
    }
}
