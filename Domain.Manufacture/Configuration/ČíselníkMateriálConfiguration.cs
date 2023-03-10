// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using Sylex.ISYS.Domain.Manufacture.Models;
using System;

#nullable disable

namespace Sylex.ISYS.Domain.Manufacture.Configuration
{
    public class ČíselníkMateriálConfiguration : IEntityTypeConfiguration<ČíselníkMateriál>
    {
        public void Configure(EntityTypeBuilder<ČíselníkMateriál> entity)
        {
            entity.HasKey(e => e.KódMateriálu);
            entity.HasAlternateKey(e => e.Id);

            entity.HasIndex(e => e.Id, "UQ_ČíselníkMateriál_ID")
                .IsUnique();
            entity.Property(e => e.Id).HasColumnName("ID").UseIdentityColumn(1, 1);

            entity.HasIndex(e => e.KódDodavateľa, "KódDodávateľa");


            entity.Property(e => e.KódDodavateľa)
                //column name specified explicitely, otherwise EF adds prefix in order to differenciate from MaterialInfo2
                .HasColumnName("KódDodavateľa") 
                .HasMaxLength(50);

            entity.Property(e => e.KódMateriálu)
                .HasColumnName("KódMateriálu")
                .HasMaxLength(25);

            entity.Property(e => e.KódMolex).HasMaxLength(1000);

            entity.Property(e => e.Popis)
                .HasColumnName("Popis")
                .HasMaxLength(255);

            //entity.Property(e => e.Poznámka).HasMaxLength(255);

            entity.Property(e => e.ROHS)
                .HasMaxLength(1)
                .HasColumnName("ROHS");

            entity.Property(e => e.Skupina).HasMaxLength(25);
            entity.Property(e => e.Druh)
                .HasColumnName("Druh")
                .HasMaxLength(15);

            entity.Property(e => e.Vkdept)
                .HasMaxLength(3)
                .HasColumnName("VKdept")
                .HasComment("Vstupná kontrola: FOI/FOS ");

            entity.Property(e => e.BufferStock)
                .HasMaxLength(40)
                .HasColumnName("BStock");

            //entity.Property(e => e.Cm)
            //    .HasMaxLength(40)
            //    .HasColumnName("CM")
            //    .HasComment("Conflict Minerals");


            entity.Property(e => e.MOQ)
                .HasMaxLength(50);

            entity.Property(e => e.CofO)
                .HasMaxLength(40)
                .HasComment("Call of Order");

            entity.Property(e => e.CPR)
                .HasMaxLength(16)
                .HasColumnName("CPR");

            entity.Property(e => e.CQ)
                .HasMaxLength(50)
                .HasColumnName("CQ")
                .HasComment("číslo projektu");

            entity.Property(e => e.Divízia).HasMaxLength(3);

            entity.Property(e => e.EUpreferencia)
                .HasMaxLength(1)
                .HasColumnName("EUpreferencia");

            entity.Property(e => e.Hmotnosť).HasComment("udáva sa v gramoch/MJ");

            entity.Property(e => e.Krajina)
                .HasMaxLength(2)
                .HasComment("kód krajiny pôvodu");


            entity.Property(e => e.Mena).HasMaxLength(3);

            entity.Property(e => e.MJ)
                .HasMaxLength(50)
                .HasColumnName("MJ");

            entity.Property(e => e.Revízia)
               .HasMaxLength(10);

            // entity.Property(e => e.Umiestnenie).HasMaxLength(15);



            entity.Property(e => e.ZaložilDátumČas).HasColumnType("datetime");

            entity.Property(e => e.ZaložilMeno).HasMaxLength(20);

            entity.Property(e => e.ZmenilDátumČas).HasColumnType("datetime");

            entity.Property(e => e.ZmenilMeno).HasMaxLength(20);
        }
    }
}
