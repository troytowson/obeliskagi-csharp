using System;

namespace Obelisk.Agi.Commands
{
    /// <summary>
    /// Represents a command for doing nothing.
    /// </summary>
    public class NoopCommand : ObeliskCommand
    {
        /// <summary>
        /// Compiles the command.
        /// </summary>
        public override string Compile()
        {
            return String.Format("NOOP");
        } 
    }
}
