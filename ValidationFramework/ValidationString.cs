using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using ValidationFramework.Decorator;
using ValidationFramework.Errors;
using ValidationFramework.Extensions;
using ValidationFramework.Messages;

namespace ValidationFramework
{
    
    public class ValidationString : ValidationDecorator
    {
        private List<ValidationError> Errors = new List<ValidationError>();
        private ValidationError LastError = null;

        
        public ValidationString( IValidation validation) : base( validation)
        {
        }
        public new bool IsValid()
        {
            bool check1 = validation.IsValid();
            bool check2 = IsOwnValid();
            if (check1 && check2)
                return true;
            return false;
        }

        public bool IsOwnValid()
        {
            bool check = (Errors.Count == 0) ? true : false;
            return check;
        }

        private ValidationString AddError(string name, string message)
        {
            ValidationError error = new ValidationError(name, message);
            Errors.Add(error);
            LastError = error;
            return this;
        }

        private ValidationString NoError()
        {
            LastError = null;
            return this;
        }


        
        public ValidationString IsNotNullOrEmpty(string value)
        {
            return IsNotNullOrEmpty("", value, string.Format(MessageFactory.Create().IsNotNullMessage, ""));
        }
        public ValidationString IsNotNullOrEmpty(string name, string value)
        {
            return IsNotNullOrEmpty(name, value, string.Format(MessageFactory.Create().IsNotNullMessage, name));
        }
        public ValidationString IsNotNullOrEmpty(string name, string value, string message)
        {
            if (value.IsNotNullOrEmpty())
            {
                return NoError();
            }
            else
            {
                return AddError(name, message);
            }
        }

        public ValidationString HaveAnyUpperCharacter(string value)
        {
            return HaveAnyUpperCharacter("", value, string.Format(MessageFactory.Create().HaveAnyUpperCharacter, ""));
        }
        public ValidationString HaveAnyUpperCharacter(string name, string value)
        {
            return HaveAnyUpperCharacter(name, value, string.Format(MessageFactory.Create().HaveAnyUpperCharacter, name));
        }
        public ValidationString HaveAnyUpperCharacter(string name, string value, string message)
        {
            if (value.HaveAnyUpperCharacter())
            {
                return NoError();
            }
            else
            {
                return AddError(name, message);
            }
        }

        public override string GetErrors()
        {
            if (Errors.Count == 0)
                return "";
            StringBuilder sb = new StringBuilder();
            foreach (ValidationError validationError in Errors)
            {
                sb.Append(validationError.Message + "\n");
            }
            return sb.ToString();
        }
       
    }
}
