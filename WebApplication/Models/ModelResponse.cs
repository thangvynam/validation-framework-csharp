using System;
using System.Collections.Generic;
using System.Text;
using static ValidationFramework.Show.TypeShow;

namespace ValidationFramework
{
    class ModelResponse
    {
        public string Message { get; set; }
        public bool Check { get; set; }
        public TypeNotification typeNotification { get; set; }
        public ModelResponse()
        {
        }

        public ModelResponse(string message, bool check , TypeNotification typeNotification)
        {
            this.Message = message;
            this.Check = check;
            this.typeNotification = typeNotification;
        }
    }
}
