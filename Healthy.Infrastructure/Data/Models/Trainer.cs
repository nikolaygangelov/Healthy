using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using static Healthy.Infrastructure.Constants.DataConstants;

namespace Healthy.Infrastructure.Data.Models
{
	[Comment("Треньор")]
	public class Trainer
	{
		[Key]
		[Comment("Код на треньор")]
		public int Id { get; set; }

		[Required]
		[Comment("Име на треньор")]
		[MaxLength(TrainerFirstNameMaxLength)]
		public string FirstName { get; set; } = string.Empty;

		[Required]
		[Comment("Име на треньор")]
		[MaxLength(TrainerLastNameMaxLength)]
		public string LastName { get; set; } = string.Empty;

		[Required]
		[Comment("Вид специализация")]
		[MaxLength(TrainerSpecializationMaxLength)]
		public string Specialization { get; set; } = string.Empty;

		[Required]
		[Comment("Телефон на треньор")]
		[MaxLength(TrainerPhoneNumberMaxLength)]
		public string PhoneNumber { get; set; } = string.Empty;

		[Comment("Адрес на треньор")]
		[MaxLength(TrainerAddressMaxLength)]
		public string? Address { get; set; }

		[Required]
		[Comment("Код на потребител")]
		public string UserId { get; set; } = string.Empty;

		[ForeignKey(nameof(UserId))]
		public IdentityUser User { get; set; } = null!;

		[Required]
		[Comment("Активност")]
		public bool IsDeleted { get; set; }
	}
}