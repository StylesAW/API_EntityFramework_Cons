using System.ComponentModel.DataAnnotations;

namespace APIMultimedios.Model
{
    public class Auditoria
    {
        [Key]
        public int IdAuditoria { get; set; }

        public string Sentencia { get; set; }
        public string Controller { get; set; }

        public int idMenu { get; set; }

        public int idUser { get; set; }

        public DateTime CreateDate { get; set; }
    }
}