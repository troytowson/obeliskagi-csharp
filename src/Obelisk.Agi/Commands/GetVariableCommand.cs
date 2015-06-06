using System;

namespace Obelisk.Agi.Commands
{
    /// <summary>
    /// Represents a command for getting a channel variable.
    /// </summary>
    public class GetVariableCommand : ObeliskCommand
    {
        /// <summary>
        /// Gets or sets the name of the variable.
        /// </summary>
        public string VariableName
        {
            get; 
            set;
        }

        /// <summary>
        /// Initialises a new instance of the GetVariableCommand class.
        /// </summary>
        public GetVariableCommand(string variableName)
        {
            VariableName = variableName;
        }

        /// <summary>
        /// Compiles the command.
        /// </summary>
        public override string Compile()
        {
            return String.Format("GET VARIABLE {0}", EscapeAndQuote(VariableName));
        } 
    }
}
