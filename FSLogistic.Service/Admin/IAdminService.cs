using FSLogistic.Model.Admin;
using FSLogistic.Model.Bill_Admin;
using FSLogistic.Model.Shared;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FSLogistic.Service.Admin
{
    public interface IAdminService
    {
        Task<ResponeModel<List<AdminBillModel>>> GetDataAdmin();
    }
}
