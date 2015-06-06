using System;

namespace Obelisk.Agi.Commands
{
    /// <summary>
    /// Represents a command for waiting for a digit.
    /// </summary>
    public class WaitForDigitCommand : ObeliskCommand
    {
        /// <summary>
        /// Gets or sets the timeout of the wait.
        /// </summary>
        /// <remarks>
        /// For an indefinate wait, -1 should be used.
        /// </remarks>
        public int Timeout
        {
            get; 
            set;
        }

        /// <summary>
        /// Initialises a new instance of the WaitForDigitCommand class.
        /// </summary>
        public WaitForDigitCommand(int timeout)
        {
            Timeout = timeout;
        }

        /// <summary>
        /// Compiles the command.
        /// </summary>
        public override string Compile()
        {
            return String.Format("WAIT FOR DIGIT {0}", Timeout);
        }
    }
}
