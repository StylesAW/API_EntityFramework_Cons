using APIMultimedios.Data;
using APIMultimedios.Model;
using Microsoft.AspNetCore.Mvc;

namespace APIMultimedios.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly Context contexto;
        public UserController(Context pContext)
        {
            this.contexto = pContext;
        }

        [HttpGet]
        public List<User> ListaUser()
        {
            var lista = this.contexto.user.ToList();
            return lista;
        }

        [HttpGet("{idUser}")]
        public User consultarUser(int idUser)
        {
            var temp = this.contexto.user.Find(idUser);
            return temp;
        }

        [HttpPut("agregarUser")]
        public void AgregarUser(User nuevo)
        {
            this.contexto.Add(nuevo);
            this.contexto.SaveChanges();
        }



        [HttpPut("modificarUser")]
        public void ModificarUser(User nuevo)
        {
            this.contexto.Update(nuevo);
            this.contexto.SaveChanges();
        }


        [HttpDelete("{idUser}")]
        public string EliminarUser(int idUser)
        {
            string mensaje = "No se pudo eliminar el usuario";
            var temp = this.contexto.user.Find(idUser);

            if (temp != null)
            {
                this.contexto.Remove(temp);
                this.contexto.SaveChanges();
                mensaje = "El usuario ha sido elminiado correctamente";
            }
            return mensaje;
        }
    }
}
