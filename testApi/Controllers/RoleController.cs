using Microsoft.AspNetCore.Mvc;
using testApi.Services;

namespace testApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RoleController : ControllerBase
    {
        private readonly RoleService _roleService;

        public RoleController(RoleService roleService)
        {
            _roleService = roleService;
        }

        [HttpPost("{userId}")]
        public async Task<IActionResult> AddRole(Guid userId, string roleName)
        {
            var role = await _roleService.AddRole(userId, roleName);

            return Ok(role);
        }
    }

}
