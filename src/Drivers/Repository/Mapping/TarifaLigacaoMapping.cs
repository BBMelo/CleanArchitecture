using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using vxTel.Domain.Entities;

namespace vxTel.Repository.Mapping
{
    public class TarifaLigacaoMapping : IEntityTypeConfiguration<TarifaLigacao>
    {
        public void Configure(EntityTypeBuilder<TarifaLigacao> builder)
        {
            builder.ToTable("TarifaTelefonia");
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
            builder.Property(p => p.TarifaPorMinuto)
                .HasColumnType("decimal(3,2)")
                .HasColumnName("PRECO_MINUTO");            
            builder.Property(p => p.CreateAT)
                .HasColumnType("DATETIME")
                .HasColumnName("DATA_CRIACAO");
            builder.Property(p => p.ChangedAT)
                .HasColumnType("DATETIME")
                .HasColumnName("DATA_ALTERACAO");
        }
    }
}
