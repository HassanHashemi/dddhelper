using System;

namespace Domain
{
    public class DomainValidationException : Exception
    {
        public DomainValidationException(int? errorCode, string message) : base(message)
        {
            this.ErrorCode = errorCode;
        }

        public DomainValidationException(string message) : this(null, message)
        {
        }

        public virtual string PropertyName { get; set; }
        public int? ErrorCode { get; set; }
    }
}