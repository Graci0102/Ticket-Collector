using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Problems.Data.Helper;
using Problems.Entites.DTO;
using Problems.Logic;

namespace Problems.EndPoint.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProblemController : ControllerBase
    {
        ProblemLogic logic;
        UserManager<AppUser> userManager;

        public ProblemController(ProblemLogic logic, UserManager<AppUser> userManager)
        {
            this.logic = logic;
            this.userManager = userManager;
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IEnumerable<ProblemGetDTO> Get()
        {
            return logic.Read();
        }

        [HttpPost]
        [Authorize]
        public async Task Post(ProblemPostDTO dto)
        {
            var user = await userManager.GetUserAsync(User);
            await logic.Create(dto,user.Id,user.UserName);
        }
    }
}
