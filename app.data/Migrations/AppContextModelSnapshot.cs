﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using app.data;

namespace app.data.Migrations
{
    [DbContext(typeof(AppContext))]
    partial class AppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("app.entity.AnamnezForm", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float?>("BasenÖlcüsü")
                        .HasColumnType("real");

                    b.Property<float?>("BelÖlcüsü")
                        .HasColumnType("real");

                    b.Property<float?>("Boy")
                        .HasColumnType("real");

                    b.Property<int>("DietId")
                        .HasColumnType("int");

                    b.Property<float?>("GögüsÖlcüsü")
                        .HasColumnType("real");

                    b.Property<float?>("Kilo")
                        .HasColumnType("real");

                    b.Property<string>("Soru1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Soru10")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Soru11")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Soru12")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Soru13")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Soru14")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Soru15")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Soru16")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Soru17")
                        .HasColumnType("int");

                    b.Property<int?>("Soru18")
                        .HasColumnType("int");

                    b.Property<int?>("Soru19")
                        .HasColumnType("int");

                    b.Property<string>("Soru2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Soru20")
                        .HasColumnType("int");

                    b.Property<int?>("Soru21")
                        .HasColumnType("int");

                    b.Property<int?>("Soru22")
                        .HasColumnType("int");

                    b.Property<int?>("Soru23")
                        .HasColumnType("int");

                    b.Property<int?>("Soru24")
                        .HasColumnType("int");

                    b.Property<string>("Soru25")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Soru26")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Soru27")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Soru28")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Soru29")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Soru3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Soru30")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Soru4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Soru5")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Soru6")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Soru7")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Soru8")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Soru9")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float?>("Yas")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("DietId")
                        .IsUnique();

                    b.ToTable("AnamnezForms");
                });

            modelBuilder.Entity("app.entity.Calendar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<int>("CurrentDay")
                        .HasColumnType("int");

                    b.Property<string>("CurrentHour")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CurrentMounth")
                        .HasColumnType("int");

                    b.Property<int>("CurrentYear")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateTimeOfDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DietWekklyId")
                        .HasColumnType("int");

                    b.Property<int>("FinishedHour")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PilatesWeekId")
                        .HasColumnType("int");

                    b.Property<int>("StartingHour")
                        .HasColumnType("int");

                    b.Property<int>("Traning")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DietWekklyId")
                        .IsUnique()
                        .HasFilter("[DietWekklyId] IS NOT NULL");

                    b.HasIndex("PilatesWeekId")
                        .IsUnique()
                        .HasFilter("[PilatesWeekId] IS NOT NULL");

                    b.ToTable("Calendars");
                });

            modelBuilder.Entity("app.entity.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("app.entity.CombineDietMenüRecipe", b =>
                {
                    b.Property<int>("RecipeId")
                        .HasColumnType("int");

                    b.Property<int>("DietMenüId")
                        .HasColumnType("int");

                    b.HasKey("RecipeId", "DietMenüId");

                    b.HasIndex("DietMenüId");

                    b.ToTable("CombineDietMenüRecipe");
                });

            modelBuilder.Entity("app.entity.CombineDietRecipe", b =>
                {
                    b.Property<int>("DietId")
                        .HasColumnType("int");

                    b.Property<int>("RecipeId")
                        .HasColumnType("int");

                    b.HasKey("DietId", "RecipeId");

                    b.HasIndex("RecipeId");

                    b.ToTable("CombineDietRecipe");
                });

            modelBuilder.Entity("app.entity.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Gender")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RemaningDietPackages")
                        .HasColumnType("int");

                    b.Property<int>("RemaningPilatesPackages")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FirstName = "Dilek",
                            Gender = true,
                            LastName = "Karaca",
                            Mail = "dlk@gmail.com",
                            PhoneNumber = "5524673747",
                            RemaningDietPackages = 0,
                            RemaningPilatesPackages = 0,
                            UserId = "asdad"
                        },
                        new
                        {
                            Id = 2,
                            FirstName = "Sinem",
                            Gender = true,
                            LastName = "Karaca",
                            Mail = "dlk@gmail.com",
                            PhoneNumber = "5524673747",
                            RemaningDietPackages = 0,
                            RemaningPilatesPackages = 0,
                            UserId = "asdad"
                        },
                        new
                        {
                            Id = 3,
                            FirstName = "Muammer",
                            Gender = false,
                            LastName = "Karaca",
                            Mail = "dlk@gmail.com",
                            PhoneNumber = "5524673747",
                            RemaningDietPackages = 0,
                            RemaningPilatesPackages = 0,
                            UserId = "asdad"
                        },
                        new
                        {
                            Id = 4,
                            FirstName = "Ercan",
                            Gender = false,
                            LastName = "Karaca",
                            Mail = "dlk@gmail.com",
                            PhoneNumber = "5524673747",
                            RemaningDietPackages = 0,
                            RemaningPilatesPackages = 0,
                            UserId = "asdad"
                        },
                        new
                        {
                            Id = 5,
                            FirstName = "Mustafa",
                            Gender = false,
                            LastName = "Karaca",
                            Mail = "dlk@gmail.com",
                            PhoneNumber = "5524673747",
                            RemaningDietPackages = 0,
                            RemaningPilatesPackages = 0,
                            UserId = "asdad"
                        },
                        new
                        {
                            Id = 6,
                            FirstName = "Sercan",
                            Gender = false,
                            LastName = "Karaca",
                            Mail = "dlk@gmail.com",
                            PhoneNumber = "5524673747",
                            RemaningDietPackages = 0,
                            RemaningPilatesPackages = 0,
                            UserId = "asdad"
                        },
                        new
                        {
                            Id = 7,
                            FirstName = "Güven",
                            Gender = false,
                            LastName = "Karaca",
                            Mail = "dlk@gmail.com",
                            PhoneNumber = "5524673747",
                            RemaningDietPackages = 0,
                            RemaningPilatesPackages = 0,
                            UserId = "asdad"
                        });
                });

            modelBuilder.Entity("app.entity.DateRequest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RequestTİme")
                        .HasColumnType("datetime2");

                    b.Property<int>("WeekId")
                        .HasColumnType("int");

                    b.Property<int>("typeOfRequest")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("dateRequests");
                });

            modelBuilder.Entity("app.entity.Diet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId")
                        .IsUnique();

                    b.ToTable("Diets");
                });

            modelBuilder.Entity("app.entity.DietMenü", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DietWekklyId")
                        .HasColumnType("int");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Gender")
                        .HasColumnType("bit");

                    b.Property<string>("Path")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoMeals")
                        .HasColumnType("bit");

                    b.Property<int>("Weight")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DietWekklyId")
                        .IsUnique();

                    b.ToTable("DietMenüs");
                });

            modelBuilder.Entity("app.entity.DietWekkly", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("DateTime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Detox")
                        .HasColumnType("bit");

                    b.Property<int>("DietId")
                        .HasColumnType("int");

                    b.Property<int>("Dietuyumluluk")
                        .HasColumnType("int");

                    b.Property<bool>("GivedDate")
                        .HasColumnType("bit");

                    b.Property<float>("GüncelBel")
                        .HasColumnType("real");

                    b.Property<float>("GüncelGögüs")
                        .HasColumnType("real");

                    b.Property<float>("GüncelKalca")
                        .HasColumnType("real");

                    b.Property<float>("GüncelKilo")
                        .HasColumnType("real");

                    b.Property<bool>("IsDone")
                        .HasColumnType("bit");

                    b.Property<bool>("IsUpdate")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ortSu")
                        .HasColumnType("int");

                    b.Property<int>("ortalamaAdim")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DietId");

                    b.ToTable("DietWekklies");
                });

            modelBuilder.Entity("app.entity.GeneralMesaj", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AlertType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Time")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("href")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("GeneralMesajs");
                });

            modelBuilder.Entity("app.entity.MyCart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<bool>("IsPaid")
                        .HasColumnType("bit");

                    b.Property<string>("PaidType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<string>("ProductName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Time")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("MyCarts");
                });

            modelBuilder.Entity("app.entity.PackageRequest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RequestTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("typeOfRequest")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("packageRequests");
                });

            modelBuilder.Entity("app.entity.Pilates", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId")
                        .IsUnique();

                    b.ToTable("Pilateis");
                });

            modelBuilder.Entity("app.entity.PilatesWeek", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsDone")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PilatesId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PilatesId");

                    b.ToTable("PilatesWeeks");
                });

            modelBuilder.Entity("app.entity.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("app.entity.Recipe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Recipes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Active = true,
                            Name = "Salata Tarifi"
                        },
                        new
                        {
                            Id = 2,
                            Active = true,
                            Name = "Kabak Tarifi"
                        },
                        new
                        {
                            Id = 3,
                            Active = true,
                            Name = "Tuzlu Tarifi"
                        },
                        new
                        {
                            Id = 4,
                            Active = true,
                            Name = "Omlet Tarifi"
                        },
                        new
                        {
                            Id = 5,
                            Active = true,
                            Name = "Su Tarifi"
                        },
                        new
                        {
                            Id = 6,
                            Active = true,
                            Name = "Kahve Tarifi"
                        },
                        new
                        {
                            Id = 7,
                            Active = true,
                            Name = "Karnıbahar Tarifi"
                        });
                });

            modelBuilder.Entity("app.entity.AnamnezForm", b =>
                {
                    b.HasOne("app.entity.Diet", "Diet")
                        .WithOne("AnamnezForm")
                        .HasForeignKey("app.entity.AnamnezForm", "DietId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Diet");
                });

            modelBuilder.Entity("app.entity.Calendar", b =>
                {
                    b.HasOne("app.entity.DietWekkly", "DietWekkly")
                        .WithOne("Calendar")
                        .HasForeignKey("app.entity.Calendar", "DietWekklyId");

                    b.HasOne("app.entity.PilatesWeek", "PilatesWeek")
                        .WithOne("calendar")
                        .HasForeignKey("app.entity.Calendar", "PilatesWeekId");

                    b.Navigation("DietWekkly");

                    b.Navigation("PilatesWeek");
                });

            modelBuilder.Entity("app.entity.CombineDietMenüRecipe", b =>
                {
                    b.HasOne("app.entity.DietMenü", "DietMenü")
                        .WithMany("CombineDietMenüRecipes")
                        .HasForeignKey("DietMenüId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("app.entity.Recipe", "Recipe")
                        .WithMany("CombineDietMenüRecipes")
                        .HasForeignKey("RecipeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DietMenü");

                    b.Navigation("Recipe");
                });

            modelBuilder.Entity("app.entity.CombineDietRecipe", b =>
                {
                    b.HasOne("app.entity.Diet", "Diet")
                        .WithMany("CombineDietRecipes")
                        .HasForeignKey("DietId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("app.entity.Recipe", "Recipe")
                        .WithMany("CombineDietRecipes")
                        .HasForeignKey("RecipeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Diet");

                    b.Navigation("Recipe");
                });

            modelBuilder.Entity("app.entity.Diet", b =>
                {
                    b.HasOne("app.entity.Customer", "Customer")
                        .WithOne("Diet")
                        .HasForeignKey("app.entity.Diet", "CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("app.entity.DietMenü", b =>
                {
                    b.HasOne("app.entity.DietWekkly", "DietWekkly")
                        .WithOne("DietMenü")
                        .HasForeignKey("app.entity.DietMenü", "DietWekklyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DietWekkly");
                });

            modelBuilder.Entity("app.entity.DietWekkly", b =>
                {
                    b.HasOne("app.entity.Diet", "Diet")
                        .WithMany("DietWekklies")
                        .HasForeignKey("DietId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Diet");
                });

            modelBuilder.Entity("app.entity.MyCart", b =>
                {
                    b.HasOne("app.entity.Customer", "customer")
                        .WithMany("MyCarts")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("customer");
                });

            modelBuilder.Entity("app.entity.Pilates", b =>
                {
                    b.HasOne("app.entity.Customer", "Customer")
                        .WithOne("Pilates")
                        .HasForeignKey("app.entity.Pilates", "CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("app.entity.PilatesWeek", b =>
                {
                    b.HasOne("app.entity.Pilates", "Pilates")
                        .WithMany("PilatesWeeks")
                        .HasForeignKey("PilatesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pilates");
                });

            modelBuilder.Entity("app.entity.Product", b =>
                {
                    b.HasOne("app.entity.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("app.entity.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("app.entity.Customer", b =>
                {
                    b.Navigation("Diet");

                    b.Navigation("MyCarts");

                    b.Navigation("Pilates");
                });

            modelBuilder.Entity("app.entity.Diet", b =>
                {
                    b.Navigation("AnamnezForm");

                    b.Navigation("CombineDietRecipes");

                    b.Navigation("DietWekklies");
                });

            modelBuilder.Entity("app.entity.DietMenü", b =>
                {
                    b.Navigation("CombineDietMenüRecipes");
                });

            modelBuilder.Entity("app.entity.DietWekkly", b =>
                {
                    b.Navigation("Calendar");

                    b.Navigation("DietMenü");
                });

            modelBuilder.Entity("app.entity.Pilates", b =>
                {
                    b.Navigation("PilatesWeeks");
                });

            modelBuilder.Entity("app.entity.PilatesWeek", b =>
                {
                    b.Navigation("calendar");
                });

            modelBuilder.Entity("app.entity.Recipe", b =>
                {
                    b.Navigation("CombineDietMenüRecipes");

                    b.Navigation("CombineDietRecipes");
                });
#pragma warning restore 612, 618
        }
    }
}
