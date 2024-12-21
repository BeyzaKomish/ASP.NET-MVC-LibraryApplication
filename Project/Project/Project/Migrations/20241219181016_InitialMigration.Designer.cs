﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Project.Data;

#nullable disable

namespace Project.Migrations
{
    [DbContext(typeof(LibraryDbContext))]
    [Migration("20241219181016_InitialMigration")]
    partial class InitialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.10");

            modelBuilder.Entity("AuthorBook", b =>
                {
                    b.Property<int>("AuthorsId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("BooksID")
                        .HasColumnType("INTEGER");

                    b.HasKey("AuthorsId", "BooksID");

                    b.HasIndex("BooksID");

                    b.ToTable("AuthorBook");

                    b.HasData(
                        new
                        {
                            AuthorsId = 1,
                            BooksID = 1
                        },
                        new
                        {
                            AuthorsId = 2,
                            BooksID = 1
                        },
                        new
                        {
                            AuthorsId = 8,
                            BooksID = 2
                        },
                        new
                        {
                            AuthorsId = 2,
                            BooksID = 3
                        },
                        new
                        {
                            AuthorsId = 4,
                            BooksID = 3
                        },
                        new
                        {
                            AuthorsId = 5,
                            BooksID = 3
                        },
                        new
                        {
                            AuthorsId = 3,
                            BooksID = 4
                        },
                        new
                        {
                            AuthorsId = 2,
                            BooksID = 5
                        },
                        new
                        {
                            AuthorsId = 3,
                            BooksID = 6
                        },
                        new
                        {
                            AuthorsId = 2,
                            BooksID = 7
                        },
                        new
                        {
                            AuthorsId = 5,
                            BooksID = 7
                        },
                        new
                        {
                            AuthorsId = 7,
                            BooksID = 8
                        },
                        new
                        {
                            AuthorsId = 7,
                            BooksID = 9
                        },
                        new
                        {
                            AuthorsId = 4,
                            BooksID = 9
                        },
                        new
                        {
                            AuthorsId = 1,
                            BooksID = 10
                        },
                        new
                        {
                            AuthorsId = 6,
                            BooksID = 10
                        });
                });

            modelBuilder.Entity("BookCategory", b =>
                {
                    b.Property<int>("BooksID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoriesId")
                        .HasColumnType("INTEGER");

                    b.HasKey("BooksID", "CategoriesId");

                    b.HasIndex("CategoriesId");

                    b.ToTable("BookCategory");

                    b.HasData(
                        new
                        {
                            BooksID = 1,
                            CategoriesId = 1
                        },
                        new
                        {
                            BooksID = 1,
                            CategoriesId = 2
                        },
                        new
                        {
                            BooksID = 2,
                            CategoriesId = 1
                        },
                        new
                        {
                            BooksID = 2,
                            CategoriesId = 2
                        },
                        new
                        {
                            BooksID = 3,
                            CategoriesId = 2
                        },
                        new
                        {
                            BooksID = 3,
                            CategoriesId = 3
                        },
                        new
                        {
                            BooksID = 4,
                            CategoriesId = 3
                        },
                        new
                        {
                            BooksID = 5,
                            CategoriesId = 3
                        },
                        new
                        {
                            BooksID = 6,
                            CategoriesId = 1
                        },
                        new
                        {
                            BooksID = 7,
                            CategoriesId = 1
                        },
                        new
                        {
                            BooksID = 7,
                            CategoriesId = 2
                        },
                        new
                        {
                            BooksID = 8,
                            CategoriesId = 1
                        },
                        new
                        {
                            BooksID = 9,
                            CategoriesId = 3
                        },
                        new
                        {
                            BooksID = 10,
                            CategoriesId = 2
                        });
                });

            modelBuilder.Entity("BookGenre", b =>
                {
                    b.Property<int>("BooksID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("GenresId")
                        .HasColumnType("INTEGER");

                    b.HasKey("BooksID", "GenresId");

                    b.HasIndex("GenresId");

                    b.ToTable("BookGenre");

                    b.HasData(
                        new
                        {
                            BooksID = 1,
                            GenresId = 1
                        },
                        new
                        {
                            BooksID = 1,
                            GenresId = 2
                        },
                        new
                        {
                            BooksID = 2,
                            GenresId = 2
                        },
                        new
                        {
                            BooksID = 3,
                            GenresId = 2
                        },
                        new
                        {
                            BooksID = 3,
                            GenresId = 4
                        },
                        new
                        {
                            BooksID = 3,
                            GenresId = 5
                        },
                        new
                        {
                            BooksID = 4,
                            GenresId = 3
                        },
                        new
                        {
                            BooksID = 5,
                            GenresId = 2
                        },
                        new
                        {
                            BooksID = 6,
                            GenresId = 3
                        },
                        new
                        {
                            BooksID = 7,
                            GenresId = 2
                        },
                        new
                        {
                            BooksID = 7,
                            GenresId = 5
                        },
                        new
                        {
                            BooksID = 8,
                            GenresId = 2
                        },
                        new
                        {
                            BooksID = 9,
                            GenresId = 2
                        },
                        new
                        {
                            BooksID = 9,
                            GenresId = 4
                        },
                        new
                        {
                            BooksID = 10,
                            GenresId = 1
                        },
                        new
                        {
                            BooksID = 10,
                            GenresId = 6
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
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderKey")
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
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Project.Models.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "J.R.R. Tolkien"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Agatha Christie"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Haruki Murakami"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Isaac Asimov"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Mark Twain"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Ernest Hemingway"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Virginia Woolf"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Emily Brontë"
                        });
                });

            modelBuilder.Entity("Project.Models.Book", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Author")
                        .HasColumnType("TEXT");

                    b.Property<string>("ISBN")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsBorrowed")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("PublishedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("StudentId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.HasIndex("StudentId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Author = "John Doe",
                            ISBN = "1234567890",
                            IsBorrowed = false,
                            PublishedDate = new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "C# programming"
                        },
                        new
                        {
                            ID = 2,
                            Author = "Thomas H. Cormen",
                            ISBN = "9876543210",
                            IsBorrowed = false,
                            PublishedDate = new DateTime(2019, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Introduction to Algorithms"
                        },
                        new
                        {
                            ID = 3,
                            Author = "Robert C. Martin",
                            ISBN = "1122334455",
                            IsBorrowed = false,
                            PublishedDate = new DateTime(2008, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Action and Romance Code"
                        },
                        new
                        {
                            ID = 4,
                            Author = "Erich Gamma",
                            ISBN = "6677889900",
                            IsBorrowed = false,
                            PublishedDate = new DateTime(1994, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Design Patterns: Elements of Reusable Object-Oriented Software"
                        },
                        new
                        {
                            ID = 5,
                            Author = "Joshua Bloch",
                            ISBN = "4433221100",
                            IsBorrowed = false,
                            PublishedDate = new DateTime(2018, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Effective Java"
                        },
                        new
                        {
                            ID = 6,
                            Author = "Kyle Simpson",
                            ISBN = "3344556677",
                            IsBorrowed = false,
                            PublishedDate = new DateTime(2015, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "You Don't Real JS"
                        },
                        new
                        {
                            ID = 7,
                            Author = "Andrew Hunt",
                            ISBN = "9988776655",
                            IsBorrowed = false,
                            PublishedDate = new DateTime(1999, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "The Pragmatic Action"
                        },
                        new
                        {
                            ID = 8,
                            Author = "Eric Freeman",
                            ISBN = "5566778899",
                            IsBorrowed = false,
                            PublishedDate = new DateTime(2004, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Fake Design Patterns"
                        },
                        new
                        {
                            ID = 9,
                            Author = "Eric Matthes",
                            ISBN = "4455667788",
                            IsBorrowed = false,
                            PublishedDate = new DateTime(2015, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Python Love"
                        },
                        new
                        {
                            ID = 10,
                            Author = "Frederick P. Brooks Jr.",
                            ISBN = "7788990011",
                            IsBorrowed = false,
                            PublishedDate = new DateTime(1975, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "The Mythical History of Month"
                        });
                });

            modelBuilder.Entity("Project.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Reference"
                        },
                        new
                        {
                            Id = 2,
                            Name = "TextBook"
                        },
                        new
                        {
                            Id = 3,
                            Name = "BestSeller"
                        });
                });

            modelBuilder.Entity("Project.Models.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Science"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Programming"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Science Fiction"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Romance"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Action"
                        },
                        new
                        {
                            Id = 6,
                            Name = "History"
                        });
                });

            modelBuilder.Entity("Project.Models.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("BookId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("StudentId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.HasIndex("StudentId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("Project.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Adress")
                        .HasColumnType("TEXT");

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

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
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

                    b.Property<string>("UserType")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasDiscriminator<string>("UserType").HasValue("User");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Project.Models.Librarian", b =>
                {
                    b.HasBaseType("Project.Models.User");

                    b.Property<string>("Department")
                        .HasColumnType("TEXT");

                    b.Property<string>("EmployeeID")
                        .HasColumnType("TEXT");

                    b.HasDiscriminator().HasValue("Librarian");
                });

            modelBuilder.Entity("Project.Models.Student", b =>
                {
                    b.HasBaseType("Project.Models.User");

                    b.Property<string>("GPA")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("StudentID")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasDiscriminator().HasValue("Student");
                });

            modelBuilder.Entity("AuthorBook", b =>
                {
                    b.HasOne("Project.Models.Author", null)
                        .WithMany()
                        .HasForeignKey("AuthorsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Project.Models.Book", null)
                        .WithMany()
                        .HasForeignKey("BooksID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BookCategory", b =>
                {
                    b.HasOne("Project.Models.Book", null)
                        .WithMany()
                        .HasForeignKey("BooksID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Project.Models.Category", null)
                        .WithMany()
                        .HasForeignKey("CategoriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BookGenre", b =>
                {
                    b.HasOne("Project.Models.Book", null)
                        .WithMany()
                        .HasForeignKey("BooksID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Project.Models.Genre", null)
                        .WithMany()
                        .HasForeignKey("GenresId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
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
                    b.HasOne("Project.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Project.Models.User", null)
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

                    b.HasOne("Project.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Project.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Project.Models.Book", b =>
                {
                    b.HasOne("Project.Models.Student", "Student")
                        .WithMany("BorrowedBooks")
                        .HasForeignKey("StudentId");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("Project.Models.Review", b =>
                {
                    b.HasOne("Project.Models.Book", "Book")
                        .WithMany("Reviews")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Project.Models.Student", "Student")
                        .WithMany("Reviews")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Book");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("Project.Models.Book", b =>
                {
                    b.Navigation("Reviews");
                });

            modelBuilder.Entity("Project.Models.Student", b =>
                {
                    b.Navigation("BorrowedBooks");

                    b.Navigation("Reviews");
                });
#pragma warning restore 612, 618
        }
    }
}
