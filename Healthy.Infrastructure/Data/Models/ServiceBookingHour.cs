using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Healthy.Infrastructure.Data.Models
{
	public class ServiceBookingHour
	{
		public int ServiceId { get; set; }
		[ForeignKey(nameof(ServiceId))]
		public Service Service { get; set; } = null!;


		public int BookingHourId { get; set; }
		[ForeignKey(nameof(BookingHourId))]
		public BookingHour BookingHour { get; set; } = null!;

		[Required]
		[Comment("Активност")]
		public bool IsDeleted { get; set; }
	}
}