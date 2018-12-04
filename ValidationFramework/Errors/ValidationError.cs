using System;
using System.Collections.Generic;
using System.Text;

namespace ValidationFramework.Errors
{
    public class ValidationError
    {
        public string Message { get; set; }
        public string Name { get; set; }
        private static ValidationError instance = null;
        private static readonly object padlock = new object();

        private ValidationError()
        {
            this.Message = "";
            this.Name = "";
        }

        private ValidationError(string Name,string Message)
        {
            this.Message = Message;
            this.Name = Name;
        }

        public static ValidationError Create(string Name,string Message)
        {
            //Thread - safe
            //This takes care of the memory barrier issue and ensures that only one thread will create an instance
            lock (padlock)
            {
                if (instance == null)
                {
                    instance = new ValidationError(Name,Message);
                }
                return instance;
            }
        }
    }
}
