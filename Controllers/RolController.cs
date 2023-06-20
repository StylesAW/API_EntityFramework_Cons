using APIMultimedios.Data;
using APIMultimedios.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIMultimedios.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolController : ControllerBase
    {
        private readonly Context contexto;

        public RolController(Context rContext)
        {
            this.contexto=rContext;
        }

        [HttpGet]
        public List<Rol> ListaRoles()
        {
            var listar = this.contexto.roles.ToList();
            return listar;
        }

        [HttpGet("{idRol}")]
        public Rol consultarRol(int idRol)
        {
            var temp = this.contexto.roles.Find(idRol);
            return temp;
        }

        [HttpPut("agregarRol")]
        public void AgregarRol(Rol nuevo)
        {
            this.contexto.Add(nuevo);
            this.contexto.SaveChanges();
        }

        [HttpPut("modificarRol")]
        public void ModificarRol(Rol nuevo)
        {
            this.contexto.Update(nuevo);
            this.contexto.SaveChanges();
        }

        [HttpDelete("{idRol}")]
        public string EliminarRol(int idRol)
        {
            string mensaje = "No se pudo eliminar el rol";
            var temp = this.contexto.roles.Find(idRol);

            if (temp != null)
            {
                this.contexto.Remove(temp);
                this.contexto.SaveChanges();
                mensaje = "El rol ha sido elminiado";
            }
            return mensaje;
        }

    }
}
