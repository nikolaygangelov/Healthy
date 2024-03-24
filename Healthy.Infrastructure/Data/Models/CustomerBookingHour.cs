using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Healthy.Infrastructure.Data.Models
{
	public class CustomerBookingHour
	{
		public string CustomerId { get; set; } = string.Empty;
		[ForeignKey(nameof(CustomerId))]
		public IdentityUser Customer { get; set; } = null!;


		public int BookingHourId { get; set; }
		[ForeignKey(nameof(BookingHourId))]
		public BookingHour BookingHour { get; set; } = null!;



		[Required]
		[Comment("Активност")]
		public bool IsDeleted { get; set; }
	}
}