using CRUD___Contactify.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUD___Contactify.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {   
        }


        public DbSet<ContatoModel> Contatos { get; set; }
    }
}
