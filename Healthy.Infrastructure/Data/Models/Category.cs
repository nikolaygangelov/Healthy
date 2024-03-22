using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using static Healthy.Infrastructure.Constants.DataConstants;


namespace Healthy.Infrastructure.Data.Models
{
	[Comment("Категория")]
	public class Category
	{
		[Key]
		[Comment("Код на категория")]
		public int Id { get; set; }

		[Required]
		[Comment("Име на категория")]
		[MaxLength(CategoryNameMaxLength)]
		public string Name { get; set; } = string.Empty;

		[Required]
		[Comment("Активност")]
		public bool IsDeleted { get; set; }

		public List<Training> Trainings { get; set; } = new List<Training>();
	}
}