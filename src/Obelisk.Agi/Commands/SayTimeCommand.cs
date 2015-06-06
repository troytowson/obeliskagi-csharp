using System;

namespace Obelisk.Agi.Commands
{
    /// <summary>
    /// Represents a command for saying the time.
    /// </summary>
    public class SayTimeCommand : ObeliskCommand
    {
        /// <summary>
        /// Gets or sets the time.
        /// </summary>
        public TimeSpan Time
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the time.
        /// </summary>
        public string EscapeDigits
        {
            get;
            set;
        }

        /// <summary>
        /// Initialises a new instance of the SayTimeCommand class.
        /// </summary>
        public SayTimeCommand(TimeSpan time, string escapeDigits)
        {
            Time = time;
            EscapeDigits = escapeDigits;
        }

        /// <summary>
        /// Compiles the command.
        /// </summary>
        public override string Compile()
        {
            var baseDate = new DateTime(1970, 1, 1);
            var currentDate = DateTime.Now.Date.Add(Time);

            return String.Format("SAY TIME {0} {1}", 
                currentDate.Subtract(baseDate).TotalSeconds,
                EscapeAndQuote(EscapeDigits));
        } 
    }
}