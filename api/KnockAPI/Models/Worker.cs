﻿
namespace KnockAPI.Models
{
    public class Worker : User
    {
        public long WorkerId { get; set; }
        public bool? IsAvailable { get; set; }
    }
}