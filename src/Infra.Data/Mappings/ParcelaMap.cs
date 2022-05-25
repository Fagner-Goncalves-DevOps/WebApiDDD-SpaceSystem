using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Data.Mappings
{
    public class ParcelaMap : IEntityTypeConfiguration<Parcela>
    {
        public void Configure(EntityTypeBuilder<Parcela> builder)
        {
            builder.HasKey(p => p.Id); //gui id =1000

            builder.Property(p => p.Plano)
                .IsRequired()
                .HasColumnType("varchar(200)");

            builder.Property(p => p.ValorParcelas)
                .IsRequired()
                .HasColumnType("decimal");

            //parcela fala com plano, mais a relação e feita aqui, não no plano
            //toda relação necessaria para parcela e plano e feita aqui
            //relações 1 : 1 para fk da parcelaid do plano com id parcela origin
            builder.HasOne(f => f.PlanoDescricoes)
                   .WithOne(e => e.Parcelas);
            //builder.HasOne(pa => pa.PlanoDescricoes)
            //        .WithOne(pp => pp.)//.HasForeignKey(pc => pc.ParcelaId);
            //builder.ToTable("Parcelas");
         }
    }
}




//// 1 : 1 => Fornecedor : Endereco | Um para Um |  gera FK Relacao
//builder.HasOne(f => f.Endereco)
//    .WithOne(e => e.Pessoa);



