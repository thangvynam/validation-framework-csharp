using System;
using System.Collections.Generic;
using System.Text;

namespace ValidationFramework
{
    class ModelResponse
    {
        public string Message { get; set; }
        public bool Check { get; set; }

        public ModelResponse()
        {
        }

        public ModelResponse(string message, bool check)
        {
            Message = message;
            Check = check;
        }
    }
}
