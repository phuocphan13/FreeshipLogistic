using FSLogistic.Model.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace FSLogistic.Service
{
    public class BaseService
    {
        protected DateTime GetCurrentDate()
        {
            return DateTime.Now;
        }

        protected int GetUserId()
        {
            return 1;
        }
        protected void AddInfoDataForEntity<T>(T modelObject, bool isCreate) where T : BaseModel
        {
            //if (User == null)
            //{
            //    return;
            //}
            if (isCreate)
            {
                modelObject.CreatedBy = GetUserId();
                modelObject.CreatedDate = GetCurrentDate();
            }
            modelObject.UpdatedBy = GetUserId();
            modelObject.UpdatedDate = GetCurrentDate();
            //modelObject.CompanyId = User.CompanyId;
            //modelObject.IsActive = true;
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
