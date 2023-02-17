using System.Runtime.Serialization;

namespace Project_RPG_Heroes.Exceptions
{
    [Serializable]
    internal class InvalidArmorException : Exception
    {
        public InvalidArmorException()
        {
        }

        public InvalidArmorException(string? message) : base(message)
        {
        }

        public InvalidArmorException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected InvalidArmorException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}