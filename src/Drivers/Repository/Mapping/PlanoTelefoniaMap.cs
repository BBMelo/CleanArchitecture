using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using vxTel.Domain.Entities;

namespace vxTel.Repository.Mapping
{
    public class PlanoTelefoniaMap : IEntityTypeConfiguration<PlanoTelefonia>
    {
        public void Configure(EntityTypeBuilder<PlanoTelefonia> builder)
        {
            builder.ToTable("PlanoTelefonia");
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Guid)                
                .HasColumnName("HASHCODE");

            builder.OwnsOne(p => p.Destino, destino =>
            {
                destino.Property(d => d.Code).HasColumnName("DDD_DESTINO");
            });

            builder.OwnsOne(p => p.Origem, destino =>
            {
                destino.Property(d => d.Code).HasColumnName("DDD_ORIGEM");
            });
            
            builder.Property(p => p.PrecoPorMinuto)
                .HasColumnType("decimal(3,2)")
                .HasColumnName("PRECO_MINUTO");

            builder.Property(p => p.TipoPlano)
                .HasColumnName("TIPO_PLANO");

            builder.Property(p => p.CreateAT)
                .HasColumnType("DATETIME")
                .HasColumnName("DATA_CRIACAO");

            builder.Property(p => p.ChangedAT)
                .HasColumnType("DATETIME")
                .HasColumnName("DATA_ALTERACAO");
        }
    }
}
