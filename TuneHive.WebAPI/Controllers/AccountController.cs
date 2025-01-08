using Microsoft.AspNetCore.Mvc;
using TuneHive.Application.Interfaces;
using TuneHive.Application.Responses;
using TuneHive.Application.Services.Account.Dto;

namespace TuneHive.WebAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AccountController: ControllerBase
    {
        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpPost(nameof(Register))]
        public async Task<Response> Register([FromBody] RegistrationRequestDto request)
        {
            return await _accountService.Register(request);
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
