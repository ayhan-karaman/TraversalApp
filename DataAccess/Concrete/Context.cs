using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost; Database=traversalDb; Username=<Your-Username>; Password=<Your-Password>");
        }
        public DbSet<About> Abouts { get; set; }
        public DbSet<About2> About2s { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Destination> Destinations { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Feature2> Feature2s { get; set; }
        public DbSet<Guide> Guides { get; set; }
        public DbSet<NewsLetter> NewsLetters { get; set; }
        public DbSet<SubAbout> SubAbouts { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<About>(x => {
                x.ToTable("abouts").HasKey(k => k.ID);
                x.Property(p => p.ID).HasColumnName("about_id");
                x.Property(p => p.Header).HasColumnName("header");
                x.Property(p => p.Description).HasColumnName("description");
                x.Property(p => p.HeaderImage).HasColumnName("header_image");
                x.Property(p => p.Title).HasColumnName("title");
                x.Property(p => p.Details).HasColumnName("details");
                x.Property(p => p.TitleImage).HasColumnName("title_image");
                x.Property(p => p.Status).HasColumnName("status");
            });
            modelBuilder.Entity<About2>(x => {
                x.ToTable("about2s").HasKey(k => k.ID);
                x.Property(p => p.ID).HasColumnName("about2_id");
                x.Property(p => p.Header).HasColumnName("header");
                x.Property(p => p.Title).HasColumnName("title");
                x.Property(p => p.Details).HasColumnName("details");
                x.Property(p => p.TitleImage).HasColumnName("title_image");
                x.Property(p => p.Status).HasColumnName("status");
            });
            modelBuilder.Entity<Contact>(x => {
                x.ToTable("contacts").HasKey(k => k.ID);
                x.Property(p => p.ID).HasColumnName("contact_id");
                x.Property(p => p.Description).HasColumnName("description");
                x.Property(p => p.Mail).HasColumnName("mail");
                x.Property(p => p.Address).HasColumnName("address");
                x.Property(p => p.PhoneNumber).HasColumnName("phone_number");
                x.Property(p => p.MapLocation).HasColumnName("map_location");
                x.Property(p => p.Status).HasColumnName("status");
            });

            modelBuilder.Entity<Destination>(x => {
                x.ToTable("destinations").HasKey(k => k.ID);
                x.Property(p => p.ID).HasColumnName("destination_id");
                x.Property(p => p.City).HasColumnName("city");
                x.Property(p => p.DayNight).HasColumnName("day_night");
                x.Property(p => p.Price).HasColumnName("price");
                x.Property(p => p.Image).HasColumnName("image");
                x.Property(p => p.Description).HasColumnName("description");
                x.Property(p => p.Capacity).HasColumnName("capacity");
                x.Property(p => p.Status).HasColumnName("status");
            });

            modelBuilder.Entity<Feature>(x => {
                x.ToTable("features").HasKey(k => k.ID);
                x.Property(p => p.ID).HasColumnName("feature_id");
                x.Property(p => p.PostName).HasColumnName("post_name");
                x.Property(p => p.Description).HasColumnName("description");
                x.Property(p => p.Image).HasColumnName("image");
                x.Property(p => p.Status).HasColumnName("status");
            });

            modelBuilder.Entity<Feature2>(x => {
                x.ToTable("feature2s").HasKey(k => k.ID);
                x.Property(p => p.ID).HasColumnName("feature2_id");
                x.Property(p => p.PostName).HasColumnName("post_name");
                x.Property(p => p.Description).HasColumnName("description");
                x.Property(p => p.Image).HasColumnName("image");
                x.Property(p => p.Status).HasColumnName("status");
            });

            modelBuilder.Entity<Guide>(x => {
                x.ToTable("guides").HasKey(k => k.ID);
                x.Property(p => p.ID).HasColumnName("guide_id");
                x.Property(p => p.Name).HasColumnName("name");
                x.Property(p => p.Description).HasColumnName("description");
                x.Property(p => p.Image).HasColumnName("image");
                x.Property(p => p.TwitterUrl).HasColumnName("twitter_url");
                x.Property(p => p.InstagramUrl).HasColumnName("instagram_url");
            });

            modelBuilder.Entity<NewsLetter>(x => {
                x.ToTable("news_letters").HasKey(k => k.ID);
                x.Property(p => p.ID).HasColumnName("news_letter_id");
                x.Property(p => p.Mail).HasColumnName("mail");
            });
            modelBuilder.Entity<SubAbout>(x => {
                x.ToTable("sub_abouts").HasKey(k => k.ID);
                x.Property(p => p.ID).HasColumnName("sub_about_id");
                x.Property(p => p.Title).HasColumnName("title");
                x.Property(p => p.Description).HasColumnName("description");
            });

            modelBuilder.Entity<Testimonial>(x => {
                x.ToTable("testimonials").HasKey(k => k.ID);
                x.Property(p => p.ID).HasColumnName("testimonial_id");
                x.Property(p => p.Client).HasColumnName("client");
                x.Property(p => p.Comment).HasColumnName("comment");
                x.Property(p => p.ClientImage).HasColumnName("client_image");
                x.Property(p => p.Status).HasColumnName("status");
            });

        }
    }
}