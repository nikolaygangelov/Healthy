using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using static Healthy.Infrastructure.Constants.DataConstants;

namespace Healthy.Infrastructure.Data.Models
{
	[Comment("График")]
	public class Schedule
	{
		[Key]
		[Comment("Код на график")]
		public int Id { get; set; }


		[Required]
		[Comment("Дата от графика")]
		public string StartDate { get; set; } = string.Empty;


		[Required]
		[Comment("Съобщение за краен срок за отмяна")]
		[MaxLength(DueDateMessageMaxLength)]
		public string DueDateMessage { get; set; } = string.Empty;


		[Required]
		[Comment("Активност")]
		public bool IsDeleted { get; set; }

		public List<Training> Trainings { get; set; } = new List<Training>();

		public List<ScheduleTrainer> SchedulesTrainers { get; set; } = new List<ScheduleTrainer>();
	}
}
