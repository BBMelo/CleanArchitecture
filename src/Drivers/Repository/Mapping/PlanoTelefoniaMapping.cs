using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using vxTel.Domain.Entities;

namespace vxTel.Repository.Mapping
{
    public class PlanoTelefoniaMapping : IEntityTypeConfiguration<PlanoTelefonia>
    {
        public void Configure(EntityTypeBuilder<PlanoTelefonia> builder)
        {
            builder.ToTable("PlanoTelefonia");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Guid)
                .HasColumnName("HASHCODE");
            builder.Property(p => p.EPlanoTelefonia)
                .HasColumnName("TIPO");
            builder.Property(p => p.MinutosPraFalarDeGraca)
                .HasColumnName("MinutoPlano");
            builder.Property(p => p.AcrescimentoExcedente)
                .HasColumnName("TaxaAcrescimo");
            builder.Property(p => p.CreateAT)
                .HasColumnType("DATETIME")
                .HasColumnName("DATA_CRIACAO");
            builder.Property(p => p.ChangedAT)
                .HasColumnType("DATETIME")
                .HasColumnName("DATA_ALTERACAO");
        }
    }
}
