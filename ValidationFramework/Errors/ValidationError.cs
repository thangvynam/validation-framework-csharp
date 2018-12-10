using System;
using System.Collections.Generic;
using System.Text;

namespace ValidationFramework.Errors
{
    public class ValidationError
    {
        public string Message { get; set; }
        public string Name { get; set; }
        

        public  ValidationError()
        {
            this.Message = "";
            this.Name = "";
        }

        public ValidationError(string Name,string Message)
        {
            this.Message = Message;
            this.Name = Name;
        }

    }
}
