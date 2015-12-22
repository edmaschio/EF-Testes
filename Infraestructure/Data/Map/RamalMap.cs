using Infraestructure.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Data.Map
{
    public class RamalMap : EntityTypeConfiguration<Ramal>
    {

        public RamalMap()
        {
            ToTable("Ramal");

            Property(x => x.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .HasColumnName("RamalId");

            Property(x => x.NumeroRamal)
                .HasColumnName("NroRamal")
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("IX_NRORAMAL", 1) { IsUnique = true } ))
                .IsRequired();

            Property(x => x.Data)
                .HasColumnName("DataManutencao")
                .IsRequired();

        }
    }
}
