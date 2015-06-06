using System;

namespace Obelisk.Agi.Commands
{
    /// <summary>
    /// Represents a command for hanging up.
    /// </summary>
    public class HangUpCommand : ObeliskCommand
    {
        /// <summary>
        /// Gets or sets the channel.
        /// </summary>
        public string ChannelName
        {
            get;
            set;
        }

        /// <summary>
        /// Initialies a new instance of the HangUpCommand class.
        /// </summary>
        public HangUpCommand(string channelName)
        {
            ChannelName = channelName;
        }

        /// <summary>
        /// Compiles the command.
        /// </summary>
        public override string Compile()
        {
            var res = String.Format("HANGUP {0}", EscapeAndQuote(ChannelName));
            return res;
        } 
    }
}
