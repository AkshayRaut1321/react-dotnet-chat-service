using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatApp.Models
{
    public class UserConnection
    {
        public string UserName { get; set; }
        public string Room { get; set; }
        public string Message { get; set; }
    }
}
