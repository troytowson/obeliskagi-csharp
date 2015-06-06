using System;

namespace Obelisk.Agi.Commands
{
    /// <summary>
    /// Represents a command for saying a date.
    /// </summary>
    public class SayDateCommand : ObeliskCommand
    {
        /// <summary>
        /// Gets or sets the Date.
        /// </summary>
        public DateTime Date
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the escape digits.
        /// </summary>
        public string EscapeDigits
        {
            get;
            set;
        }

        /// <summary>
        /// Initialises a new instance of the SayDateCommand class.
        /// </summary>
        public SayDateCommand(DateTime date, string escapeDigits)
        {
            Date = date;
            EscapeDigits = escapeDigits;
        }

        /// <summary>
        /// Compiles the command.
        /// </summary>
        public override string Compile()
        {
            return String.Format("SAY DATE {0} {1}",
                Date.Date.Subtract(new DateTime(1970, 1, 1, 0, 0, 0)).TotalSeconds,
                EscapeAndQuote(EscapeDigits));
        } 
    }
}