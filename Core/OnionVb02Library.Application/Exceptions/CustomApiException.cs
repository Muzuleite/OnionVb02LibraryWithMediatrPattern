using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionVb02Library.Application.Exceptions
{
    public class CustomApiException : Exception
    {
        public int StatusCode { get; }
        public string ErrorCode { get; }
        public List<string> Errors { get; }

        public CustomApiException(int statusCode, string message, string errorCode = null, List<string> errors = null)
            : base(message)
        {
            StatusCode = statusCode;
            ErrorCode = errorCode;
            Errors = errors;
        }
    }

}
