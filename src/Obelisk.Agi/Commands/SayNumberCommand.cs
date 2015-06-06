using System;

namespace Obelisk.Agi.Commands
{
    /// <summary>
    /// Represents a command for saying a number.
    /// </summary>
    public class SayNumberCommand : ObeliskCommand
    {
        /// <summary>
        /// Gets or sets the number.
        /// </summary>
        public string Number
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
        /// Gets or sets the gender.
        /// </summary>
        public string Gender
        {
            get;
            set;
        }

        /// <summary>
        /// Intialises a new instance of the SayNumberCommand class.
        /// </summary>
        public SayNumberCommand(string number, string escapeDigits, string gender)
        {
            Number = number;
            EscapeDigits = escapeDigits;
            Gender = gender;
        }

        /// <summary>
        /// Compiles the command.
        /// </summary>
        public override string Compile()
        {
            return String.Format("SAY NUMBER {0} {1} {2}", 
                EscapeAndQuote(Number), 
                EscapeAndQuote(EscapeDigits),
                EscapeAndQuote(Gender));
        } 
    }
}
