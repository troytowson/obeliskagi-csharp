using System;

namespace Obelisk.Agi.Commands
{
    /// <summary>
    /// Represents a command for getting an option.
    /// </summary>
    public class GetOptionCommand: ObeliskCommand
    {
        /// <summary>
        /// Gets or sets the name of the file.
        /// </summary>
        public string FileName
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
        /// Gets or sets timeout.
        /// </summary>
        public int Timeout
        {
            get; 
            set;
        }

        /// <summary>
        /// Initialises a new instance of the GetOptionCommand class.
        /// </summary>
        public GetOptionCommand(string fileName, string escapeDigits, int timeout)
        {
            FileName = fileName;
            EscapeDigits = escapeDigits;
            Timeout = timeout;
        }

        /// <summary>
        /// Compiles the command.
        /// </summary>
        public override string Compile()
        {
            return String.Format("GET OPTION {0} {1} {2}", EscapeAndQuote(FileName), EscapeAndQuote(EscapeDigits), Timeout);
        } 
    }
}
