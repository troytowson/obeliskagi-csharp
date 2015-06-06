using System;

namespace Obelisk.Agi.Commands
{
    /// <summary>
    /// Represents a command for checking the status of the channel.
    /// </summary>
    public class ChannelStatusCommand : ObeliskCommand
    {
        /// <summary>
        /// The name of the channel.
        /// </summary>
        public string ChannelName
        {
            get;
            set;
        }

        /// <summary>
        /// Initialises a new instance of the ChannelStatusCommand class.
        /// </summary>
        public ChannelStatusCommand(string channelName = null)
        {
            ChannelName = channelName;
        }

        /// <summary>
        /// Compiles the command.
        /// </summary>
        public override string Compile()
        {
            return String.Format("CHANNEL STATUS {0}", EscapeAndQuote(ChannelName));
        } 
    }
}
