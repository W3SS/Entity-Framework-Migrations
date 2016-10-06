using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ClassLibrary1.Models.Mapping
{
    public class PessoaMap : EntityTypeConfiguration<Pessoa>
    {
        public PessoaMap()
        {
            // Primary Key
            this.HasKey(t => t.PessoaId);

            // Properties
            this.Property(t => t.PessoaId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Nome)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Apelido)
                //.isrequired()    - como a tabela ja exise nao é possivel criar como required, ja que registros existentes n podem ser nulo
                .HasMaxLength(40);

            // Table & Column Mappings
            this.ToTable("tbl_Pessoa");
            this.Property(t => t.PessoaId).HasColumnName("ID");
            this.Property(t => t.Nome).HasColumnName("str_Nome");
            this.Property(t => t.Apelido).HasColumnName("str_Apelido");
            this.Property(t => t.Idade).HasColumnName("int_Idade");
            this.Property(t => t.DataCadastro).HasColumnName("date_DataCadastro");
            this.Property(t => t.Ativo).HasColumnName("bool_ativo");
        }
    }
}
