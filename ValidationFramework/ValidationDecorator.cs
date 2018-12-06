using System;
using System.Collections.Generic;
using System.Text;
using ValidationFramework.Decorator;

namespace ValidationFramework
{
    public abstract class  ValidationDecorator : IValidation
    {
        private IValidation validation;

        public bool IsValid()
        {
            return validation.IsValid();
        }
    }
}
