using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ClassLibrary1.Models.Mapping
{
    public class EnderecoMap : EntityTypeConfiguration<Endereco>
    {
        public EnderecoMap()
        {
            // Primary Key
            this.HasKey(t => t.EnderecoId);

            // Properties
            this.Property(t => t.EnderecoId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Rua)
                .IsRequired()
                .HasMaxLength(300);

            this.Property(t => t.Numero)
                .IsRequired()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("TBL_Endereco");
            this.Property(t => t.EnderecoId).HasColumnName("ID_Endereco");
            this.Property(t => t.Rua).HasColumnName("str_Rua");
            this.Property(t => t.Numero).HasColumnName("str_Numero");
            this.Property(t => t.PessoaId).HasColumnName("Pessoa_ID");

            // Relationships
            this.HasRequired(t => t.Pessoa)
                .WithMany(t => t.Endereco)
                .HasForeignKey(d => d.PessoaId);

        }
    }
}
