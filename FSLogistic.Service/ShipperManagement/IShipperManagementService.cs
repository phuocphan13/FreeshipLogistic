using FSLogistic.Model.Account;
using FSLogistic.Model.Shared;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FSLogistic.Service.ShipperManagement

{
    public interface IShipperManagementService
    {
        Task<ResponeModel<List<ShipperAccountModel>>> GetListAccount();
    }
}
