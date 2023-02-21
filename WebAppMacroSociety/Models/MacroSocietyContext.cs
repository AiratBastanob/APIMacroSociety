using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace WebAppMacroSociety.Models
{
    public partial class MacroSocietyContext : DbContext
    {
        public MacroSocietyContext()
        {
        }

        public MacroSocietyContext(DbContextOptions<MacroSocietyContext> options)
            : base(options)
        {
        }

       
        public virtual DbSet<FriendList> FriendLists { get; set; }
        public virtual DbSet<FriendRequest> FriendRequests { get; set; }     
        public virtual DbSet<ListLevelUser> ListLevelUsers { get; set; }
        public virtual DbSet<ListMusicUser> ListMusicUsers { get; set; }       
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-ITHN38O\\SQLEXPRESS;Initial Catalog=MacroSociety;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Cyrillic_General_CI_AS");
          

            modelBuilder.Entity<FriendList>(entity =>
            {
                entity.ToTable("FriendList");

                entity.Property(e => e.Friendname)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.IdFriendname).HasColumnName("Id_Friendname");

                entity.Property(e => e.IdUsername).HasColumnName("Id_Username");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.IdFriendnameNavigation)
                    .WithMany(p => p.FriendListIdFriendnameNavigations)
                    .HasForeignKey(d => d.IdFriendname)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Friendlist_Users");

                entity.HasOne(d => d.IdUsernameNavigation)
                    .WithMany(p => p.FriendListIdUsernameNavigations)
                    .HasForeignKey(d => d.IdUsername)
                    .HasConstraintName("FK_Friendlist_Users1");
            });

            modelBuilder.Entity<FriendRequest>(entity =>
            {
                entity.Property(e => e.FutureFriend)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Future_friend");

                entity.Property(e => e.IdUser).HasColumnName("Id_user");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("User_name");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.FriendRequests)
                    .HasForeignKey(d => d.IdUser)
                    .HasConstraintName("FK_Friend_Requests_Users");
            });

           modelBuilder.Entity<ListLevelUser>(entity =>
            {
                entity.ToTable("ListLevelUser");

                entity.HasIndex(e => e.IdUser, "FK_List_Level_User")
                    .IsUnique();

                entity.Property(e => e.IdUser).HasColumnName("Id_user");

                entity.Property(e => e.Level1)
                    .IsRequired()
                    .HasMaxLength(4)
                    .HasColumnName("level1")
                    .HasDefaultValueSql("('Нет')");

                entity.Property(e => e.Level10)
                    .IsRequired()
                    .HasMaxLength(4)
                    .HasColumnName("level10")
                    .HasDefaultValueSql("('Нет')");

                entity.Property(e => e.Level11)
                    .IsRequired()
                    .HasMaxLength(4)
                    .HasColumnName("level11")
                    .HasDefaultValueSql("('Нет')");

                entity.Property(e => e.Level12)
                    .IsRequired()
                    .HasMaxLength(4)
                    .HasColumnName("level12")
                    .HasDefaultValueSql("('Нет')");

                entity.Property(e => e.Level13)
                    .IsRequired()
                    .HasMaxLength(4)
                    .HasColumnName("level13")
                    .HasDefaultValueSql("('Нет')");

                entity.Property(e => e.Level14)
                    .IsRequired()
                    .HasMaxLength(4)
                    .HasColumnName("level14")
                    .HasDefaultValueSql("('Нет')");

                entity.Property(e => e.Level15)
                    .IsRequired()
                    .HasMaxLength(4)
                    .HasColumnName("level15")
                    .HasDefaultValueSql("('Нет')");

                entity.Property(e => e.Level16)
                    .IsRequired()
                    .HasMaxLength(4)
                    .HasColumnName("level16")
                    .HasDefaultValueSql("('Нет')");

                entity.Property(e => e.Level17)
                    .IsRequired()
                    .HasMaxLength(4)
                    .HasColumnName("level17")
                    .HasDefaultValueSql("('Нет')");

                entity.Property(e => e.Level18)
                    .IsRequired()
                    .HasMaxLength(4)
                    .HasColumnName("level18")
                    .HasDefaultValueSql("('Нет')");

                entity.Property(e => e.Level19)
                    .IsRequired()
                    .HasMaxLength(4)
                    .HasColumnName("level19")
                    .HasDefaultValueSql("('Нет')");

                entity.Property(e => e.Level2)
                    .IsRequired()
                    .HasMaxLength(4)
                    .HasColumnName("level2")
                    .HasDefaultValueSql("('Нет')");

                entity.Property(e => e.Level20)
                    .IsRequired()
                    .HasMaxLength(4)
                    .HasColumnName("level20")
                    .HasDefaultValueSql("('Нет')");

                entity.Property(e => e.Level21)
                    .IsRequired()
                    .HasMaxLength(4)
                    .HasColumnName("level21")
                    .HasDefaultValueSql("('Нет')");

                entity.Property(e => e.Level22)
                    .IsRequired()
                    .HasMaxLength(4)
                    .HasColumnName("level22")
                    .HasDefaultValueSql("('Нет')");

                entity.Property(e => e.Level23)
                    .IsRequired()
                    .HasMaxLength(4)
                    .HasColumnName("level23")
                    .HasDefaultValueSql("('Нет')");

                entity.Property(e => e.Level24)
                    .IsRequired()
                    .HasMaxLength(4)
                    .HasColumnName("level24")
                    .HasDefaultValueSql("('Нет')");

                entity.Property(e => e.Level25)
                    .IsRequired()
                    .HasMaxLength(4)
                    .HasColumnName("level25")
                    .HasDefaultValueSql("('Нет')");

                entity.Property(e => e.Level26)
                    .IsRequired()
                    .HasMaxLength(4)
                    .HasColumnName("level26")
                    .HasDefaultValueSql("('Нет')");

                entity.Property(e => e.Level27)
                    .IsRequired()
                    .HasMaxLength(4)
                    .HasColumnName("level27")
                    .HasDefaultValueSql("('Нет')");

                entity.Property(e => e.Level28)
                    .IsRequired()
                    .HasMaxLength(4)
                    .HasColumnName("level28")
                    .HasDefaultValueSql("('Нет')");

                entity.Property(e => e.Level29)
                    .IsRequired()
                    .HasMaxLength(4)
                    .HasColumnName("level29")
                    .HasDefaultValueSql("('Нет')");

                entity.Property(e => e.Level3)
                    .IsRequired()
                    .HasMaxLength(4)
                    .HasColumnName("level3")
                    .HasDefaultValueSql("('Нет')");

                entity.Property(e => e.Level30)
                    .IsRequired()
                    .HasMaxLength(4)
                    .HasColumnName("level30")
                    .HasDefaultValueSql("('Нет')");

                entity.Property(e => e.Level31)
                    .IsRequired()
                    .HasMaxLength(4)
                    .HasColumnName("level31")
                    .HasDefaultValueSql("('Нет')");

                entity.Property(e => e.Level32)
                    .IsRequired()
                    .HasMaxLength(4)
                    .HasColumnName("level32")
                    .HasDefaultValueSql("('Нет')");

                entity.Property(e => e.Level33)
                    .IsRequired()
                    .HasMaxLength(4)
                    .HasColumnName("level33")
                    .HasDefaultValueSql("('Нет')");

                entity.Property(e => e.Level34)
                    .IsRequired()
                    .HasMaxLength(4)
                    .HasColumnName("level34")
                    .HasDefaultValueSql("('Нет')");

                entity.Property(e => e.Level35)
                    .IsRequired()
                    .HasMaxLength(4)
                    .HasColumnName("level35")
                    .HasDefaultValueSql("('Нет')");

                entity.Property(e => e.Level36)
                    .IsRequired()
                    .HasMaxLength(4)
                    .HasColumnName("level36")
                    .HasDefaultValueSql("('Нет')");

                entity.Property(e => e.Level37)
                    .IsRequired()
                    .HasMaxLength(4)
                    .HasColumnName("level37")
                    .HasDefaultValueSql("('Нет')");

                entity.Property(e => e.Level38)
                    .IsRequired()
                    .HasMaxLength(4)
                    .HasColumnName("level38")
                    .HasDefaultValueSql("('Нет')");

                entity.Property(e => e.Level39)
                    .IsRequired()
                    .HasMaxLength(4)
                    .HasColumnName("level39")
                    .HasDefaultValueSql("('Нет')");

                entity.Property(e => e.Level4)
                    .IsRequired()
                    .HasMaxLength(4)
                    .HasColumnName("level4")
                    .HasDefaultValueSql("('Нет')");

                entity.Property(e => e.Level40)
                    .IsRequired()
                    .HasMaxLength(4)
                    .HasColumnName("level40")
                    .HasDefaultValueSql("('Нет')");

                entity.Property(e => e.Level5)
                    .IsRequired()
                    .HasMaxLength(4)
                    .HasColumnName("level5")
                    .HasDefaultValueSql("('Нет')");

                entity.Property(e => e.Level6)
                    .IsRequired()
                    .HasMaxLength(4)
                    .HasColumnName("level6")
                    .HasDefaultValueSql("('Нет')");

                entity.Property(e => e.Level7)
                    .IsRequired()
                    .HasMaxLength(4)
                    .HasColumnName("level7")
                    .HasDefaultValueSql("('Нет')");

                entity.Property(e => e.Level8)
                    .IsRequired()
                    .HasMaxLength(4)
                    .HasColumnName("level8")
                    .HasDefaultValueSql("('Нет')");

                entity.Property(e => e.Level9)
                    .IsRequired()
                    .HasMaxLength(4)
                    .HasColumnName("level9")
                    .HasDefaultValueSql("('Нет')");

                entity.Property(e => e.NameUser)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Name_user");

                entity.Property(e => e.UserReceivedPrize)
                    .IsRequired()
                    .HasMaxLength(4)
                    .HasColumnName("User_received_prize")
                    .HasDefaultValueSql("('Нет')");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithOne(p => p.ListLevelUser)
                    .HasForeignKey<ListLevelUser>(d => d.IdUser)
                    .HasConstraintName("FK_List_Level_User_Users");
            });

            modelBuilder.Entity<ListMusicUser>(entity =>
            {
                entity.ToTable("ListMusicUser");

                entity.HasIndex(e => e.IdUser, "FK_List_Music_User")
                    .IsUnique();

                entity.Property(e => e.IdUser).HasColumnName("Id_User");

                entity.Property(e => e.Music1)
                    .IsRequired()
                    .HasMaxLength(4)
                    .HasColumnName("music1")
                    .HasDefaultValueSql("('Нет')");

                entity.Property(e => e.Music10)
                    .IsRequired()
                    .HasMaxLength(4)
                    .HasColumnName("music10")
                    .HasDefaultValueSql("('Нет')");

                entity.Property(e => e.Music11)
                    .IsRequired()
                    .HasMaxLength(4)
                    .HasColumnName("music11")
                    .HasDefaultValueSql("('Нет')");

                entity.Property(e => e.Music12)
                    .IsRequired()
                    .HasMaxLength(4)
                    .HasColumnName("music12")
                    .HasDefaultValueSql("('Нет')");

                entity.Property(e => e.Music13)
                    .IsRequired()
                    .HasMaxLength(4)
                    .HasColumnName("music13")
                    .HasDefaultValueSql("('Нет')");

                entity.Property(e => e.Music14)
                    .IsRequired()
                    .HasMaxLength(4)
                    .HasColumnName("music14")
                    .HasDefaultValueSql("('Нет')");

                entity.Property(e => e.Music15)
                    .IsRequired()
                    .HasMaxLength(4)
                    .HasColumnName("music15")
                    .HasDefaultValueSql("('Нет')");

                entity.Property(e => e.Music16)
                    .IsRequired()
                    .HasMaxLength(4)
                    .HasColumnName("music16")
                    .HasDefaultValueSql("('Нет')");

                entity.Property(e => e.Music17)
                    .IsRequired()
                    .HasMaxLength(4)
                    .HasColumnName("music17")
                    .HasDefaultValueSql("('Нет')");

                entity.Property(e => e.Music18)
                    .IsRequired()
                    .HasMaxLength(4)
                    .HasColumnName("music18")
                    .HasDefaultValueSql("('Нет')");

                entity.Property(e => e.Music19)
                    .IsRequired()
                    .HasMaxLength(4)
                    .HasColumnName("music19")
                    .HasDefaultValueSql("('Нет')");

                entity.Property(e => e.Music2)
                    .IsRequired()
                    .HasMaxLength(4)
                    .HasColumnName("music2")
                    .HasDefaultValueSql("('Нет')");

                entity.Property(e => e.Music20)
                    .IsRequired()
                    .HasMaxLength(4)
                    .HasColumnName("music20")
                    .HasDefaultValueSql("('Нет')");

                entity.Property(e => e.Music21)
                    .IsRequired()
                    .HasMaxLength(4)
                    .HasColumnName("music21")
                    .HasDefaultValueSql("('Нет')");

                entity.Property(e => e.Music22)
                    .IsRequired()
                    .HasMaxLength(4)
                    .HasColumnName("music22")
                    .HasDefaultValueSql("('Нет')");

                entity.Property(e => e.Music23)
                    .IsRequired()
                    .HasMaxLength(4)
                    .HasColumnName("music23")
                    .HasDefaultValueSql("('Нет')");

                entity.Property(e => e.Music24)
                    .IsRequired()
                    .HasMaxLength(4)
                    .HasColumnName("music24")
                    .HasDefaultValueSql("('Нет')");

                entity.Property(e => e.Music25)
                    .IsRequired()
                    .HasMaxLength(4)
                    .HasColumnName("music25")
                    .HasDefaultValueSql("('Нет')");

                entity.Property(e => e.Music3)
                    .IsRequired()
                    .HasMaxLength(4)
                    .HasColumnName("music3")
                    .HasDefaultValueSql("('Нет')");

                entity.Property(e => e.Music4)
                    .IsRequired()
                    .HasMaxLength(4)
                    .HasColumnName("music4")
                    .HasDefaultValueSql("('Нет')");

                entity.Property(e => e.Music5)
                    .IsRequired()
                    .HasMaxLength(4)
                    .HasColumnName("music5")
                    .HasDefaultValueSql("('Нет')");

                entity.Property(e => e.Music6)
                    .IsRequired()
                    .HasMaxLength(4)
                    .HasColumnName("music6")
                    .HasDefaultValueSql("('Нет')");

                entity.Property(e => e.Music7)
                    .IsRequired()
                    .HasMaxLength(4)
                    .HasColumnName("music7")
                    .HasDefaultValueSql("('Нет')");

                entity.Property(e => e.Music8)
                    .IsRequired()
                    .HasMaxLength(4)
                    .HasColumnName("music8")
                    .HasDefaultValueSql("('Нет')");

                entity.Property(e => e.Music9)
                    .IsRequired()
                    .HasMaxLength(4)
                    .HasColumnName("music9")
                    .HasDefaultValueSql("('Нет')");

                entity.Property(e => e.NameUser)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Name_user");

                entity.Property(e => e.UserReceivedMusicPrize)
                    .IsRequired()
                    .HasMaxLength(4)
                    .HasColumnName("User_received_music_prize")
                    .HasDefaultValueSql("('Нет')");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithOne(p => p.ListMusicUser)
                    .HasForeignKey<ListMusicUser>(d => d.IdUser)
                    .HasConstraintName("FK_List_Music_User_Users");
            });
           
            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.IsOnline)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Money)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Photo).IsRequired();

                entity.Property(e => e.SubscriptionGame)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Subscription_game");

                entity.Property(e => e.SubscriptionMusic)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Subscription_music");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
