using FSLogistic.Core.Extensions;
using FSLogistic.Core.Repositories;
using FSLogistic.Domain.Models;
using FSLogistic.Model.Shared;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using System.Text;

namespace FSLogistic.Service
{
    public class BaseService
    {
        private ClaimsPrincipal _principal;
        
        private readonly IHttpContextAccessor _context;
        
        private readonly IRepository<Account> _accountRepository;

        public BaseService(IPrincipal principal, IHttpContextAccessor context, IRepository<Account> accountRepository)
        {
            _principal = principal as ClaimsPrincipal;
            _context = context;
            _accountRepository = accountRepository;
        }

        protected string CurrentUserGUID => Principal.GetCurrentUserGUID(_context);

        protected Account User => GetUser();

        protected ClaimsPrincipal Principal
        {
            get
            {
                if (_principal.Identity == null || string.IsNullOrEmpty(_principal.Identity.Name))
                    _principal = _context.HttpContext.User;
                return _principal;
            }
        }

        protected DateTime GetCurrentDate()
        {
            return DateTime.Now;
        }

        protected Account GetUser()
        {
            var account = _accountRepository.GetAll().FirstOrDefault(x => x.Guid == Guid.Parse(CurrentUserGUID));
            return account;
        }

        protected void AddInfoDataForEntity<T>(T modelObject, bool isCreate) where T : BaseEntityModel
        {
            if (User == null)
            {
                return;
            }
            if (isCreate)
            {
                modelObject.CreatedBy = User.Id;
                modelObject.CreatedDate = GetCurrentDate();
            }
            modelObject.UpdatedBy = User.Id;
            modelObject.UpdatedDate = GetCurrentDate();
        }
        protected ResponeModel<T> SetResponeData<T>(string message, ResponeStatusEnum status, T data) where T : class
        {
            var respone = new ResponeModel<T>
            {
                Message = message,
                ResponeStatus = status,
                Data = data
            };
            return respone;
        }
    }
}
