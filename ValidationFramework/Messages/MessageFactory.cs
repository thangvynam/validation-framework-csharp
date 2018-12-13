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
                IsNotNullMessage = "{0} cannot be null ",
                HaveAnyUpperCharacter = "{0} have not any upper character",
                IsEmail="{0} is not email format",
            };
        }
    }
}
