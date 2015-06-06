using System;

namespace Obelisk.Agi.Commands
{
    /// <summary>
    /// Represents a command for getting a variable by its name per channel.
    /// </summary>
    public class GetFullVariablesCommand : ObeliskCommand
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
        /// Gets or sets the name of the channel.
        /// </summary>
        public string ChannelName
        {
            get;
            set;
        }

        /// <summary>
        /// Initialises a new instance of the GetFullVariablesCommand class.
        /// </summary>
        public GetFullVariablesCommand(string variableName, string channelName)
        {
            VariableName = variableName;
            ChannelName = channelName;
        }

        /// <summary>
        /// Compiles the command.
        /// </summary>
        public override string Compile()
        {
            return String.Format("GET FULL VARIABLE {0} {1}", EscapeAndQuote(VariableName), EscapeAndQuote(ChannelName));
        } 
    }
}
