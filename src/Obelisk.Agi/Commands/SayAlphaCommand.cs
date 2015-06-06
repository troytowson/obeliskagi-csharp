using System;

namespace Obelisk.Agi.Commands
{
    /// <summary>
    /// Represents a command for saying a given string.
    /// </summary>
    public class SayAlphaCommand : ObeliskCommand
    {
        /// <summary>
        /// Gets or sets the number or test that will be said.
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
        /// Initialises a new instance of the SayAlphaCommand class.
        /// </summary>
        public SayAlphaCommand(string number, string escapeDigits)
        {
            Number = number;
            EscapeDigits = escapeDigits;
        }

        /// <summary>
        /// Compiles the command.
        /// </summary>
        public override string Compile()
        {
            return String.Format("SAY ALPHA {0} {1}", EscapeAndQuote(Number), EscapeAndQuote(EscapeDigits));
        } 
    }
}
