using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TuneHive.Application.Responses;
using TuneHive.Application.Services.Account.Dto;

namespace TuneHive.Application.Interfaces
{
    public interface IAccountService
    {
        Task<Response> Register(RegistrationRequestDto request);
    }
}
