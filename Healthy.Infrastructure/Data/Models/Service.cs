using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using static Healthy.Infrastructure.Constants.DataConstants;


namespace Healthy.Infrastructure.Data.Models
{
	[Comment("Вид услуга")]
	public class Service
	{
		[Comment("Код на услуга")]
		[Key]
		public int Id { get; set; }

		[Comment("Вид")]
		[Required]
		[MaxLength(TitleMaxLength)]
		public string Title { get; set; } = string.Empty;

		[Comment("Описание")]
		[Required]
		[MaxLength(DescriptionMaxLength)]
		public string Description { get; set; } = string.Empty;

		[Required]
		[Comment("Цена за един ден")]
		[Column(TypeName = "decimal(18, 2)")]
		public decimal PricePerDay { get; set; }

		[Required]
		[Comment("Цена за една седмица")]
		[Column(TypeName = "decimal(18, 2)")]
		public decimal PricePerWeek { get; set; }

		[Required]
		[Comment("Цена за един месец")]
		[Column(TypeName = "decimal(18, 2)")]
		public decimal PricePerMonth { get; set; }

		[Required]
		[Comment("Цена за една година")]
		[Column(TypeName = "decimal(18, 2)")]
		public decimal PricePerYear { get; set; }

		[Required]
		[Comment("Капацитет")]
		public int Capacity { get; set; }

		[Required]
		[Comment("Локация на снимка")]
		[MaxLength(ImagePathMaxLength)]
		public string ImagePath { get; set; } = string.Empty;

		[Required]
		[MaxLength(PlaceMaxLength)]
		[Comment("Място на провеждане")]
		public string PlaceOfConduct = string.Empty;


		[Required]
		[Comment("Активност")]
		public bool IsDeleted { get; set; }


		public List<ServiceBookingHour> ServicesBookingHours { get; set; } = new List<ServiceBookingHour>();
		public List<ServiceCustomer> ServicesCustomers { get; set; } = new List<ServiceCustomer>();
		public List<Feedback> Feedbacks { get; set; } = new List<Feedback>();
	}
}
