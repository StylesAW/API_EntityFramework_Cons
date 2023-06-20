using System.ComponentModel.DataAnnotations;

namespace APIMultimedios.Model
{
    public class Rol
    {
        [Key]
        public int IdRol { get; set; }

        public string NameRol { get; set; }

        public int IdMenu { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public bool Enabled { get; set; }
    }
}
