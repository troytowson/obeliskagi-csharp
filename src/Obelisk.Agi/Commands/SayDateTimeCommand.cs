using System;

namespace Obelisk.Agi.Commands
{
    /// <summary>
    /// Represents a command for saying a date time.
    /// </summary>
    public class SayDateTimeCommand : ObeliskCommand
    {
        /// <summary>
        /// Gets or sets the date time. 
        /// </summary>
        public DateTime DateTime
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
        /// Gets or sets the format.
        /// </summary>
        public string Format
        {
            get; 
            set;
        }

        /// <summary>
        /// Gets or sets the timezone.
        /// </summary>
        public string Timezone
        {
            get; 
            set;
        }

        /// <summary>
        /// Initialises a new instance of the SayDateTimeCommand class.
        /// </summary>
        public SayDateTimeCommand(DateTime dateTime, string escapeDigits, string format, string timezone)
        {
            DateTime = dateTime;
            EscapeDigits = escapeDigits;
            Format = format;
            Timezone = timezone;
        }

        /// <summary>
        /// Compiles the command.
        /// </summary>
        public override string Compile()
        {
            return String.Format("SAY DATETIME {0} {1} {2} {3}",
                DateTime.Subtract(new DateTime(1970, 1, 1, 0, 0, 0)).TotalSeconds,
                EscapeAndQuote(EscapeDigits),
                EscapeAndQuote(Format),
                EscapeAndQuote(Timezone));
        }
    }
}
