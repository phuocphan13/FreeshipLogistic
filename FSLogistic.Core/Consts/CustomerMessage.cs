using System;
using System.Collections.Generic;
using System.Text;

namespace FSLogistic.Core.Consts
{
    public static class CustomerMessage
    {
        public const string CustomerExistedMessage = "Khách hàng này đã tồn tại. \n ";
        public const string CustomerNotExistedMessage = "Khách hàng này không tồn tại. \n";
        public const string CustomerValidateFailedMessage = "Dữ liệu đã nhập không đúng định dạng, vui lòng kiểm tra lại. \n ";
        public const string CustomerCreateSuccessedMessage = "Thêm khách hàng thành công. \n ";
        public const string CustomerCreateFailedMessage = "Thêm khách hàng thất bại. \n ";
        public const string CustomerUpdateFailedMessage = "Sửa thông tin khách hàng thất bại. \n";
        public const string CustomerUpdateSuccessedMessage = "Sửa thông tin khách hàng thành công. \n";
    }
}
