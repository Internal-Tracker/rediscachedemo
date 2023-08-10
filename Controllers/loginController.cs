using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using rediscachedemoazure.Model;
using rediscachedemoazure.Repository;

namespace rediscachedemoazure.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class loginController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        private LoginResponseDto objLoginResponseDto;

        public loginController(IUserRepository userRepository)
        {

            _userRepository = userRepository;
        }
        [HttpPost]
        public async Task<IActionResult> Authenticate([FromBody] LoginRequestDto loginrequest)
        {
            User user = await _userRepository.ValidateUser(loginrequest);
            if (user != null)
            {
                objLoginResponseDto = new LoginResponseDto();
                objLoginResponseDto.UserID = user.UserID;
                objLoginResponseDto.userAccounts = user.userAccounts;
            }
            return Ok(objLoginResponseDto);
        }
    }
}
