// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using lab.Data;

#nullable disable

namespace lab.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.0");

            modelBuilder.Entity("lab.Models.Student", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("Department")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            Id = "2",
                            Department = "Mining",
                            FirstName = "Ann",
                            LastName = "Fay"
                        },
                        new
                        {
                            Id = "3",
                            Department = "Nursing",
                            FirstName = "Joe",
                            LastName = "Sun"
                        },
                        new
                        {
                            Id = "4",
                            Department = "Mining",
                            FirstName = "Ben",
                            LastName = "Ray"
                        },
                        new
                        {
                            Id = "5",
                            Department = "Business",
                            FirstName = "Zoe",
                            LastName = "Cox"
                        },
                        new
                        {
                            Id = "6",
                            Department = "Mining",
                            FirstName = "Sam",
                            LastName = "Ray"
                        },
                        new
                        {
                            Id = "7",
                            Department = "Medicine",
                            FirstName = "Dan",
                            LastName = "Ash"
                        },
                        new
                        {
                            Id = "8",
                            Department = "Computing",
                            FirstName = "Pat",
                            LastName = "Lee"
                        },
                        new
                        {
                            Id = "9",
                            Department = "Science",
                            FirstName = "Kim",
                            LastName = "Day"
                        },
                        new
                        {
                            Id = "10",
                            Department = "Computing",
                            FirstName = "Tim",
                            LastName = "Rex"
                        },
                        new
                        {
                            Id = "11",
                            Department = "Business",
                            FirstName = "Rob",
                            LastName = "Ram"
                        },
                        new
                        {
                            Id = "12",
                            Department = "Mining",
                            FirstName = "Jan",
                            LastName = "Fry"
                        },
                        new
                        {
                            Id = "13",
                            Department = "Science",
                            FirstName = "Jim",
                            LastName = "Tex"
                        },
                        new
                        {
                            Id = "14",
                            Department = "Business",
                            FirstName = "Ben",
                            LastName = "Kid"
                        },
                        new
                        {
                            Id = "15",
                            Department = "Medicine",
                            FirstName = "Mia",
                            LastName = "Chu"
                        },
                        new
                        {
                            Id = "16",
                            Department = "Computing",
                            FirstName = "Ted",
                            LastName = "Tao"
                        },
                        new
                        {
                            Id = "17",
                            Department = "Business",
                            FirstName = "Amy",
                            LastName = "Day"
                        },
                        new
                        {
                            Id = "18",
                            Department = "Science",
                            FirstName = "Ian",
                            LastName = "Roy"
                        },
                        new
                        {
                            Id = "19",
                            Department = "Nursing",
                            FirstName = "Liz",
                            LastName = "Kit"
                        },
                        new
                        {
                            Id = "20",
                            Department = "Medicine",
                            FirstName = "Mat",
                            LastName = "Tan"
                        },
                        new
                        {
                            Id = "21",
                            Department = "Medicine",
                            FirstName = "Deb",
                            LastName = "Roy"
                        },
                        new
                        {
                            Id = "22",
                            Department = "Tourism",
                            FirstName = "Ana",
                            LastName = "Ray"
                        },
                        new
                        {
                            Id = "23",
                            Department = "Computing",
                            FirstName = "Lyn",
                            LastName = "Poe"
                        },
                        new
                        {
                            Id = "24",
                            Department = "Science",
                            FirstName = "Amy",
                            LastName = "Raj"
                        },
                        new
                        {
                            Id = "25",
                            Department = "Mining",
                            FirstName = "Kim",
                            LastName = "Ash"
                        },
                        new
                        {
                            Id = "26",
                            Department = "Nursing",
                            FirstName = "Bec",
                            LastName = "Kid"
                        },
                        new
                        {
                            Id = "27",
                            Department = "Computing",
                            FirstName = "Eva",
                            LastName = "Fry"
                        },
                        new
                        {
                            Id = "28",
                            Department = "Business",
                            FirstName = "Eli",
                            LastName = "Lap"
                        },
                        new
                        {
                            Id = "29",
                            Department = "Science",
                            FirstName = "Sam",
                            LastName = "Yim"
                        },
                        new
                        {
                            Id = "30",
                            Department = "Mining",
                            FirstName = "Joe",
                            LastName = "Hui"
                        },
                        new
                        {
                            Id = "31",
                            Department = "Nursing",
                            FirstName = "Liz",
                            LastName = "Jin"
                        },
                        new
                        {
                            Id = "32",
                            Department = "Linguistics",
                            FirstName = "Ric",
                            LastName = "Kuo"
                        },
                        new
                        {
                            Id = "33",
                            Department = "Computing",
                            FirstName = "Pam",
                            LastName = "Mak"
                        },
                        new
                        {
                            Id = "34",
                            Department = "Business",
                            FirstName = "Stu",
                            LastName = "Day"
                        },
                        new
                        {
                            Id = "35",
                            Department = "Tourism",
                            FirstName = "Tom",
                            LastName = "Gad"
                        },
                        new
                        {
                            Id = "36",
                            Department = "Agriculture",
                            FirstName = "Bob",
                            LastName = "Bee"
                        },
                        new
                        {
                            Id = "37",
                            Department = "Agriculture",
                            FirstName = "Jim",
                            LastName = "Ots"
                        },
                        new
                        {
                            Id = "38",
                            Department = "Linguistics",
                            FirstName = "Tom",
                            LastName = "Mag"
                        },
                        new
                        {
                            Id = "39",
                            Department = "Mining",
                            FirstName = "Hal",
                            LastName = "Doe"
                        },
                        new
                        {
                            Id = "40",
                            Department = "Tourism",
                            FirstName = "Roy",
                            LastName = "Kim"
                        },
                        new
                        {
                            Id = "41",
                            Department = "Nursing",
                            FirstName = "Vis",
                            LastName = "Cox"
                        },
                        new
                        {
                            Id = "42",
                            Department = "Science",
                            FirstName = "Kay",
                            LastName = "Aga"
                        },
                        new
                        {
                            Id = "43",
                            Department = "Nursing",
                            FirstName = "Reo",
                            LastName = "Hui"
                        },
                        new
                        {
                            Id = "44",
                            Department = "Mining",
                            FirstName = "Bob",
                            LastName = "Roe"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
