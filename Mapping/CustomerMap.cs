﻿using BookShopTmp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookShopTmp.Mapping
{
    public class CustomerMap: IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder
              .HasOne(p => p.city1)
              .WithMany(t => t.Customers1)
              .HasForeignKey(p => p.CityId1);

            builder
                  .HasOne(p => p.city2)
                  .WithMany(t => t.Customers2)
                  .HasForeignKey(p => p.CityId2).OnDelete(DeleteBehavior.Restrict);
        }
       
    }
}
