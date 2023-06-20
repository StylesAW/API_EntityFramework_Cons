using System;
using System.ComponentModel.DataAnnotations;

namespace APIMultimedios.Model
{
    public class Menu
    {
        [Key]
        public int IdMenu { get; set; }

        public string NameMenu { get; set; }
        
        public int IdCatalogoMenu { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public bool Enabled { get; set; }

        

    }
}
