using System;
using System.Collections.Generic;
using System.Text;

namespace FSLogistic.Core.Consts
{
    public static class CustomerMessage
    {
        public const string ErrorMessageLoadData = "Không có dữ liệu, hiển thị thất bại. \n ";
        public const string ErrorMessageCreate = "Khách hàng này đã có rồi, tạo khách hàng thất bại. \n ";
        public const string SuccessedMessageCreate = "Thêm khách hàng thành công. \n ";

        public const string GetSuccessedMessage = "Lấy dữ liệu thành công";
        public const string GetFailedMessage = "Lấy dữ liệu thất bại";

        public const string CustomerGetSuccessedMessage = "Lấy dữ liệu thành công. \n";
        public const string CustomerGetFailedMessage = "Lấy dữ liệu thất bại. \n ";
        public const string CustomerExistedMessage = "Khách hàng này đã tồn tại. \n ";
        public const string CustomerCreateFailedMessage = "Dữ liệu đã nhập không đúng định dạng, vui lòng kiểm tra lại. \n ";
        public const string CustomerCreateSuccessedMessage = "Thêm khách hàng thành công. \n ";
        public const string CustomerSaveFailedMessage = "Thêm khách hàng thất bại. \n ";
    }
}
