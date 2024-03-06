using Microsoft.AspNetCore.Mvc;

namespace Healthy.Components
{
    public class ProfileMenuComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return await Task.FromResult<IViewComponentResult>(View("ProfileMenu"));
        }
    }
}
