using System;

namespace Obelisk.Agi.Commands
{
    /// <summary>
    /// Represents a command that says digits.
    /// </summary>
    public class SayDigitsCommand : ObeliskCommand
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
        /// Initialises a new instance SayDigitsCommand class.
        /// </summary>
        public SayDigitsCommand(string number, string escapeDigits)
        {
            Number = number;
            EscapeDigits = escapeDigits;
        }
        
        /// <summary>
        /// Compiles the command.
        /// </summary>
        public override string Compile()
        {
            return String.Format("SAY DIGITS {0} {1}", EscapeAndQuote(Number), EscapeAndQuote(EscapeDigits));
        } 
    }
}
