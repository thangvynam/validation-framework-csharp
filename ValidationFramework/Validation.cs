using ValidationFramework.Errors;
using System.Collections.Generic;
using System.Text;
using System;
namespace ValidationFramework
{
    public partial class Validation 
    {
        private static Validation instance = null;
        private static readonly object padlock = new object();

        private  List<ValidationError> Errors = new List<ValidationError>();
        private  ValidationError LastError = null ;


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
        private Validation AddError(string name,string message)
        {
            ValidationError error = ValidationError.Create(name,message);
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
        public string GetErrors()
        {
            if (Errors.Count == 0)
                return "";
            StringBuilder sb = new StringBuilder();
            foreach(ValidationError validationError in Errors)
            {
                sb.Append(validationError.Message + "\n");
            }
            return sb.ToString();
        }
        
    }
}
