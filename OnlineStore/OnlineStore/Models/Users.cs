﻿using System.ComponentModel.DataAnnotations;

namespace OnlineStore.Models
{
    public class Users
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
    }
}
