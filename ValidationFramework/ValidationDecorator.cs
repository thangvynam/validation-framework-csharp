using System;
using System.Collections.Generic;
using System.Text;
using ValidationFramework.Decorator;

namespace ValidationFramework
{
    public abstract class ValidationDecorator : IValidation
    {
        protected IValidation validation;

        public ValidationDecorator(IValidation validation)
        {
            this.validation = validation;
        }

        public bool IsValid()
        {
            return validation.IsValid();
        }
        public abstract string GetErrors();
    }
}
