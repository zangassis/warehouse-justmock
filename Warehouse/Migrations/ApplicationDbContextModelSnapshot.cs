// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Warehouse.Data;

#nullable disable

namespace Warehouse.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.3");

            modelBuilder.Entity("Warehouse.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsCompleted")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ProductName")
                        .HasColumnType("TEXT");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsCompleted = false,
                            ProductName = "ProductExample1",
                            Quantity = 10
                        },
                        new
                        {
                            Id = 2,
                            IsCompleted = false,
                            ProductName = "ProductExample2",
                            Quantity = 20
                        },
                        new
                        {
                            Id = 3,
                            IsCompleted = false,
                            ProductName = "ProductExample3",
                            Quantity = 30
                        },
                        new
                        {
                            Id = 4,
                            IsCompleted = false,
                            ProductName = "ProductExample4",
                            Quantity = 40
                        },
                        new
                        {
                            Id = 5,
                            IsCompleted = false,
                            ProductName = "ProductExample5",
                            Quantity = 50
                        },
                        new
                        {
                            Id = 6,
                            IsCompleted = false,
                            ProductName = "ProductExample6",
                            Quantity = 60
                        },
                        new
                        {
                            Id = 7,
                            IsCompleted = false,
                            ProductName = "ProductExample7",
                            Quantity = 70
                        },
                        new
                        {
                            Id = 8,
                            IsCompleted = false,
                            ProductName = "ProductExample8",
                            Quantity = 80
                        },
                        new
                        {
                            Id = 9,
                            IsCompleted = false,
                            ProductName = "ProductExample9",
                            Quantity = 90
                        },
                        new
                        {
                            Id = 10,
                            IsCompleted = false,
                            ProductName = "ProductExample10",
                            Quantity = 100
                        },
                        new
                        {
                            Id = 11,
                            IsCompleted = false,
                            ProductName = "ProductExample11",
                            Quantity = 110
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
