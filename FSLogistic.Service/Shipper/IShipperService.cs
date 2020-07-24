using FSLogistic.Model.Bill_Shipper;
using FSLogistic.Model.Shared;
using FSLogistic.Model.Shipper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FSLogistic.Service.Bill_Shipper
{
    public interface IShipperService
    {
        Task<ResponeModel<List<ShipperBillModel>>> GetDataShipper();
    }
}
