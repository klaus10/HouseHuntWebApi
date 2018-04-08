﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using HouseHuntMobile.Services;
namespace HouseHuntMobile.ViewModel
{
    class RegisterViewModel
    {
        ApiService _apiServices = new ApiService();
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Gender { get; set; }
        public int PhoneNum { get; set; }
        public String Street { get; set; }
        public String Çity { get; set; }
        public DateTime BirthDate { get; set; }

        public string Message { get; set; }

        public ICommand RegisterCommand
        {
            get
            {
                return new Command(async () =>
                {
                    var isSuccess = await _apiServices.RegisterAsync(Email, Password, ConfirmPassword, FirstName, LastName, Gender, Street, Çity, PhoneNum, BirthDate);

                    if (isSuccess)
                    {
                        Message = "Register Successfully";
                    }
                    else
                    {
                        Message = "Retry Later";
                    }
                });
            }
        }
    }
}
