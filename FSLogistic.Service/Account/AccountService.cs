using System;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;
using FSLogistic.Core.Helpers;
using FSLogistic.Core.Repositories;
using FSLogistic.Core.UoW;
using FSLogistic.Model.Account;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace FSLogistic.Service.Account
{
    public class AccountService : BaseService, IAccountService
    {
        private readonly IUnitOfWork _unitOfWork;

        public AccountService(IPrincipal principal, IHttpContextAccessor context,
            IRepository<Domain.Models.Account> accountRepository,
            IUnitOfWork unitOfWork) : base(principal, context, accountRepository)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> Insert(AccountCreateModel accountCreate)
        {
            var listCodes = await _accountRepository.GetAll().Select(x => x.Code).ToListAsync();
            var account = new Domain.Models.Account
            {
                LastName = accountCreate.LastName,
                FirstName = accountCreate.FirstName,
                UserId = accountCreate.UserId,
                Guid = Guid.NewGuid()
            };

            using(var generateCodeHelper = new GenerateCodeHelper())
            {
                account.Code = generateCodeHelper.GenerateCode(account.FirstName, account.LastName, listCodes);
            }

            await _accountRepository.InsertAsync(account);
            return await _unitOfWork.SaveChangesAsync();
        }
    }
}
