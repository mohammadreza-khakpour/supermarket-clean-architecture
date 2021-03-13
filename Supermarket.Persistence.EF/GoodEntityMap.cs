using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Supermarket.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Supermarket.Persistence.EF
{
    public class GoodEntityMap : IEntityTypeConfiguration<Good>
    {
        public void Configure(EntityTypeBuilder<Good> builder)
        {
            builder.HasKey(_ => _.Id);
            builder.Property(_ => _.Id).ValueGeneratedOnAdd();

            builder.HasOne(_ => _.Category)
                .WithMany(_ => _.Goods)
                .HasForeignKey(_ => _.CategoryId);
        }
    }
}
