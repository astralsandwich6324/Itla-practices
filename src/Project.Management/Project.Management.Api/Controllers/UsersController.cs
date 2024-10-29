using Microsoft.AspNetCore.Mvc;
using Project.Management.Domain;

namespace Project.Management.Api.Controllers
{
    [ApiController]
    [Route("Users")]
    public class UsersController : ControllerBase
    {
        private readonly ProjectManagementWebContext _context;

        public UsersController(ProjectManagementWebContext context)
        {
            _context = context;
        }
    }
}
