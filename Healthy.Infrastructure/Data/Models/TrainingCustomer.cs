using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Healthy.Infrastructure.Data.Models
{
	public class TrainingCustomer
	{
		public int TrainingId { get; set; }
		[ForeignKey(nameof(TrainingId))]
		public Training Training { get; set; } = null!;


		public string CustomerId { get; set; } = string.Empty;
		[ForeignKey(nameof(CustomerId))]
		public IdentityUser Customer { get; set; } = null!;

		[Required]
		[Comment("Активност")]
		public bool IsDeleted { get; set; }
	}
}