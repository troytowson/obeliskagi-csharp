using System;

namespace Obelisk.Agi.Commands
{
    /// <summary>
    /// Represents a command for setting a variable by name.
    /// </summary>
    public class SetVariableCommand : ObeliskCommand
    {
        /// <summary>
        /// Gets or sets the name of the variable.
        /// </summary>
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the value of the variable.
        /// </summary>
        public string Value
        {
            get;
            set;
        }

        /// <summary>
        /// Initialises a new instance of the SetVariableCommand class.
        /// </summary>
        public SetVariableCommand(string name, string value)
        {
            Name = name;
            Value = value;
        }

        /// <summary>
        /// Compiles the command.
        /// </summary>
        public override string Compile()
        {
            return String.Format("SET VARIABLE {0} {1}", EscapeAndQuote(Name), EscapeAndQuote(Value));
        } 
    }
}
