﻿using FSLogistic.Core.Repositories;
using FSLogistic.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Threading.Tasks;

namespace FSLogistic.Service.Bill
{
    public class BillService : IBillService
    {
        private readonly IRepository<Domain.Models.Bill> _billRepository;

        public BillService(IRepository<Domain.Models.Bill> billRepository)
        {
            _billRepository = billRepository;
        }

        public async Task<List<Domain.Models.Bill>> Get()
        {
            var bills = await _billRepository.GetAllListAsync();
            return bills;
        }

        public async Task<Domain.Models.Bill> GetById(int id)
        {
            var bill = await _billRepository.GetAsync(id);
            return bill;
        }

        public async Task<List<Domain.Models.Bill>> SearchByCustomerId(int customerId)
        {
            var bills = await _billRepository.Query(x => x.CustomerId == customerId).ToListAsync();
            return bills;
        }
        public async Task<List<Domain.Models.Bill>> SearchByShipperId(int shipperId)
        {
            var bills = await _billRepository.Query(x => x.AccountId == shipperId).ToListAsync();
            return bills;
        }

        public async Task<List<Domain.Models.Bill>> SearchByCustomer(string name)
        {
            var bills = await _billRepository.Query(x => SearchString(x.Customer.Name,name)).ToListAsync();
            return bills;
        }
        public async Task<List<Domain.Models.Bill>> SearchByShipper(string name)
        {
            var bills = await _billRepository.Query(x => SearchString(x.Account.Name, name)).ToListAsync();
            return bills;
        }


        public async Task<List<Domain.Models.Bill>> SearchByDate(DateTime date)
        {
            var searchDate = date;
            var start = new DateTime(searchDate.Year, searchDate.Month, searchDate.Day,0,0,0);
            var end = new DateTime(searchDate.Year, searchDate.Month, searchDate.Day, 23, 59, 59);
            var bills = await _billRepository.Query(x => start <= x.CreatedDate && x.CreatedDate <= end).ToListAsync();
            return bills;
        }

        public async Task<List<Domain.Models.Bill>> SearchByDistrict(District district)
        {
            var bills = await _billRepository.Query(x => x.District == (int)district).ToListAsync();
            return bills;
        }

        private bool SearchString(string text, string searchString)
        {
            text = text.Trim();
            searchString = searchString.Trim();

            return text.Contains(searchString, StringComparison.CurrentCultureIgnoreCase);
        }
         

    }
}
