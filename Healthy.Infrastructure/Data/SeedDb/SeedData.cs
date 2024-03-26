using Healthy.Infrastructure.Data.Models;
using Healthy.Infrastructure.Enumerations;
using Microsoft.AspNetCore.Identity;

namespace Healthy.Infrastructure.Data.SeedDb
{
	internal class SeedData
	{
		public IdentityUser TrainerUser { get; set; }
		public IdentityUser ClientUser { get; set; }

		public Trainer Trainer { get; set; }

		public Category Beginner { get; set; }
		public Category Intermediate { get; set; }

		public Category Advanced { get; set; }

		public Training Zumba { get; set; }

		public Training Pilates { get; set; }

		public Training Swimming { get; set; }

		public BookingHour FirstHour { get; set; }

		public Commentator FirstCommentator { get; set; }
		public Feedback ZumbaFeedback { get; set; }


        public SeedData()
        {
			SeedUsers();
			SeedTrainer();
			SeedCategories();
			SeedTrainings();
			SeedBookingHours();
			SeedCommentators();
			SeedFeedbacks();
        }


        private void SeedUsers()
		{
			var hasher = new PasswordHasher<IdentityUser>();

			TrainerUser = new IdentityUser()
			{
				Id = "dea12856-c198-4129-b3f3-b893d8395082",
				UserName = "trainer@mail.com",
				NormalizedUserName = "TRAINER@MAIL.COM",
				Email = "trainer@mail.com",
				NormalizedEmail = "TRAINER@MAIL.COM"
			};

			TrainerUser.PasswordHash =
				 hasher.HashPassword(TrainerUser, "trainer123");

			ClientUser = new IdentityUser()
			{
				Id = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
				UserName = "client@mail.com",
				NormalizedUserName = "CLIENT@MAIL.COM",
				Email = "client@mail.com",
				NormalizedEmail = "CLIENT@MAIL.COM"
			};

			ClientUser.PasswordHash =
			hasher.HashPassword(ClientUser, "client123");
		}

		private void SeedTrainer()
		{
			Trainer = new Trainer()
			{
				Id = 1,
				FirstName = "Георги",
				LastName = "Петков",
				Specialization = "Кинезитерапевтика, Кеймбридж",
				PhoneNumber = "+359888888888",
				Address = "гр. София, кв. Хладилника, бл.45, вх.1",
				UserId = TrainerUser.Id
			};
		}

		private void SeedCategories()
		{
			Beginner = new Category()
			{
				Id = 1,
				Name = "Beginner"
			};

			Intermediate = new Category()
			{
				Id = 2,
				Name = "Intermediate"
			};

			Advanced = new Category()
			{
				Id = 3,
				Name = "Advanced"
			};
		}

		private void SeedTrainings()
		{
			Zumba = new Training()
			{
				Id = 1,
				Title = "30 минути",
				Description = "Изтощителна, но енергизираща. Не пропускайте да пробвате тази тренировка.",
				PricePerDay = 10.00M,
				PricePerWeek = 60.00M,
				PricePerMonth = 200.00M,
				PricePerYear = 2000M,
				Capacity = 15,
				ImagePath = "~/assets/img/zumba.jpg",
				CategoryId = Beginner.Id,
				Doors = (Doors) Enum.Parse(typeof(Doors), "Indoors"),
				PlaceOfConduct = "Зала 1"
			};

			Pilates = new Training()
			{
				Id = 2,
				Title = "Цяло тяло",
				Description = "Подходяща за цялото тяло, тази тренировка ше ви накара да се чувствате добре!",
				PricePerDay = 11.00M,
				PricePerWeek = 63.00M,
				PricePerMonth = 220.00M,
				PricePerYear = 2100M,
				Capacity = 18,
				ImagePath = "~/assets/img/pilates.jpg",
				CategoryId = Beginner.Id,
				Doors = (Doors)Enum.Parse(typeof(Doors), "Indoors"),
				PlaceOfConduct = "Зала 1"

			};

			Swimming = new Training()
			{
				Id = 3,
				Title = "30 минути",
				Description = "Изтощителна, но енергизираща. Не пропускайте да пробвате тази тренировка.",
				PricePerDay = 9.00M,
				PricePerWeek = 55.00M,
				PricePerMonth = 200.00M,
				PricePerYear = 1800M,
				Capacity = 12,
				ImagePath = "~/assets/img/swimming.jpg",
				CategoryId = Beginner.Id,
				Doors = (Doors)Enum.Parse(typeof(Doors), "Indoors"),
				PlaceOfConduct = "Зала 1"
			};
		}

		private void SeedBookingHours()
		{
			FirstHour = new BookingHour()
			{
				Id = 1,
				DueDateMessage = "Имайте предвид, че крайният срок за отмяна на записан час е 2 часа преди започване на тренировката",
				ReservedHour = "08.00 - 09.00"
			};
		}

		private void SeedCommentators()
		{
			FirstCommentator = new Commentator()
			{
				Id = 1,
				FeedbackCommentatorName = "Николай Ангелов",
				UserId = ClientUser.Id
			};
		}

		private void SeedFeedbacks()
		{
			ZumbaFeedback = new Feedback()
			{
				Id = 1,
				FeedbackText = "Беше страхотна тренировка! Наистина енергизираща!",
				TrainingRating = 6,
				TrainerRating = 6,
				TrainingId = 1,
				CommentatorId = 1
			};
		}


	}
}
