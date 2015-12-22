using Infraestructure.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;

namespace Infraestructure.Data.Map
{
    public class SetorMap : EntityTypeConfiguration<Setor>
    {
        public SetorMap()
        {
            ToTable("Setor");

            Property(x => x.ID)
                .HasColumnName("SetorId")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.NomeSetor)
                .HasMaxLength(60)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("IX_SETOR", 1) { IsUnique = true }))
                .HasColumnName("SetorNome")
                .IsRequired();

            Property(x => x.Data)
                .HasColumnName("DataManutencao")
                .IsRequired();
        }
    }
}
