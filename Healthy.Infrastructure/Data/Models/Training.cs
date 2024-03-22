using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using static Healthy.Infrastructure.Constants.DataConstants;

namespace Healthy.Infrastructure.Data.Models
{
	[Comment("Вид тренировка")]
	public class Training
	{
		[Comment("Код на тренировка")]
		[Key]
		public int Id { get; set; }

		[Comment("Вид")]
		[Required]
		[MaxLength(TrainingTitleMaxLength)]
		public string Title { get; set; } = string.Empty;

		[Comment("Описание")]
		[Required]
		[MaxLength(TrainingDescriptionMaxLength)]
		public string Description { get; set; } = string.Empty;

        [Required]
		[Comment("Цена за един ден")]
		[Column(TypeName = "decimal(18, 2)")]
        public decimal PricePerDay { get; set; }

		[Required]
		[Comment("Цена за една седмица")]
		[Column(TypeName = "decimal(18, 2)")]
		public decimal PricePerWeek { get; set; }

		[Required]
		[Comment("Цена за един месец")]
		[Column(TypeName = "decimal(18, 2)")]
		public decimal PricePerMonth { get; set; }

		[Required]
		[Comment("Цена за една година")]
		[Column(TypeName = "decimal(18, 2)")]
		public decimal PricePerYear { get; set; }

		[Required]
		[Comment("Капацитет")]
		public int Capacity { get; set; }

		[Required]
		[Comment("Локация на снимка")]
		[MaxLength(ImagePathMaxLength)]
		public string ImagePath { get; set; } = string.Empty;


		[Required]
		[Comment("Код на категория")]
		public int CategoryId { get; set; }

		[ForeignKey(nameof(CategoryId))]
		public Category Category { get; set; } = null!;


		[Required]
		[Comment("Код на график")]
		public int ScheduleId { get; set; }

		[ForeignKey(nameof(ScheduleId))]
		public Schedule Schedule { get; set; } = null!;


		[Required]
		[Comment("Активност")]
		public bool IsDeleted { get; set; }

		public List<TrainingCustomer> TrainingsCustomers { get; set; } = new List<TrainingCustomer>();
		public List<TrainingTrainer> TrainingsTrainers { get; set; } = new List<TrainingTrainer>();
		public List<Feedback> Feedbacks { get; set; } = new List<Feedback>();
	}
}
