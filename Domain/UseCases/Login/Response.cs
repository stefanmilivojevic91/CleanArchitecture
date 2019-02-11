using Domain.Commons;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.UseCases.Login
{
    public class Response
    {
        public int UserId { get; set; }

        public static Response Null()
        {
            return new Response();
        }
    }
}
