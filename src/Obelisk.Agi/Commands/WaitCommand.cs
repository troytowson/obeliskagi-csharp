using System;

namespace Obelisk.Agi.Commands
{
    /// <summary>
    /// Represents a command to wait for a specific duration.
    /// </summary>
    public sealed class WaitCommand : ObeliskCommand
    {
        /// <summary>
        /// Gets or sets the Duration of the wait.
        /// </summary>
        public int Duration
        {
            get;
            set;
        } 

        /// <summary>
        /// Initialises a new instance of the WaitCommand class.
        /// </summary>
        public WaitCommand(int duration)
        {
            Duration = duration;
        }

        /// <summary>
        /// Compiles the command.
        /// </summary>
        public override string Compile()
        {
            return String.Format("EXEC WAIT {0}", EscapeAndQuote(Duration.ToString()));
        } 
    }
}
