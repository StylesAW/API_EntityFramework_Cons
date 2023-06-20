using APIMultimedios.Data;
using APIMultimedios.Model;
using Microsoft.AspNetCore.Mvc;

namespace APIMultimedios.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuditoriaController : ControllerBase
    {
        private readonly Context contexto;
        public AuditoriaController(Context pContext)
        {
            this.contexto = pContext;
        }

        [HttpGet]
        public List<Auditoria> ListaAuditoria()
        {
            var lista = this.contexto.auditoria.ToList();
            return lista;
        }

        [HttpGet("{idAuditoria}")]
        public Auditoria consultarAuditoria(int idAuditoria)
        {
            var temp = this.contexto.auditoria.Find(idAuditoria);
            return temp;
        }

        [HttpPut("agregarAuditoria")]
        public void AgregarAuditoria(Auditoria nuevo)
        {
            this.contexto.Add(nuevo);
            this.contexto.SaveChanges();
        }



        [HttpPut("modificarAuditoria")]
        public void ModificarAuditoria(Auditoria nuevo)
        {
            this.contexto.Update(nuevo);
            this.contexto.SaveChanges();
        }


        [HttpDelete("{idAuditoria}")]
        public string EliminarAuditoria(int idAuditoria)
        {
            string mensaje = "No se pudo eliminar la Auditoria";
            var temp = this.contexto.auditoria.Find(idAuditoria);

            if (temp != null)
            {
                this.contexto.Remove(temp);
                this.contexto.SaveChanges();
                mensaje = "La Auditoria ha sido elminiada";
            }
            return mensaje;
        }
    }
}