using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using VideoGamesStorage_Description_and_list_.Model;

namespace VideoGamesStorage_Description_and_list_.Context
{
    public class ClassContext:DbContext
    {
        public DbSet<Games> games { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=MyRandomData;Integrated Security=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new GamesClassConfiguration());
        }
    }
    public  class GamesClassConfiguration:IEntityTypeConfiguration<Games>
    {
        public virtual void Configure(EntityTypeBuilder<Games> builder)
        {
            builder.ToTable("GameList");
            builder.HasKey(u=>u.GameId).HasName("game_id");
            builder.Property(u => u.Name).HasColumnName("game_name").HasMaxLength(25);
            builder.Property(u => u.AgeLimit).HasColumnName("age_limit").HasMaxLength(7);
            builder.ToTable(u => u.HasCheckConstraint("valueLimits", "age_limit= 'G' OR age_limit= 'PG' OR age_limit= 'PG-13' OR age_limit= 'R' OR age_limit= 'NC-17' "));
            builder.Property(u => u.Platform).HasColumnName("platform").HasMaxLength(20);
            builder.ToTable(u => u.HasCheckConstraint("platformLimits", "platform = 'Nintendo Switch' OR platform = 'Playstation 4' OR platform = 'Playstation 5' OR platform = 'PC' OR platform = 'Xbox One' "));
            builder.Property(u => u.Genre).HasColumnName("game_genre").HasMaxLength(20);
            builder.ToTable(u => u.HasCheckConstraint("genreLimits", "game_genre = 'Action' OR game_genre = 'RPG' OR game_genre = 'Shooter' OR game_genre = 'Puzzle' OR game_genre = 'Simulator'"));
            builder.Property(u => u.Price).HasColumnType("decimal(6,2)").HasColumnName("price");
            builder.Property(u => u.Description).HasDefaultValue("NO ENTRIES").HasMaxLength(300);
        }
    }
}
