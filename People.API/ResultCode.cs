using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace People.API
{
    public enum ResultCode
    {
        Success,
        NotFound,
        ValidationError,
        ServerError
    }
}
