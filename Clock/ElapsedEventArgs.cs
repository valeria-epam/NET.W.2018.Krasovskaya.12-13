using System;

namespace Clock
{
    public class ElapsedEventArgs : EventArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ElapsedEventArgs"/> class.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="additionalInfo">The additional information.</param>
        public ElapsedEventArgs(string message, object additionalInfo)
        {
            this.Message = message;
            this.AdditionalInfo = additionalInfo;
        }

        /// <summary>
        /// Gets the message.
        /// </summary>
        public string Message { get; }

        /// <summary>
        /// Gets the additional information.
        /// </summary>
        public object AdditionalInfo { get; }
    }
}
