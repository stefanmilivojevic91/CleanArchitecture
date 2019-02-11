using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.UseCases.Login
{
    public class Request
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
