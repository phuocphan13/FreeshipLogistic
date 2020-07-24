using FSLogistic.Model.Account;
using System;
using System.Threading.Tasks;

namespace FSLogistic.Service.Account
{
    public interface IAccountService
    {
        Task<bool> Insert(AccountCreateModel accountCreate);
    }
}
