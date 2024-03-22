using Healthy.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Healthy.Infrasstructure.Data
{
	public class HealthyDbContext : IdentityDbContext
	{
		public HealthyDbContext(DbContextOptions<HealthyDbContext> options)
			: base(options)
		{
		}

		public DbSet<Training> Trainings { get; set; } = null!;
		public DbSet<Category> Categories { get; set; } = null!;
		public DbSet<Schedule> Schedules { get; set; } = null!;
		public DbSet<Trainer> Trainers { get; set; } = null!;
		public DbSet<Feedback> Feedbacks { get; set; } = null!; 
		public DbSet<Commentator> Commentators { get; set; } = null!;

		public DbSet<ScheduleTrainer> SchedulesTrainers { get; set; } = null!;
		public DbSet<TrainingCustomer> TrainingsCustomers { get; set; } = null!;
		public DbSet<TrainingTrainer> TrainingsTrainers { get; set; } = null!;

		protected override void OnModelCreating(ModelBuilder builder)
		{
			builder.Entity<TrainingCustomer>(e =>
			e.HasKey(tc => new { tc.TrainingId, tc.CustomerId }));

			builder.Entity<TrainingTrainer>(e =>
			e.HasKey(tt => new { tt.TrainingId, tt.TrainerId }));

			builder.Entity<ScheduleTrainer>(e =>
			e.HasKey(st => new { st.ScheduleId, st.TrainerId }));



			builder.Entity<Trainer>().HasQueryFilter(t => t.IsDeleted == false);
			builder.Entity<Training>().HasQueryFilter(training => training.IsDeleted == false);
			builder.Entity<Category>().HasQueryFilter(c => c.IsDeleted == false);
			builder.Entity<Schedule>().HasQueryFilter(c => c.IsDeleted == false);
			builder.Entity<Feedback>().HasQueryFilter(c => c.IsDeleted == false);
			builder.Entity<Commentator>().HasQueryFilter(c => c.IsDeleted == false);

			builder.Entity<TrainingCustomer>().HasQueryFilter(tc => tc.IsDeleted == false);
			builder.Entity<TrainingTrainer>().HasQueryFilter(tt => tt.IsDeleted == false);
			builder.Entity<ScheduleTrainer>().HasQueryFilter(st => st.IsDeleted == false);

			base.OnModelCreating(builder);
		}
	}
}
