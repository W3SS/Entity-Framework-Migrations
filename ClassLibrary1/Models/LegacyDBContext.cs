using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using ClassLibrary1.Models.Mapping;

namespace ClassLibrary1.Models
{
    public partial class LegacyDBContext : DbContext
    {
        static LegacyDBContext()
        {
            Database.SetInitializer<LegacyDBContext>(null);
        }

        public LegacyDBContext()
            : base("LegacyDB")
        {
        }

        public DbSet<Endereco> TBL_Endereco { get; set; }
        public DbSet<Pessoa> tbl_Pessoa { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new EnderecoMap());
            modelBuilder.Configurations.Add(new PessoaMap());


            //Configuração a ser utilizada pelo EF quando necessario criar um novo campo
            modelBuilder.Properties()
                .Where(p => p.Name == p.ReflectedType.Name + "Id")
                .Configure(p => p.IsKey());

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(100));
        }
    }
}
