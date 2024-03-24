using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using static Healthy.Infrastructure.Constants.DataConstants;

namespace Healthy.Infrastructure.Data.Models
{
	[Comment("Час за записване")]
	public class BookingHour
	{
		[Key]
		[Comment("Код на час за записване")]
		public int Id { get; set; }


		[Required]
		[Comment("Съобщение за краен срок за отмяна")]
		[MaxLength(DueDateMessageMaxLength)]
		public string DueDateMessage { get; set; } = string.Empty;


		[Required]
		[Comment("Резервиран час")]
		[MaxLength(ReservedHourMaxLength)]
		public string ReservedHour { get; set; } = string.Empty;

		[Required]
		[Comment("Активност")]
		public bool IsDeleted { get; set; }

		public List<TrainingBookingHour> TrainingsBookingHours { get; set; } = new List<TrainingBookingHour>();

		public List<TrainerBookingHour> TrainersBookingHours { get; set; } = new List<TrainerBookingHour>();

		public List<CustomerBookingHour> CustomersBookingHours { get; set; } = new List<CustomerBookingHour>();
	}
}
