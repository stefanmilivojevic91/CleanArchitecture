using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Commons
{
    public class NullUseCaseResponse
    {
        public static NullUseCaseResponse Null()
        {
            return new NullUseCaseResponse();
        }
    }
}
