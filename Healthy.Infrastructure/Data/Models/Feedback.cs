using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using static Healthy.Infrastructure.Constants.DataConstants;

namespace Healthy.Infrastructure.Data.Models
{
	[Comment("Отзив")]
	public class Feedback
	{
		[Key]
		[Comment("Код на отзив")]
		public int Id { get; set; }

		[Comment("Текст на отзив")]
		[MaxLength(FeedbackTextMaxLength)]
		public string? FeedbackText { get; set; }

		[Required]
		[Comment("Оценка за тренировка")]
		public int TrainingRating { get; set; }

		[Required]
		[Comment("Оценка за треньор")]
		public int TrainerRating { get; set; }

		[Required]
		[Comment("Оценка за услуга")]
		public int ServiceRating { get; set; }

		[Required]
        public DateTime CreatedOn { get; set; }

        [Required]
		[Comment("Код на тренировка")]
		public int TrainingId { get; set; }

		[ForeignKey(nameof(TrainingId))]
		public Training Training { get; set; } = null!;


		[Required]
		[Comment("Код на услуга")]
		public int ServiceId { get; set; }

		[ForeignKey(nameof(ServiceId))]
		public Service Service { get; set; } = null!;


		[Required]
		[Comment("Код на коментатор")]
		public int CommentatorId { get; set; }

		[ForeignKey(nameof(CommentatorId))]
		public Commentator Commentator { get; set; } = null!;


		[Required]
		[Comment("Активност")]
		public bool IsDeleted { get; set; }
	}
}
