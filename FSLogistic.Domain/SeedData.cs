using FSLogistic.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace FSLogistic.Domain
{
    public class SeedData : IDisposable
    {
        public void SeedDataForInitialize(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Autocomplete>().HasData(SeedDataForAutoCompleteTable());

            modelBuilder.Entity<Customer>().HasData(SeedDataForCustomerTable());
        }

        private List<Customer> SeedDataForCustomerTable()
        {
            return new List<Customer>()
            {
                new Customer()
                {
                    Id = 1,
                    Code = "TranDan",
                    CreatedBy = 1,
                    CreatedDate = DateTime.Now,
                    UpdatedBy = null,
                    UpdatedDate = null,
                    Name = "Trần Dần",
                    Q1 = 30000, Q2 = 50000, Q3 = 30000, Q4 = 30000, Q5 = 30000, Q6 = 30000,
                    Q7 = 30000, Q8 = 30000, Q9 = 30000, Q10 = 30000, Q11 = 30000, Q12 = 30000,
                    QTD = 30000, QGV = 30000, QTB = 30000, QTP = 30000, QPN = 30000,
                    Qcc = 30000, QHM = 30000, QBC = 30000, QNB = 30000, QCG = 30000,
                    QBTH = 30000, QBTN = 30000,
                },
                 new Customer()
                {
                    Id = 2,
                    Code = "Truong3Gio",
                    CreatedBy = 1,
                    CreatedDate = DateTime.Now,
                    UpdatedBy = null,
                    UpdatedDate = null,
                    Name = "Trương Tam Phong",
                    Q1 = 30000, Q2 = 50000, Q3 = 30000, Q4 = 30000, Q5 = 30000, Q6 = 30000,
                    Q7 = 30000, Q8 = 30000, Q9 = 30000, Q10 = 30000, Q11 = 30000, Q12 = 30000,
                    QTD = 30000, QGV = 30000, QTB = 30000, QTP = 30000, QPN = 30000,
                    Qcc = 30000, QHM = 30000, QBC = 30000, QNB = 30000, QCG = 30000,
                    QBTH = 30000, QBTN = 30000,
                }
            };
        }

        private List<Autocomplete> SeedDataForAutoCompleteTable()
        {
            return new List<Autocomplete>()
            {
                new Autocomplete()
                {
                    Id = 1,
                    Type = AutocompleteType.Address,
                    Data = "132 Trường Chinh, Quận Tân Bình"
                },
                new Autocomplete()
                {
                    Id = 2,
                    Type = AutocompleteType.PhoneNumber,
                    Data = "0912 321 251"
                },
                new Autocomplete()
                {
                    Id = 3,
                    Type = AutocompleteType.Address,
                    Data = "333 Trần Hưng Đạo, Quận 1"
                },
            };
        }

        public void Dispose()
        {
        }
    }
}
