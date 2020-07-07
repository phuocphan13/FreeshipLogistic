import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-shipper-bill-datashowing',
  templateUrl: './shipper-bill-datashowing.component.html',
  styleUrls: ['./shipper-bill-datashowing.component.scss']
})
export class ShipperBillDatashowingComponent implements OnInit {

  constructor() { }

  ngOnInit() {
  }

  listHeaders = ["STT", "Mã bill", "Mã Khách hàng", "Tên người nhận", "Địa chỉ", "Quận", "SĐT", "Ghi chú của khách hàng",
    "Tổng thu", "Trạng thái", "Ghi chú nhân viên", "Ngày báo phát", ""];

  billShippers = [
    {
      code: 'FS27042022',
      customer: 'KHOGACHIBUOI',
      receiverName: 'Hà Bùi',
      address: '327/42 Lãnh Binh Thăng',
      district: '11',
      phoneNumber: '0909345678',
      customerNote: 'Cho khách kiểm tra hàng. Hàng dễ vỡ xin nhẹ tay.',
      total: '108.000 VNĐ',
      status: 'Chưa',
      staffNote: 'Khách không có ở nhà',
      doneDate: '21/04/2020',
    },
    {
      code: 'FS21042170',
      customer: 'NGUYENTHU',
      receiverName: 'Phương Nga',
      address: '379/20C Tân Hòa Đông',
      district: 'Bình Tân',
      phoneNumber: '0909345678',
      customerNote: 'Cho đồng kiểm. Không được thử. Nếu không nhận liên hệ Shop.',
      total: '185.000 VNĐ',
      status: 'Chưa',
      staffNote: 'Khách không nghe máy',
      doneDate: '21/04/2020',
    },
    {
      code: 'FS27042022',
      customer: 'THANHVY',
      receiverName: 'Hoài Thy',
      address: '170 Đường số 32 Bình Phú',
      district: '6',
      phoneNumber: '0909345678',
      customerNote: 'Cho khách kiểm tra hàng.',
      total: '510.000 VNĐ',
      status: 'Chuyển hoàn',
      staffNote: 'Khách không nhận hàng',
      doneDate: '21/04/2020',
    },
    {
      code: 'FS27042022',
      customer: 'KHOGACHIBUOI',
      receiverName: 'Hà Bùi',
      address: '327/42 Lãnh Binh Thăng',
      district: '11',
      phoneNumber: '0909345678',
      customerNote: 'Cho khách kiểm tra hàng. Hàng dễ vỡ xin nhẹ tay.',
      total: '108.000 VNĐ',
      status: 'Chưa',
      staffNote: 'Khách không có ở nhà',
      doneDate: '21/04/2020',
    },
    {
      code: 'FS27042022',
      customer: 'THANHVY',
      receiverName: 'Hoài Thy',
      address: '170 Đường số 32 Bình Phú',
      district: '6',
      phoneNumber: '0909345678',
      customerNote: 'Cho khách kiểm tra hàng.',
      total: '510.000 VNĐ',
      status: 'Chuyển hoàn',
      staffNote: 'Khách không nhận hàng',
      doneDate: '21/04/2020',
    },
    {
      code: 'FS21042170',
      customer: 'NGUYENTHU',
      receiverName: 'Phương Nga',
      address: '379/20C Tân Hòa Đông',
      district: 'Bình Tân',
      phoneNumber: '0909345678',
      customerNote: 'Cho đồng kiểm. Không được thử. Nếu không nhận liên hệ Shop.',
      total: '185.000 VNĐ',
      status: 'Chưa',
      staffNote: 'Khách không nghe máy',
      doneDate: '21/04/2020',
    },
    {
      code: 'FS27042022',
      customer: 'THANHVY',
      receiverName: 'Hoài Thy',
      address: '170 Đường số 32 Bình Phú',
      district: '6',
      phoneNumber: '0909345678',
      customerNote: 'Cho khách kiểm tra hàng.',
      total: '510.000 VNĐ',
      status: 'Chuyển hoàn',
      staffNote: 'Khách không nhận hàng',
      doneDate: '21/04/2020',
    },
    {
      code: 'FS27042022',
      customer: 'KHOGACHIBUOI',
      receiverName: 'Hà Bùi',
      address: '327/42 Lãnh Binh Thăng',
      district: '11',
      phoneNumber: '0909345678',
      customerNote: 'Cho khách kiểm tra hàng. Hàng dễ vỡ xin nhẹ tay.',
      total: '108.000 VNĐ',
      status: 'Chưa',
      staffNote: 'Khách không có ở nhà',
      doneDate: '21/04/2020',
    },
    {
      code: 'FS21042170',
      customer: 'NGUYENTHU',
      receiverName: 'Phương Nga',
      address: '379/20C Tân Hòa Đông',
      district: 'Bình Tân',
      phoneNumber: '0909345678',
      customerNote: 'Cho đồng kiểm. Không được thử. Nếu không nhận liên hệ Shop.',
      total: '185.000 VNĐ',
      status: 'Chưa',
      staffNote: 'Khách không nghe máy',
      doneDate: '21/04/2020',
    },
  ]

  onClickEdit(){
    
  }
}
