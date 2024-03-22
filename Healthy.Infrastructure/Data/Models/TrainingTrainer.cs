using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Healthy.Infrastructure.Data.Models
{
	public class TrainingTrainer
	{
		public int TrainingId { get; set; }
		[ForeignKey(nameof(TrainingId))]
		public Training Training { get; set; } = null!;


		public string TrainerId { get; set; } = string.Empty;
		[ForeignKey(nameof(TrainerId))]
		public Trainer Trainer { get; set; } = null!;

		[Required]
		[Comment("Активност")]
		public bool IsDeleted { get; set; }
	}
}