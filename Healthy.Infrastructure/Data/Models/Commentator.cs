using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using static Healthy.Infrastructure.Constants.DataConstants;


namespace Healthy.Infrastructure.Data.Models
{
	[Comment("Коментатор")]
	public class Commentator
	{
		[Key]
		[Comment("Код на коментатор")]
		public int Id { get; set; }

		[Required]
		[Comment("Име на коментатор")]
		[MaxLength(CommentatorNameMaxLength)]
		public string FeedbackCommentatorName { get; set; } = string.Empty;

		[Comment("Снимка на коментатор")]
		public byte[]? PictureSource { get; set; }

		[Required]
		[Comment("Код на потребител")]
		public string UserId { get; set; } = string.Empty;

		[ForeignKey(nameof(UserId))]
		public IdentityUser User { get; set; } = null!;

		public List<Feedback> Feedbacks { get; set; } = new List<Feedback>();

		[Required]
		[Comment("Активност")]
		public bool IsDeleted { get; set; }
	}
}
