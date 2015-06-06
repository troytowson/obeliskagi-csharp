using System;

namespace Obelisk.Agi.Commands
{
    /// <summary>
    /// Represents a command for setting the stream file.
    /// </summary>
    public class StreamFileCommand : ObeliskCommand
    {
        /// <summary>
        /// Gets or sets the name of the file.
        /// </summary>
        public string FileName
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the escape digits.
        /// </summary>
        public string EscapeDigits
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the sample offset.
        /// </summary>
        public int SampleOffset
        {
            get;
            set;
        }

        /// <summary>
        /// Initialises a new instance of the StreamFileCommand class.
        /// </summary>
        public StreamFileCommand(string fileName, string escapeDigits, int sampleOffset)
        {
            FileName = fileName;
            EscapeDigits = escapeDigits;
            SampleOffset = sampleOffset;
        }

        /// <summary>
        /// Compiles the command.
        /// </summary>
        public override string Compile()
        {
            return String.Format("STREAM FILE {0} {1} {2}", 
                EscapeAndQuote(FileName), 
                EscapeAndQuote(EscapeDigits), 
                SampleOffset);
        } 
    }
}
