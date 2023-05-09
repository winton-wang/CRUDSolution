﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace ServiceContract.DTO
{
    /// <summary>
    /// DTO class that is used as return type for most of CountriesService Methods
    /// </summary>
    public class CountryResponse
    {
        public Guid CountryID { get; set; }

        public string? CountryName { get; set; }

        public override bool Equals(object? obj)
        {
            if (obj == null) 
            {
                return false;
            }

            if ( obj.GetType() != typeof(CountryResponse))
            {
                return false;
            }
            CountryResponse country_to_compare = (CountryResponse)obj;
            return CountryID == country_to_compare.CountryID &&
                CountryName == country_to_compare.CountryName;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

    }

    public static class CountryExtensions
    {
        public static CountryResponse ToCountryResponse(this Country country)
        {
            return new CountryResponse() { CountryID = country.CountryID, CountryName = country.CountryName };
        }
    }

}
