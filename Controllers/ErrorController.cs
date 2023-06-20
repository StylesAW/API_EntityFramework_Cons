using APIMultimedios.Data;
using APIMultimedios.Model;
using Microsoft.AspNetCore.Mvc;

namespace APIMultimedios.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ErrorController : ControllerBase
    {
        private readonly Context contexto;
        public ErrorController(Context pContext) 
        {
            this.contexto = pContext;
        }

        [HttpGet]
        public List<Error> ListaErrores()
        {
            var lista = this.contexto.error.ToList();
            return lista;
        }

        [HttpGet("{idError}")]
        public Error consultarError(int idError)
        {
            var temp = this.contexto.error.Find(idError);
            return temp;
        }

        [HttpPut("agregarError")]
        public void AgregarError(Error nuevo)
        {
            this.contexto.Add(nuevo);
            this.contexto.SaveChanges();
        }

        [HttpPut("modificarError")]
        public void ModificarError(Error nuevo)
        {
            this.contexto.Update(nuevo);
            this.contexto.SaveChanges();
        }

        [HttpDelete("{idError}")]
        public string EliminarError(int idError)
        {
            string mensaje = "No se pudo eliminar el error";
            var temp = this.contexto.error.Find(idError);

            if(temp != null)
            {
                this.contexto.Remove(temp);
                this.contexto.SaveChanges();
                mensaje = "El error ha sido elminiado";
            }
            return mensaje;
        }
    }
}
