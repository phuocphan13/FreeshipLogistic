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

    }
}
