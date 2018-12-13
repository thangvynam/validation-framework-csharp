using ValidationFramework.Errors;
using System.Collections.Generic;
using System.Text;
using System;
using ValidationFramework.Interface;
using ValidationFramework.Show;
using static ValidationFramework.Show.TypeShow;
using ValidationFramework.Decorator;
using ValidationFramework.Messages;
using ValidationFramework.Extensions;

namespace ValidationFramework
{
    public class Validation: IValidation
    {
        private static Validation instance = null;
        private static readonly object padlock = new object();

        private  List<ValidationError> Errors = new List<ValidationError>();
        private  ValidationError LastError = null ;

        private ShowBehavior showBehavior = new TagHTML();


        private Validation()
        {

        }
        public static Validation getInstance
        {
            get
            {
                //Thread - safe
                //This takes care of the memory barrier issue and ensures that only one thread will create an instance
               
                lock (padlock)
                {
                    
                    if (instance == null)
                    {
                        instance = new Validation();
                    }
                    return instance;
                }
                  
            }
        }
        private Validation AddError(string name, string message)
        {
            ValidationError error = new  ValidationError(name, message);
            Errors.Add(error);
            LastError = error;
            return this;
        }
        private Validation NoError()
        {
            LastError = null;
            return this;
        }
        public bool IsValid()
        {
            bool check = (Errors.Count == 0) ? true : false;
            ReSet();
            return check;
        }
        private void ReSet()
        {
            Errors.Clear();
            LastError = null;
        }
        public string GetErrors(params IValidation[] values)
        {
            StringBuilder sb = new StringBuilder();
            if (Errors.Count != 0)
            {
                foreach (ValidationError validationError in Errors)
                {
                    sb.Append(validationError.Message + "\n");
                }
            }
            foreach (ValidationDecorator obj in values)
            {
                sb.Append(obj.GetErrors());               
            }
            ReSet();
            return sb.ToString();
        }
        public void SetShowBehaivor(ShowBehavior sb)
        {
            showBehavior = sb;
        }
        public TypeNotification Show()
        {
            return showBehavior.Show();
        }

        public Validation IsNotNullOrEmpty(string value)
        {
            return IsNotNullOrEmpty("", value, string.Format(MessageFactory.Create().IsNotNullMessage, ""));
        }
        public Validation IsNotNullOrEmpty(string name, string value)
        {
            return IsNotNullOrEmpty(name, value, string.Format(MessageFactory.Create().IsNotNullMessage, name));
        }
        public Validation IsNotNullOrEmpty(string name, string value, string message)
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
        public void ReadProperties(object obj)
        {

        }
    }
}
