﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Store_Memory
{
    public class User1
    {
        private static int instCounter = 1;

        public int Id { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string Phone { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public User1(string email, string password)
        {
            Id = instCounter;
            Email = email;
            Password = password;
            instCounter += 1;
        }
    }



}
