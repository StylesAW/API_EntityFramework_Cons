using APIMultimedios.Data;
using APIMultimedios.Model;
using Microsoft.AspNetCore.Mvc;

namespace APIMultimedios.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MenuController : ControllerBase
    {
        private readonly Context contexto;
        public MenuController(Context pContext)
        {
            this.contexto = pContext;
        }

        [HttpGet]
        public List<Menu> ListaMenu()
        {
            var lista = this.contexto.menu.ToList();
            return lista;
        }

        [HttpGet("{idMenu}")]
        public Menu consultarMenu(int idMenu)
        {
            var temp = this.contexto.menu.Find(idMenu);
            return temp;
        }

        [HttpPut("agregarMenu")]
        public void AgregarMenu(Menu nuevo)
        {
            this.contexto.Add(nuevo);
            this.contexto.SaveChanges();
        }



        [HttpPut("modificarMenu")]
        public void ModificarMenu(Menu nuevo)
        {
            this.contexto.Update(nuevo);
            this.contexto.SaveChanges();
        }


        [HttpDelete("{idMenu}")]
        public string EliminarMenu(int idMenu)
        {
            string mensaje = "No se pudo eliminar el menu";
            var temp = this.contexto.menu.Find(idMenu);

            if (temp != null)
            {
                this.contexto.Remove(temp);
                this.contexto.SaveChanges();
                mensaje = "El menu ha sido elminiado";
            }
            return mensaje;
        }
    }
}
