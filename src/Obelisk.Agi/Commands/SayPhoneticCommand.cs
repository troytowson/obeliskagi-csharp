using System;

namespace Obelisk.Agi.Commands
{
    /// <summary>
    /// Represents a command for saying phonetics.
    /// </summary>
    public class SayPhoneticCommand : ObeliskCommand
    {
        /// <summary>
        /// Gets or sets the string. 
        /// </summary>
        public string String
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
        /// Initialises a new instance of the SayPhoneticCommand class.
        /// </summary>
        public SayPhoneticCommand(string @string, string escapeDigits)
        {
            String = @string;
            EscapeDigits = escapeDigits;
        }

        /// <summary>
        /// Compiles a command.
        /// </summary>
        public override string Compile()
        {
            return String.Format("SAY PHONETIC {0} {1}", 
                EscapeAndQuote(String), 
                EscapeAndQuote(EscapeDigits));
        } 
    }
}
