using System;

namespace Obelisk.Agi.Commands
{
    /// <summary>
    /// Represents a command for setting the priority.
    /// </summary>
    public class SetPriorityCommand : ObeliskCommand
    {
        /// <summary>
        /// Gets or sets the priority or label.
        /// </summary>
        public string PriorityOrLabel
        {
            get;
            set;
        }

        /// <summary>
        /// Initialises a new instance of the SetPriorityCommand class.
        /// </summary>
        public SetPriorityCommand(string priorityOrLabel)
        {
            PriorityOrLabel = priorityOrLabel;
        }

        /// <summary>
        /// Compiles the command.
        /// </summary>
        public override string Compile()
        {
            return String.Format("SET PRIORITY {0}", EscapeAndQuote(PriorityOrLabel));
        } 
    }
}
