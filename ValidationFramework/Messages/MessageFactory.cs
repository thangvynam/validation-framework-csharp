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
            };
        }
    }
}
