using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Healthy.Infrasstructure.Data
{
	public class HealthyDbContext : IdentityDbContext
	{
		public HealthyDbContext(DbContextOptions<HealthyDbContext> options)
			: base(options)
		{
		}
	}
}
