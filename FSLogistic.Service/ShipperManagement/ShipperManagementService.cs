using FSLogistic.Core.Consts;
using FSLogistic.Core.Repositories;
using FSLogistic.Core.UoW;
using FSLogistic.Model.Account;
using FSLogistic.Model.Shared;
using FSLogistic.Service.Account;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace FSLogistic.Service.ShipperManagement
{
    public class ShipperManagementService : BaseService, IShipperManagementService
    {

        public ShipperManagementService(IPrincipal principal, IHttpContextAccessor context,
            IRepository<Domain.Models.Account> accountRepository 
           ) : base(principal, context, accountRepository)
        {
        }

        public async Task<ResponeModel<List<ShipperAccountModel>>> GetListAccount()
        {
            var listResourceAccountsEntity = await _accountRepository.GetAll().ToListAsync();
            if(listResourceAccountsEntity==null)
            {
                return SetResponeData<List<ShipperAccountModel>>(ShipperManagementMessage.ErrorMessageLoadData, ResponeStatusEnum.Null, null);
            }

            var listShipperAccountModel = new List<ShipperAccountModel>();
            foreach(var item in listResourceAccountsEntity)
            {
                var accountmodel = new ShipperAccountModel()
                {
                    Code = item.Code,
                    Name = item.Name,
                    UserId = item.UserId,
                    UserName = "hardcode@gmail.com",
                };
                listShipperAccountModel.Add(accountmodel);
            }          

            return SetResponeData(ShipperManagementMessage.GetSuccessed, ResponeStatusEnum.Successed, listShipperAccountModel);
        }



    }
}
