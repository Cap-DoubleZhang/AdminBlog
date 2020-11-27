using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Shared
{
    public class ErrorModel
    {
        public ErrorCode StatusCode { get; set; }
        public string Error { get; set; }

        public ErrorModel(string error)
        {
            this.Error = error;
        }

        public ErrorModel(ErrorCode statusCode, string error)
        {
            this.Error = error;
            this.StatusCode = statusCode;
        }
    }
}
