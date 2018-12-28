namespace ValidationFramework.Messages
{
    public class MessageContainer
    {
        #region "String"
        #region " Nullable, Empty & Whitespace "
        public string IsNotNullMessage { get; set; }
        public string HaveAnyUpperCharacter { get; set; }
        public string IsNotNullOrWhiteSpace { get; set; }
        public string IsNullOrWhiteSpace { get; set; }
        #endregion
        #region " Lengths "
        public string IsBetweenLength { get; set; }
        public string IsMaxLength { get; set; }
        public string IsMinLength { get; set; }
        public string IsExactLength { get; set; }
        #endregion
        #region " Regular Expression "
        public string IsEmail { get; set; }
        public string IsPassword { get; set; }
        public string IsRegex { get; set; }
        public string IsEqualTo { get; set; }
        #endregion
        #endregion
        #region " Integer "
        public string IsNotZero { get; set; }
        public string Is { get; set; }
        public string IsGreaterThan { get; set; }
        public string IsLessThan { get; set; }
        public string IsBetween { get; set; }
        #endregion
        #region " DateTime "
        #region " IsDate "
        public string IsDate { get; set; }
        #endregion
        #region " Date Comparisons "

        public string DateIsGreaterThan { get; set; }
        public string DateIsGreaterThanOrEqualTo { get; set; }
        public string DateIsLessThan { get; set; }
        public string DateIsLessThanOrEqualTo { get; set; }
        public string DateIsEqualTo { get; set; }
        public string DateIsBetweenInclusive { get; set; }
        public string DateIsBetweenExclusive { get; set; }
        #endregion
        #endregion
    }
}
