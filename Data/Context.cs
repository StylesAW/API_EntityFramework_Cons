using APIMultimedios.Model;
using Microsoft.EntityFrameworkCore;

namespace APIMultimedios.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }

        public DbSet<Error> error { get; set; }

        public DbSet<Rol> roles { get; set; }

        public DbSet<Menu> menu { get; set; }

        public DbSet<User> user { get; set; }

        public DbSet<Auditoria> auditoria { get; set; }

        public DbSet<controller> controller{ get; set; }

    }
}
