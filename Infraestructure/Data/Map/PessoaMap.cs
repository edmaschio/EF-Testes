using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.Infrastructure.Annotations;
using Infraestructure.Models;

namespace Infraestructure.Data.Map
{
    public class PessoaMap : EntityTypeConfiguration<Pessoa>
    {
        public PessoaMap()
        {
            ToTable("Pessoa");

            Property(x => x.ID)
                .HasColumnName("PessoaId")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.NomePessoa)
                .HasColumnName("PessoaNome")
                .HasMaxLength(60)
                .IsRequired()
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("IX_NOMEPESSOA", 1) { IsUnique = true }));

            Property(x => x.Data)
                .HasColumnName("DataManutencaoPessoa")
                .IsRequired();

            HasRequired<Setor>(s => s.Setor)
                .WithMany(s => s.Pessoas);

            HasMany<Ramal>(s => s.Ramais)
                .WithMany(c => c.Pessoas)
                .Map(cs =>
                        {
                            cs.MapLeftKey("PessoaId");
                            cs.MapRightKey("RamalId");
                            cs.ToTable("PessoaRamal");
                        });
        }
    }
}
