using System;

namespace Obelisk.Agi.Commands
{
    public class RecordFileCommand : ObeliskCommand
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
        /// Gets or sets the format.
        /// </summary>
        public string Format
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
        /// Gets or sets the timeout.
        /// </summary>
        public int Timeout
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the samples offset.
        /// </summary>
        public int OffsetSamples
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets whether the beep is enabled.
        /// </summary>
        public bool EnableBeep
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the maximum silence.
        /// </summary>
        public int MaxSilence
        {
            get;
            set;
        }

        /// <summary>
        /// Intialises a new instance of the RecordFileCommand class.
        /// </summary>
        public RecordFileCommand(string fileName, string format, string escapeDigits, int timeout, int offsetSamples, bool enableBeep, int maxSilence)
        {
            FileName = fileName;
            Format = format;
            EscapeDigits = escapeDigits;
            Timeout = timeout;
            OffsetSamples = offsetSamples;
            EnableBeep = enableBeep;
            MaxSilence = maxSilence;
        }

        /// <summary>
        /// Compiles the command
        /// </summary>
        public override string Compile()
        {
            return String.Format("RECORD FILE {0} {1} {2} {3} {4} {5} S={6}",
                EscapeAndQuote(FileName),
                EscapeAndQuote(Format),
                EscapeAndQuote(EscapeDigits),
                Timeout,
                OffsetSamples,
                EnableBeep ? "BEEP" : String.Empty,
                MaxSilence);
        } 
    }
}
