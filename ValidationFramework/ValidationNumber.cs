using System;
using System.Collections.Generic;
using System.Text;
using ValidationFramework.Decorator;
using ValidationFramework.Errors;
using ValidationFramework.Messages;

namespace ValidationFramework
{
    public class ValidationNumber : ValidationDecorator
    {
        private List<ValidationError> Errors = new List<ValidationError>();
        private ValidationError LastError = null;
        public ValidationNumber(IValidation validation) : base(validation)
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
        private ValidationNumber AddError(string name, string message)
        {
            ValidationError error = new ValidationError(name, message);
            Errors.Add(error);
            LastError = error;
            return this;
        }

        private ValidationNumber NoError()
        {
            LastError = null;
            return this;
        }
    }
}
