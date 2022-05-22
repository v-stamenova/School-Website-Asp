using DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
	public class SchoolDbContext : DbContext
	{
		public SchoolDbContext(DbContextOptions<SchoolDbContext> options)
			: base(options)
		{
		}

		public DbSet<Employee> Employees { get; set; }

		public DbSet<Member> Members { get; set; }

		public DbSet<Role> Roles { get; set; }

		public DbSet<Subject> Subjects { get; set; }

		public DbSet<Teacher> Teachers { get; set; }

		public DbSet<User> Users { get; set; }

		public DbSet<Article> Articles { get; set; }

		public DbSet<ArticleType> Types { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Employee>(entity =>
			{
				entity.Property(e => e.FirstName)
					.IsRequired();

				entity.Property(e => e.MiddleName);

				entity.Property(e => e.LastName)
					.IsRequired();

				entity.Property(e => e.JobDescription)
					.IsRequired();
			});

			modelBuilder.Entity<Member>(entity =>
			{
				entity.Property(e => e.FirstName)
					.IsRequired();

				entity.Property(e => e.MiddleName);

				entity.Property(e => e.LastName)
					.IsRequired();

				entity.Property(e => e.Email);

				entity.Property(e => e.IsInSchoolBoard)
					.IsRequired();

				entity.HasOne(e => e.Role)
					.WithMany(r => r.Members)
					.HasForeignKey(e => e.RoleId);
			});

			modelBuilder.Entity<Role>(entity =>
			{
				entity.Property(e => e.Name)
					.IsRequired();
			});

			modelBuilder.Entity<Subject>(entity =>
			{
				entity.HasKey(e => e.Id);

				entity.Property(e => e.FullName)
					.IsRequired();
			});

			modelBuilder.Entity<Teacher>(entity =>
			{
				entity.HasKey(e => e.Username);

				entity.Property(e => e.FirstName)
					.IsRequired();

				entity.Property(e => e.MiddleName);

				entity.Property(e => e.LastName)
					.IsRequired();

				entity.Property(e => e.Biography);

				entity.Property(e => e.Birthdate);

				entity.Property(e => e.Email);

				entity.Property(e => e.IsHeadTeacher);

				entity.Property(e => e.AdditionalRole);

				entity.HasOne(e => e.Subject)
					.WithMany(s => s.Teachers)
					.HasForeignKey(e => e.SubjectId);
			});

			modelBuilder.Entity<User>(entity =>
			{
				entity.HasKey(e => e.Username);

				entity.Property(e => e.Password)
					.IsRequired();
			});

			modelBuilder.Entity<Article>(entity =>
			{
				entity.HasKey(e => e.Id);

				entity.Property(e => e.Title)
					.IsRequired();

				entity.Property(e => e.Subtitle);

				entity.Property(e => e.CreatedOn)
					.IsRequired();

				entity.Property(e => e.Content);

				entity.HasOne(e => e.Type)
					.WithMany(t => t.Articles)
					.HasForeignKey(e => e.TypeId);

				entity.HasOne(e => e.PostedBy)
					.WithMany(а => а.Articles)
					.HasForeignKey(е => е.PostedById);
			});

			modelBuilder.Entity<ArticleType>(entity =>
			{
				entity.HasKey(e => e.Name);

				entity.Property(e => e.Heading)
					.IsRequired();
			});

			modelBuilder.Entity<User>().HasData
			(
				new User()
				{
					Username = "Admin",
					Password = "RandomPassword"
				}
			);

			modelBuilder.Entity<ArticleType>().HasData
			(
				new ArticleType()
				{
					Name = "News",
					Heading = "съобщение"
				},
				new ArticleType()
				{
					Name = "SchoolPlan",
					Heading = "училищен план"
				},
				new ArticleType()
				{
					Name = "Course",
					Heading = "курс"
				},
				new ArticleType()
				{
					Name = "AfterSeventhGrade",
					Heading = "новина относно приема след 7. клас"
				},
				new ArticleType()
				{
					Name = "AfterFourthGrade",
					Heading = "новина относно приема след 4. клас"
				}
			);
		}
	}
}
