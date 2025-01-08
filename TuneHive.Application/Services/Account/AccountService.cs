using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TuneHive.Application.Interfaces;
using TuneHive.Application.Interfaces.Repository;
using TuneHive.Application.Responses;
using TuneHive.Application.Services.Account.Dto;
using TuneHive.Domain.Entity;

namespace TuneHive.Application.Services.Account
{
    public class AccountService : IAccountService
    {
        private readonly IRepository<ApplicationUser> _userRespository;

        public AccountService(IRepository<ApplicationUser> userRespository)
        {
            _userRespository = userRespository;
        }

        public async Task<Response> Register(RegistrationRequestDto request)
        {
            var existingUser = await _userRespository.TableNoTracking.Where(x => x.EmailAddress == request.EmailAddress).FirstOrDefaultAsync();
            if (existingUser is null) {
                var newUser = new ApplicationUser
                {
                    FirstName = request.FirstName,
                    LastName = request.LastName,
                    EmailAddress = request.EmailAddress,
                    BirthDate = request.BirthDate,
                    CreatedDate = DateTime.Now,
                    LastModifiedDate = DateTime.Now,
                    isActive = true,
                    isDeleted = false,
                };
                await _userRespository.Add(newUser);
                return new Response { Message = "New account created successfully", Success = true };
            }
            else
            {
                return new Response { Message = "Acount already exists with same email", Success = false, Errors = [ "account already exists" ] };
            }
        }
    }
}
