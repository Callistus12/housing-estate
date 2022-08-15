﻿
using Calischool.Models;

namespace Calischool.ViewModel
{
    public class RegisterViewModel 
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string RegNumber { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string RedsidentAddress { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string LGA { get; set; }
        public string Qualification { get; set; }
        public string Displine { get; set; }
        public string Password { get; set; }
        public string ComfirmPassword { get; set; }
    }
}
