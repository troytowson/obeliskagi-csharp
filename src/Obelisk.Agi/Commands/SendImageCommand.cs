using System;

namespace Obelisk.Agi.Commands
{
    /// <summary>
    /// Represents a command for sending an image.
    /// </summary>
    public class SendImageCommand : ObeliskCommand
    {
        /// <summary>
        /// Gets or sets the image.
        /// </summary>
        public string Image
        {
            get;
            set;
        }

        /// <summary>
        /// Initialises a new instance of the SendImageCommand class.
        /// </summary>
        public SendImageCommand(string image)
        {
            Image = image;
        }

        /// <summary>
        /// Compiles the command.
        /// </summary>
        public override string Compile()
        {
            return String.Format("SEND IMAGE {0}", EscapeAndQuote(Image));
        } 
    }
}
