using Microsoft.AspNetCore.Mvc;
using TuneHive.Application.Services.Account.Dto;

namespace TuneHive.WebAPI.Controllers
{
    public class AccountController: ControllerBase
    {
        [HttpPost(nameof(Register))]
        public async Task<ActionResult> Register([FromBody] RegistrationRequestDto request)
        {
            throw new NotImplementedException();
        }

        [HttpPost(nameof(Login))]
        public async Task<ActionResult> Login([FromBody] LoginRequestDto request)
        {
            throw new NotImplementedException();
        }

        [HttpPost(nameof(ForgotPassword))]
        public async Task<ActionResult> ForgotPassword([FromBody] ForgotPasswordRequestDto request)
        {
            throw new NotImplementedException();
        }

        [HttpPost(nameof(ResetPassword))]
        public async Task<ActionResult> ResetPassword([FromBody] ResetPasswordRequestDto request)
        {
            throw new NotImplementedException();
        }
    }
}
