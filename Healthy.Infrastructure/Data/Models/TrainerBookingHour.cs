using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Healthy.Infrastructure.Data.Models
{
	public class TrainerBookingHour
	{
		public int TrainerId { get; set; }
		[ForeignKey(nameof(TrainerId))]
		public Trainer Trainer { get; set; } = null!;

		public int BookingHourId { get; set; }
		[ForeignKey(nameof(BookingHourId))]
		public BookingHour BookingHour { get; set; } = null!;


		[Required]
		[Comment("Активност")]
		public bool IsDeleted { get; set; }
	}
}