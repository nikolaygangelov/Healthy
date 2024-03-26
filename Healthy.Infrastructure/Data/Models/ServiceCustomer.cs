using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Healthy.Infrastructure.Data.Models
{
	public class ServiceCustomer
	{
		public int ServiceId { get; set; }
		[ForeignKey(nameof(ServiceId))]
		public Service Service { get; set; } = null!;


		public string CustomerId { get; set; } = string.Empty;
		[ForeignKey(nameof(CustomerId))]
		public IdentityUser Customer { get; set; } = null!;

		[Required]
		[Comment("Активност")]
		public bool IsDeleted { get; set; }
	}
}