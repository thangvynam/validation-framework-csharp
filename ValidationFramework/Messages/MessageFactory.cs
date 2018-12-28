namespace ValidationFramework.Messages
{
    class MessageFactory
    {
        private MessageFactory()
        {
        }
        public static MessageContainer Create()
        {
            return new MessageContainer()
            {
                #region "String"
                IsNotNullMessage = "{0} cannot be null ",
                HaveAnyUpperCharacter = "{0} have not any upper character",
                IsNotNullOrWhiteSpace = "IsNotNullOrWhiteSpace",
                IsNullOrWhiteSpace = "IsNullOrWhiteSpace",
                IsBetweenLength = "IsBetweenLength",
                IsMaxLength = "IsMaxLength",
                IsMinLength = "IsMinLength",
                IsExactLength = "IsExactLength",
                IsEmail = "{0} is not email format",
                IsPassword = "IsPassword",
                IsRegex = "IsRegex",
                IsEqualTo = "IsEqualTo",
                #endregion
                
                #region "Integer"
                IsNotZero = "IsNotZero",
                Is = "Is",
                IsGreaterThan = "IsGreaterThan",
                IsLessThan = "IsLessThan",
                IsBetween = "IsBetween",
                #endregion

                #region " Date Time"
                IsDate = "IsDate",
                DateIsGreaterThan = "DateIsGreaterThan",
                DateIsGreaterThanOrEqualTo = "DateIsGreaterThanOrEqualTo",
                DateIsLessThan = "DateIsLessThan",
                DateIsLessThanOrEqualTo = "DateIsLessThanOrEqualTo",
                DateIsEqualTo = "DateIsEqualTo",
                DateIsBetweenInclusive = "DateIsBetweenInclusive",
                DateIsBetweenExclusive = "DateIsBetweenExclusive"
                #endregion
            };
        }
    }
}
