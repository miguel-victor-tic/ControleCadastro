using ControleDeCadastro.Models;
using Microsoft.EntityFrameworkCore;

namespace ControleDeCadastro.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {
        }

        public DbSet<ControleAssociadosModel> Associados { get; set; }
        public DbSet<ControleEmpresasModel> Empresas { get; set; }
        public DbSet<ControleAEModel> Associados_has_Empresas { get; set; }
        //public DbSet<ControleIndexModel> Index { get; set; }



    }
}
