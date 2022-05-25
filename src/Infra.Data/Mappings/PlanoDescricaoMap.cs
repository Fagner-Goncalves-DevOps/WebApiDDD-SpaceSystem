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
    public class PlanoDescricaoMap : IEntityTypeConfiguration<PlanoDescricao>
    {
        public void Configure(EntityTypeBuilder<PlanoDescricao> builder)
        {
            builder.HasKey(p => p.Id); //gui id =1000

            builder.Property(p => p.NomePlano)
                .IsRequired()
                .HasColumnType("varchar(200)");

            builder.Property(p => p.DescricaoPlano)
                .IsRequired()
                .HasColumnType("varchar(1000)");

            builder.Property(p => p.DescontoPlano)
                .IsRequired()
                .HasColumnType("decimal");

            builder.ToTable("PlanoDescricoes");
        }
    }
}

