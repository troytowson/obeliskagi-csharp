using System;

namespace Obelisk.Agi.Commands
{
    /// <summary>
    /// Represents a status of the TDD Mode.
    /// </summary>
    public enum TddModeStatus
    {
        On,
        Off
    }

    /// <summary>
    /// Represents a command for toggling the TDD mode.
    /// </summary>
    public class TddModeCommand : ObeliskCommand
    {
        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        public TddModeStatus Status
        {
            get;
            set;
        }

        /// <summary>
        /// Initialises a new instance of the TddModeCommand class.
        /// </summary>
        public TddModeCommand(TddModeStatus status)
        {
            Status = status;
        }

        /// <summary>
        /// Compiles the command.
        /// </summary>
        public override string Compile()
        {
            return String.Format("TDD MODE {0}", Status.ToString().ToUpper());
        } 
    }
}
