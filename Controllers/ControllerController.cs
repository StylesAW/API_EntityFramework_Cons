using APIMultimedios.Data;
using APIMultimedios.Model;
using Microsoft.AspNetCore.Mvc;

namespace APIMultimedios.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class ControllerController : ControllerBase
    {
        private readonly Context contexto;
        public ControllerController(Context pContext)
        {
            this.contexto = pContext;
        }

        [HttpGet]
        public List<controller> ListaControladores()
        {
            var lista = this.contexto.controller.ToList();
            return lista;
        }

        [HttpGet("{idController}")]
        public controller consultarControlador(int idController)
        {
            var temp = this.contexto.controller.Find(idController);
            return temp;
        }

        [HttpPut("agregarControlador")]
        public void AgregarControlador(controller nuevo)
        {
            this.contexto.Add(nuevo);
            this.contexto.SaveChanges();
        }



        [HttpPut("modificarControlador")]
        public void ModificarControlador(controller nuevo)
        {
            this.contexto.Update(nuevo);
            this.contexto.SaveChanges();
        }


        [HttpDelete("{idController}")]
        public string EliminarControlador(int idController)
        {
            string mensaje = "No se pudo eliminar el controlador";
            var temp = this.contexto.controller.Find(idController);

            if (temp != null)
            {
                this.contexto.Remove(temp);
                this.contexto.SaveChanges();
                mensaje = "El error ha sido elminiado";
            }
            return mensaje;
        }
    }
}