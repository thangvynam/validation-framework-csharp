using System;
using System.Collections.Generic;
using System.Text;
using ValidationFramework.Messages;
using ValidationFramework.Extensions;

namespace ValidationFramework
{
    public partial class Validation
    {
        public Validation IsNotNullOrEmpty(string value)
        {
            return IsNotNullOrEmpty("",value, string.Format(MessageFactory.Create().IsNotNullMessage,""));
        }
        public Validation IsNotNullOrEmpty(string name,string value)
        {
            return IsNotNullOrEmpty(name,value, string.Format(MessageFactory.Create().IsNotNullMessage, name));
        }
        public Validation IsNotNullOrEmpty(string name,string value, string message)
        {
            if (value.IsNotNullOrEmpty())
            {
                return NoError();
            }
            else
            {
                return AddError(name,message);
            }
        }
    }
}
