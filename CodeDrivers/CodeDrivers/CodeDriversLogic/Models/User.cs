﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeDrivers.Models
{
    internal class User
    {
        private string dateOfBirth;

        public string Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string DateOfBirth { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public string DrivingLicenceNumber { get; set; }
        List<User> Users { get; set; } = new List<User>();
        public User(string id, string name, string lastName, string dateOfBirth, string email, string password, string phoneNumber, string drivingLicenceNumber)
        {
            Id = id;
            Name = name;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            Email = email;
            Password = password;
            PhoneNumber = phoneNumber;
            DrivingLicenceNumber = drivingLicenceNumber;
        }
    }
}
