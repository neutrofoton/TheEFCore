﻿using System;
namespace TheEFCore.Domain.Model
{
    public class Address
    {
        public int Id { get; set; }
        public string ShortAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }

        public int? StudentId { get; set; }
        public Student Student { get; set; }
    }
}
