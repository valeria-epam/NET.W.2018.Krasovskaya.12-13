using System;
using System.Threading.Tasks;

namespace Clock
{
    public class CountdownClock
    {
        private readonly int _time;
        private readonly string _message;
        private readonly object _additionalInfo;

        /// <summary>
        /// Initializes a new instance of the <see cref="CountdownClock"/> class.
        /// </summary>
        /// <param name="time">The time.</param>
        /// <param name="message">The message.</param>
        public CountdownClock(int time, string message) : this(time, message, null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CountdownClock"/> class.
        /// </summary>
        /// <param name="time">The time.</param>
        /// <param name="message">The message.</param>
        /// <param name="additionalInfo">The additional information.</param>
        /// <exception cref="System.ArgumentOutOfRangeException">time</exception>
        public CountdownClock(int time, string message, object additionalInfo)
        {
            if (time <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(time));
            }

            _time = time;
            _message = message;
            _additionalInfo = additionalInfo;
        }

        /// <summary>
        /// Occurs when the timer has elapsed.
        /// </summary>
        public event EventHandler<ElapsedEventArgs> Elapsed;

        /// <summary>
        /// Starts the count down.
        /// </summary>
        public async void Start()
        {
            await Task.Delay(_time).ConfigureAwait(false);
            OnElapsed(new ElapsedEventArgs(_message, _additionalInfo));
        }

        /// <summary>
        /// Raises the <see cref="E:Elapsed" /> event.
        /// </summary>
        /// <param name="e">The <see cref="ElapsedEventArgs"/> instance containing the event data.</param>
        protected virtual void OnElapsed(ElapsedEventArgs e) => Elapsed?.Invoke(this, e);
    }
}
