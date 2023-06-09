﻿using System;
using ServiceContract.DTO.Enums;


namespace ServiceContract.DTO
{

    /// <summary>
    /// Acts as a DTO for inserting a new person
    /// </summary>
    public class PersonAddRequest
    {
        public string? PersonName { get; set; }

        public string? Email { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public GenderOptions? Gender { get; set;}

        public Guid? CountryID { get; set;}

        public string? Address { get; set; }

        public bool? ReceiveNewsLetters { get; set; }


    }

}
