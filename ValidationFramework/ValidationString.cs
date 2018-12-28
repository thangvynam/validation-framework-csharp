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
        #region " Nullable, Empty & Whitespace "
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

        public ValidationString IsNotNullOrWhiteSpace(string value)
        {
            return IsNotNullOrWhiteSpace("", value, string.Format(MessageFactory.Create().IsNotNullOrWhiteSpace, ""));
        }
        public ValidationString IsNotNullOrWhiteSpace(string name, string value)
        {
            return IsNotNullOrWhiteSpace(name, value, string.Format(MessageFactory.Create().IsNotNullOrWhiteSpace, name));
        }
        public ValidationString IsNotNullOrWhiteSpace(string name, string value, string message)
        {
            if (value.IsNotNullOrWhiteSpace())
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

        public ValidationString IsNullOrWhiteSpace(string value)
        {
            return IsNullOrWhiteSpace("", value, string.Format(MessageFactory.Create().IsNullOrWhiteSpace, ""));
        }
        public ValidationString IsNullOrWhiteSpace(string name, string value)
        {
            return IsNullOrWhiteSpace(name, value, string.Format(MessageFactory.Create().IsNullOrWhiteSpace, name));
        }
        public ValidationString IsNullOrWhiteSpace(string name, string value, string message)
        {
            if (value.IsNullOrWhiteSpace())
            {
                return NoError();
            }
            else
            {
                return AddError(name, message);
            }
        }
        #endregion

        #region " Lengths "
        public ValidationString IsBetweenLength(string value, int min, int max)
        {
            return IsBetweenLength("", value, string.Format(MessageFactory.Create().IsBetweenLength, ""),min,max);
        }
        public ValidationString IsBetweenLength(string name, string value, int min, int max)
        {
            return IsBetweenLength(name, value, string.Format(MessageFactory.Create().IsBetweenLength, name),min,max);
        }
        public ValidationString IsBetweenLength(string name, string value, string message, int min, int max)
        {
            if (value.IsBetweenLength(min,max))
            {
                return NoError();
            }
            else
            {
                return AddError(name, message);
            }
        }

        public ValidationString IsMaxLength(string value,int max)
        {
            return IsMaxLength("", value, string.Format(MessageFactory.Create().IsMaxLength, ""),max);
        }
        public ValidationString IsMaxLength(string name, string value,int max)
        {
            return IsMaxLength(name, value, string.Format(MessageFactory.Create().IsMaxLength, name),max);
        }
        public ValidationString IsMaxLength(string name, string value, string message,int max)
        {
            if (value.IsMaxLength(max))
            {
                return NoError();
            }
            else
            {
                return AddError(name, message);
            }
        }

        public ValidationString IsMinLength(string value,int min)
        {
            return IsMinLength("", value, string.Format(MessageFactory.Create().IsMinLength, ""),min);
        }
        public ValidationString IsMinLength(string name, string value, int min)
        {
            return IsMinLength(name, value, string.Format(MessageFactory.Create().IsMinLength, name),min);
        }
        public ValidationString IsMinLength(string name, string value, string message,int min)
        {
            if (value.IsMinLength(min))
            {
                return NoError();
            }
            else
            {
                return AddError(name, message);
            }
        }

        public ValidationString IsExactLength(string value, int length)
        {
            return IsExactLength("", value, string.Format(MessageFactory.Create().IsExactLength, ""), length);
        }
        public ValidationString IsExactLength(string name, string value, int length)
        {
            return IsExactLength(name, value, string.Format(MessageFactory.Create().IsExactLength, name), length);
        }
        public ValidationString IsExactLength(string name, string value, string message,int length)
        {
            if (value.IsExactLength(length))
            {
                return NoError();
            }
            else
            {
                return AddError(name, message);
            }
        }
        #endregion

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
