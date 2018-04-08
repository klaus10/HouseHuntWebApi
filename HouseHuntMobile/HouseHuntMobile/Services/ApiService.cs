using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using HouseHuntMobile.Model;

namespace HouseHuntMobile.Services
{
    class ApiService
    {
        public async Task<bool> RegisterAsync(string email, string password, string confirmPassword, string firstname, string lastname, string gender, string street, string city, int phonenum, DateTime birthdate)
        {
            var client = new HttpClient();
            var model = new RegisterBinding
            {
                Email = email,
                Password = password,
                ConfirmPassword = confirmPassword,
                FirstName = firstname,
                LastName = lastname,
                Gender = gender,
                Street = street,
                Çity = city,
                PhoneNum = phonenum,
                BirthDate = birthdate


            };

            var json = JsonConvert.SerializeObject(model);

            HttpContent content = new StringContent(json);

            content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

            var response = await client.PostAsync("http://localhost:51043/api/Register", content);

            return response.IsSuccessStatusCode;

        }
    }
}
