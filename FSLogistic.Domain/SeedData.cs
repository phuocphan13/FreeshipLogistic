using FSLogistic.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace FSLogistic.Domain
{
    public class SeedData
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
    }
}
