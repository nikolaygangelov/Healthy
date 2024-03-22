using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Healthy.Infrastructure.Data.Models
{
	public class ScheduleTrainer
	{
		public int ScheduleId { get; set; }
		[ForeignKey(nameof(ScheduleId))]
		public Schedule Schedule { get; set; } = null!;


		public int TrainerId { get; set; }
		[ForeignKey(nameof(TrainerId))]
		public Trainer Trainer { get; set; } = null!;

		[Required]
		[Comment("Активност")]
		public bool IsDeleted { get; set; }
	}
}