using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Healthy.Infrastructure.Data.Models
{
	public class TrainingBookingHour
	{
		public int TrainingId { get; set; }
		[ForeignKey(nameof(TrainingId))]
		public Training Training { get; set; } = null!;


		public int BookingHourId { get; set; }
		[ForeignKey(nameof(BookingHourId))]
		public BookingHour BookingHour { get; set; } = null!;

		[Required]
		[Comment("Активност")]
		public bool IsDeleted { get; set; }
	}
}