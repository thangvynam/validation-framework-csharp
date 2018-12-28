using System;
using System.Collections.Generic;
using System.Text;

using ValidationFramework.Decorator;
using ValidationFramework.Errors;
using ValidationFramework.Extensions;
using ValidationFramework.Messages;

namespace ValidationFramework
{
    public class ValidationRegularExpression : ValidationDecorator
    {
        private List<ValidationError> Errors = new List<ValidationError>();
        private ValidationError LastError = null;
        public ValidationRegularExpression(IValidation validation) : base(validation)
        {
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

        public ValidationRegularExpression IsEmail(string value)
        {
            return IsEmail("", value, string.Format(MessageFactory.Create().IsEmail, ""));
        }
        public ValidationRegularExpression IsEmail(string name, string value)
        {
            return IsEmail(name, value, string.Format(MessageFactory.Create().IsEmail, name));
        }
        public ValidationRegularExpression IsEmail(string name, string value, string message)
        {
            if (value.IsEmail())
            {
                return NoError();
            }
            else
            {
                return AddError(name, message);
            }
        }

        public ValidationRegularExpression IsPassword(string value)
        {
            return IsPassword("", value, string.Format(MessageFactory.Create().IsPassword, ""));
        }
        public ValidationRegularExpression IsPassword(string name, string value)
        {
            return IsPassword(name, value, string.Format(MessageFactory.Create().IsPassword, name));
        }
        public ValidationRegularExpression IsPassword(string name, string value, string message)
        {
            if (value.IsPassword())
            {
                return NoError();
            }
            else
            {
                return AddError(name, message);
            }
        }

        public ValidationRegularExpression IsRegex(string value,string exp)
        {
            return IsRegex("", value, string.Format(MessageFactory.Create().IsRegex, ""));
        }
        public ValidationRegularExpression IsRegex(string name, string value, string exp)
        {
            return IsRegex(name, value, string.Format(MessageFactory.Create().IsRegex, name));
        }
        public ValidationRegularExpression IsRegex(string name, string value, string message, string exp)
        {
            if (value.IsRegex(exp))
            {
                return NoError();
            }
            else
            {
                return AddError(name, message);
            }
        }

        public ValidationRegularExpression IsEqualTo(string value, string compare)
        {
            return IsEqualTo("", value, string.Format(MessageFactory.Create().IsEqualTo, ""));
        }
        public ValidationRegularExpression IsEqualTo(string name, string value, string compare)
        {
            return IsEqualTo(name, value, string.Format(MessageFactory.Create().IsEqualTo, name));
        }
        public ValidationRegularExpression IsEqualTo(string name, string value, string message, string compare)
        {
            if (value.IsEqualTo(compare))
            {
                return NoError();
            }
            else
            {
                return AddError(name, message);
            }
        }



        private ValidationRegularExpression AddError(string name, string message)
        {
            ValidationError error = new ValidationError(name, message);
            Errors.Add(error);
            LastError = error;
            return this;
        }

        private ValidationRegularExpression NoError()
        {
            LastError = null;
            return this;
        }
    }
}
