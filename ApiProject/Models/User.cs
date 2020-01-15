﻿using System;

namespace ApiProject.Models
{
    public class User
    {
        public User()
        {
        }
        
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Username { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }

    }
}