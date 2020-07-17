﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebAppNLayerBlog.DataAccessLayer.Data;

namespace WebAppNLayerBlog.DataAccessLayer.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("varchar(128)")
                        .HasMaxLength(128);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasMaxLength(128);

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("varchar(128)")
                        .HasMaxLength(128);

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasMaxLength(128);

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(128)")
                        .HasMaxLength(128);

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasColumnType("varchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(128)")
                        .HasMaxLength(128);

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("RoleId")
                        .HasColumnType("varchar(128)")
                        .HasMaxLength(128);

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasColumnType("varchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("WebAppNLayerBlog.DataAccessLayer.Models.Bookmark", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("PostId")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .HasColumnType("varchar(128)");

                    b.HasKey("Id");

                    b.HasIndex("PostId");

                    b.HasIndex("UserId");

                    b.ToTable("Bookmarks");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            PostId = 1,
                            UserId = "773a524b-99af-4fe3-b950-0f7d8ff82b0e"
                        },
                        new
                        {
                            Id = 2,
                            PostId = 2,
                            UserId = "773a524b-99af-4fe3-b950-0f7d8ff82b0e"
                        });
                });

            modelBuilder.Entity("WebAppNLayerBlog.DataAccessLayer.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "IT"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Travel"
                        });
                });

            modelBuilder.Entity("WebAppNLayerBlog.DataAccessLayer.Models.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime");

                    b.Property<int>("PostId")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .HasColumnType("varchar(128)");

                    b.HasKey("Id");

                    b.HasIndex("PostId");

                    b.HasIndex("UserId");

                    b.ToTable("Comments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateTime = new DateTime(2020, 7, 17, 15, 20, 46, 934, DateTimeKind.Local).AddTicks(1692),
                            PostId = 1,
                            Text = "Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                            UserId = "773a524b-99af-4fe3-b950-0f7d8ff82b0e"
                        },
                        new
                        {
                            Id = 2,
                            DateTime = new DateTime(2020, 7, 17, 15, 20, 46, 934, DateTimeKind.Local).AddTicks(2408),
                            PostId = 2,
                            Text = "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.",
                            UserId = "773a524b-99af-4fe3-b950-0f7d8ff82b0e"
                        });
                });

            modelBuilder.Entity("WebAppNLayerBlog.DataAccessLayer.Models.Media", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Path")
                        .HasColumnType("text");

                    b.Property<int>("PostId")
                        .HasColumnType("int");

                    b.Property<int>("TypeMediaId")
                        .HasColumnType("int");

                    b.Property<string>("Url")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("PostId");

                    b.HasIndex("TypeMediaId");

                    b.ToTable("Medias");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "youtube",
                            PostId = 1,
                            TypeMediaId = 1,
                            Url = "https://www.youtube.com/watch?v=BggrpKfqh1c"
                        },
                        new
                        {
                            Id = 2,
                            Name = "freesound",
                            PostId = 2,
                            TypeMediaId = 2,
                            Url = "https://freesound.org/people/Lorem%20Ipsum/downloaded_sounds/"
                        });
                });

            modelBuilder.Entity("WebAppNLayerBlog.DataAccessLayer.Models.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Subtitle")
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Posts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            DateTime = new DateTime(2020, 7, 17, 15, 20, 46, 905, DateTimeKind.Local).AddTicks(9364),
                            Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit.",
                            Subtitle = "Aenean massa",
                            Title = "Lorem ipsum dolor sit amet"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 2,
                            DateTime = new DateTime(2020, 7, 17, 15, 20, 46, 909, DateTimeKind.Local).AddTicks(5149),
                            Description = "Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.",
                            Subtitle = "Donec quam felis",
                            Title = "Cum sociis natoque penatibus et magnis dis parturient montes"
                        });
                });

            modelBuilder.Entity("WebAppNLayerBlog.DataAccessLayer.Models.Resource", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("PostId")
                        .HasColumnType("int");

                    b.Property<string>("Url")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("PostId");

                    b.ToTable("Resources");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "blindtextgenerator",
                            PostId = 1,
                            Url = "https://www.blindtextgenerator.com/ru"
                        },
                        new
                        {
                            Id = 2,
                            Name = "loremipsum",
                            PostId = 2,
                            Url = "https://loremipsum.io/ru/"
                        });
                });

            modelBuilder.Entity("WebAppNLayerBlog.DataAccessLayer.Models.TypeMedia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("TypeMedias");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "video"
                        },
                        new
                        {
                            Id = 2,
                            Name = "audio"
                        });
                });

            modelBuilder.Entity("WebAppNLayerBlog.DataAccessLayer.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(128)")
                        .HasMaxLength(128);

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasColumnType("varchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("varchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("varchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("varchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new
                        {
                            Id = "773a524b-99af-4fe3-b950-0f7d8ff82b0e",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "da27a8eb-0958-4eec-b69e-ec65f3e690f7",
                            Email = "tester@test.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "TESTER@TEST.COM",
                            NormalizedUserName = "TESTER",
                            PasswordHash = "AQAAAAEAACcQAAAAEBDHr5+AgJ5BIn0fcvWqrjV99HxcOMNPMqARrlxNKHc89cOh/ivS5uCGm+HSZHaRjA==",
                            PhoneNumber = "123456789",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "525701ac-da0f-4c85-8b4e-1ba4dd982656",
                            TwoFactorEnabled = false,
                            UserName = "tester"
                        });
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
                    b.HasOne("WebAppNLayerBlog.DataAccessLayer.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("WebAppNLayerBlog.DataAccessLayer.Models.User", null)
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

                    b.HasOne("WebAppNLayerBlog.DataAccessLayer.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("WebAppNLayerBlog.DataAccessLayer.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebAppNLayerBlog.DataAccessLayer.Models.Bookmark", b =>
                {
                    b.HasOne("WebAppNLayerBlog.DataAccessLayer.Models.Post", "Post")
                        .WithMany("Bookmarks")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebAppNLayerBlog.DataAccessLayer.Models.User", "User")
                        .WithMany("Bookmarks")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("WebAppNLayerBlog.DataAccessLayer.Models.Comment", b =>
                {
                    b.HasOne("WebAppNLayerBlog.DataAccessLayer.Models.Post", "Post")
                        .WithMany("Comments")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebAppNLayerBlog.DataAccessLayer.Models.User", "User")
                        .WithMany("Comments")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("WebAppNLayerBlog.DataAccessLayer.Models.Media", b =>
                {
                    b.HasOne("WebAppNLayerBlog.DataAccessLayer.Models.Post", "Post")
                        .WithMany("Medias")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebAppNLayerBlog.DataAccessLayer.Models.TypeMedia", "TypeMedia")
                        .WithMany("Medias")
                        .HasForeignKey("TypeMediaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebAppNLayerBlog.DataAccessLayer.Models.Post", b =>
                {
                    b.HasOne("WebAppNLayerBlog.DataAccessLayer.Models.Category", "Category")
                        .WithMany("Posts")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebAppNLayerBlog.DataAccessLayer.Models.Resource", b =>
                {
                    b.HasOne("WebAppNLayerBlog.DataAccessLayer.Models.Post", "Post")
                        .WithMany("Resources")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
