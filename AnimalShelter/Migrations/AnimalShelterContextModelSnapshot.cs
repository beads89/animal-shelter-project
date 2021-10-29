﻿// <auto-generated />
using AnimalShelter.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AnimalShelter.Migrations
{
    [DbContext(typeof(AnimalShelterContext))]
    partial class AnimalShelterContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("AnimalShelter.Models.Cat", b =>
                {
                    b.Property<int>("CatId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CatBreed")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("CatColor")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("CatGender")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("CatName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("CatId");

                    b.ToTable("Cats");

                    b.HasData(
                        new
                        {
                            CatId = 1,
                            CatBreed = "Chocolate York",
                            CatColor = "Black, Grey",
                            CatGender = "Female",
                            CatName = "Toey"
                        },
                        new
                        {
                            CatId = 2,
                            CatBreed = "Bandle",
                            CatColor = "Blue, Yellow",
                            CatGender = "Female",
                            CatName = "Yuumi"
                        },
                        new
                        {
                            CatId = 3,
                            CatBreed = "Mixed, Calico, Tabby",
                            CatColor = "White, Brown, Cream",
                            CatGender = "Female",
                            CatName = "Tardar Sauce"
                        },
                        new
                        {
                            CatId = 4,
                            CatBreed = "Sphynx",
                            CatColor = "Naked",
                            CatGender = "Male",
                            CatName = "Mr. Bigglesworth"
                        });
                });

            modelBuilder.Entity("AnimalShelter.Models.Dog", b =>
                {
                    b.Property<int>("DogId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("DogBreed")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("DogColor")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("DogGender")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("DogName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("DogId");

                    b.ToTable("Dogs");

                    b.HasData(
                        new
                        {
                            DogId = 1,
                            DogBreed = "Mixed, Pitbull, Terrier, Australian Shepherd",
                            DogColor = "Black, White",
                            DogGender = "Male",
                            DogName = "Loki"
                        },
                        new
                        {
                            DogId = 2,
                            DogBreed = "Mixed, Pitbull, Terrier",
                            DogColor = "Black, White",
                            DogGender = "Female",
                            DogName = "Brandie"
                        },
                        new
                        {
                            DogId = 3,
                            DogBreed = "Mixed, Vizsla, Hound, Bloodhound",
                            DogColor = "Red",
                            DogGender = "Male",
                            DogName = "Clifford"
                        },
                        new
                        {
                            DogId = 4,
                            DogBreed = "Siberian Husky",
                            DogColor = "Black, White",
                            DogGender = "Male",
                            DogName = "Balto"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
