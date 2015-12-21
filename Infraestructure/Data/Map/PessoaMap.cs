using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Domain.Models;
using System.Data.Entity.Infrastructure.Annotations;

namespace Infraestructure.Data.Map
{
    public class PessoaMap : EntityTypeConfiguration<Pessoa>
    {
        public PessoaMap()
        {
            ToTable("Pessoa");

            Property(x => x.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.NomePessoa)
                .HasMaxLength(60)
                .IsRequired()
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("IX_NOMEPESSOA", 1) { IsUnique = true }));

            Property(x => x.Data)
                .HasColumnName("DataManutencao")
                .IsRequired();
        }
    }
}
