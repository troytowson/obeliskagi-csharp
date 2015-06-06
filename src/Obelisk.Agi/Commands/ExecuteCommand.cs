using System;

namespace Obelisk.Agi.Commands
{
    /// <summary>
    /// Represents a command for the EXEC command.
    /// </summary>
    public class ExecuteCommand : ObeliskCommand
    {
        /// <summary>
        /// Gets or sets the application.
        /// </summary>
        public string Application
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the options.
        /// </summary>
        public string[] Options
        {
            get;
            set;
        }

        /// <summary>
        /// Initialises a new instance of the ExecuteCommand class.
        /// </summary>
        public ExecuteCommand(string application, params string[] options)
        {
            Application = application;
            Options = options;
        }

        /// <summary>
        /// Compiles the command.
        /// </summary>
        public override string Compile()
        {
            return String.Format("EXEC {0} {1}", Application, EscapeAndQuote(Options));
        } 
    }
}
