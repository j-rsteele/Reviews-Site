// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ReviewsSite;

namespace ReviewsSite.Migrations
{
    [DbContext(typeof(Moviecontext))]
    [Migration("20211023125810_deleteddatacontentmod")]
    partial class deleteddatacontentmod
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ReviewsSite.Models.Actor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Actors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Bela Lugosi"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Helen Chandler"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Boris Karloff"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Lon Chaney Jr."
                        },
                        new
                        {
                            Id = 5,
                            Name = "John Carradine"
                        });
                });

            modelBuilder.Entity("ReviewsSite.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Award")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Genre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rating")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ReleaseYear")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Award = "none",
                            Genre = "Horror",
                            Rating = "NR",
                            ReleaseYear = 1931,
                            Title = "Dracula"
                        },
                        new
                        {
                            Id = 2,
                            Award = "none",
                            Genre = "Horror",
                            Rating = "NR",
                            ReleaseYear = 1944,
                            Title = "House of Frankenstein"
                        },
                        new
                        {
                            Id = 3,
                            Award = "Saturn",
                            Genre = "Horror",
                            Rating = "NR",
                            ReleaseYear = 1940,
                            Title = "The Mummy's Ghost"
                        });
                });

            modelBuilder.Entity("ReviewsSite.Models.MovieActors", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ActorId")
                        .HasColumnType("int");

                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ActorId");

                    b.HasIndex("MovieId");

                    b.ToTable("MovieActors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ActorId = 1,
                            MovieId = 1
                        },
                        new
                        {
                            Id = 2,
                            ActorId = 2,
                            MovieId = 1
                        },
                        new
                        {
                            Id = 3,
                            ActorId = 3,
                            MovieId = 2
                        },
                        new
                        {
                            Id = 4,
                            ActorId = 4,
                            MovieId = 2
                        },
                        new
                        {
                            Id = 5,
                            ActorId = 4,
                            MovieId = 3
                        },
                        new
                        {
                            Id = 6,
                            ActorId = 5,
                            MovieId = 3
                        });
                });

            modelBuilder.Entity("ReviewsSite.Models.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MovieId");

                    b.ToTable("Reviews");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Comment = "Dracula is easily one of the most influential horror films ever released. Released by Universal Pictures in 1931, Dracula starred Bela Lugosi as the titular vampire and effectively established the way that vampire stories would be told for the next century.  Lugosi's costume and mannerisms, including his iconic accent, have long been Dracula staples (\"I vant to suck your blood!\"), and future vampire stories borrowed heavily from the mythology and imagery of Dracula. It's an undisputed classic.",
                            MovieId = 1,
                            Name = "John Doe"
                        },
                        new
                        {
                            Id = 2,
                            Comment = "The horror story makes absolutely no sense, but it is so nutty that it makes for a diverting watch.",
                            MovieId = 2,
                            Name = "Jane Doe"
                        },
                        new
                        {
                            Id = 3,
                            Comment = "Another effort in laziness with scenes lifted directly from earlier Mummy films. Not fun.",
                            MovieId = 3,
                            Name = "Scott"
                        },
                        new
                        {
                            Id = 4,
                            Comment = "Great classic movie with all the trimmings.  The horror is b-grade at best, but very entertaining.",
                            MovieId = 2,
                            Name = "Kevin"
                        },
                        new
                        {
                            Id = 5,
                            Comment = "The movie has some good typical Unverisal '40's horror moments. Of course it's nothing too scary, at least not by today's standards but it's very classy and good looking all, with the use of shadows and some handy camera-work.",
                            MovieId = 3,
                            Name = "Paul Chambers"
                        });
                });

            modelBuilder.Entity("ReviewsSite.Models.MovieActors", b =>
                {
                    b.HasOne("ReviewsSite.Models.Actor", "Actor")
                        .WithMany("Movies")
                        .HasForeignKey("ActorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ReviewsSite.Models.Movie", "Movie")
                        .WithMany("Actors")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Actor");

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("ReviewsSite.Models.Review", b =>
                {
                    b.HasOne("ReviewsSite.Models.Movie", "Movie")
                        .WithMany("Reviews")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("ReviewsSite.Models.Actor", b =>
                {
                    b.Navigation("Movies");
                });

            modelBuilder.Entity("ReviewsSite.Models.Movie", b =>
                {
                    b.Navigation("Actors");

                    b.Navigation("Reviews");
                });
#pragma warning restore 612, 618
        }
    }
}
