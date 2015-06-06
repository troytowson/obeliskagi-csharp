using System;

namespace Obelisk.Agi.Commands
{
    /// <summary>
    /// Represents a command for getting data.
    /// </summary>
    public class GetDataCommand : ObeliskCommand
    {
        /// <summary>
        /// Gets or sets the file.
        /// </summary>
        public string File
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the timeout.
        /// </summary>
        public long Timeout
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the maximum digits.
        /// </summary>
        public int MaxDigits
        {
            get; 
            set;
        }

        /// <summary>
        /// Initialises a new instance of the GetDataCommand class.
        /// </summary>
        public GetDataCommand(string file, long timeout, int maxDigits)
        {
            File = file;
            Timeout = timeout;
            MaxDigits = maxDigits;
        }

        /// <summary>
        /// Compiles the command.
        /// </summary>
        public override string Compile()
        {
            return String.Format("GET DATA {0} {1} {2}", EscapeAndQuote(File), Timeout, MaxDigits);
        } 
    }
}
