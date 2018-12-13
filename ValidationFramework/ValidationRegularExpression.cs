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
