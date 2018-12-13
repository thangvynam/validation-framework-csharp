using System;
using System.Collections.Generic;
using System.Text;
using static ValidationFramework.Show.TypeShow;

namespace ValidationFramework
{
    class ModelResponse
    {
        public string Message { get; set; }
        public TypeNotification typeNotification { get; set; }
        public ModelResponse()
        {
        }

        public ModelResponse(string message ,TypeNotification typeNotification)
        {
            this.Message = message;
            this.typeNotification = typeNotification;
        }
    }
}
