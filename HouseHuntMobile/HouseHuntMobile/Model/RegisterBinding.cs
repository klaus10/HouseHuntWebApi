﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HouseHuntMobile.Model
{
    class RegisterBinding
    {
        public string Email { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Gender { get; set; }
        public int PhoneNum { get; set; }
        public String Street { get; set; }
        public String Çity { get; set; }
        public DateTime BirthDate { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }

    }
}
