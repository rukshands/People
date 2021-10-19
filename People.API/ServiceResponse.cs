using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People.API
{
    public class BaseResponse
    {
        public ResultCode ResultCode { get; set; }
        public List<ValidationMessage> ValidationMessages { get; set; }
        public string Error { get; set; }
    }

    public class ServiceResponse : BaseResponse
    {
        public object Data { get; set; }
    }

    public class ServiceResponse<T> : BaseResponse
    {
        public T Data { get; set; }
    }
}
