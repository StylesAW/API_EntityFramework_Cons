using System;
using System.ComponentModel.DataAnnotations;

namespace APIMultimedios.Model
{
    public class User
    {
        [Key]
        public int IdUser { get; set; }

        public string IdPersonal { get; set; }

        public string NameUser { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public int IdRol { get; set; }

        public DateTime CreatedAt { get; set; }

        public int Enabled { get; set; }

        public DateTime UpdatedAt { get; set; }


    }
}
