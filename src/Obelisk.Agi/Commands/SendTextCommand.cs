using System;

namespace Obelisk.Agi.Commands
{
    /// <summary>
    /// Represents a command for sending text.
    /// </summary>
    public class SendTextCommand : ObeliskCommand
    {
        /// <summary>
        /// Gets or sets the test.
        /// </summary>
        public string Text
        {
            get;
            set;
        }
        
        /// <summary>
        /// Initialises a new instance of the SendTextCommand class.
        /// </summary>
        public SendTextCommand(string text)
        {
            Text = text;
        }

        /// <summary>
        /// Compiles the command.
        /// </summary>
        public override string Compile()
        {
            return String.Format("SEND TEXT {0}", EscapeAndQuote(Text));
        } 
    }
}
