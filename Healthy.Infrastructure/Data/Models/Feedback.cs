using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using static Healthy.Infrastructure.Constants.DataConstants;

namespace Healthy.Infrastructure.Data.Models
{
	[Comment("Отзив")]
	public class Feedback
	{
		[Comment("Код на отзив")]
		[Key]
		public int Id { get; set; }

		[Required]
		[Comment("Текст на отзив")]
		[MaxLength(FeedbackTextMaxLength)]
		public string FeedbackText { get; set; } = string.Empty;

		[Comment("Оценка за тренировка")]
		[Required]
		public int TrainingRating { get; set; }

		[Comment("Оценка за треньор")]
		[Required]
		public int TrainerRating { get; set; }

        [Required]
        public DateTime CreatedOn { get; set; }

        [Required]
		[Comment("Код на тренировка")]
		public int TrainingId { get; set; }

		[ForeignKey(nameof(TrainingId))]
		public Training Training { get; set; } = null!;


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
