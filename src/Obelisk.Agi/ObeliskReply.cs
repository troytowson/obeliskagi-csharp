using System;
using System.Text.RegularExpressions;

namespace Obelisk.Agi
{
    /// <summary>
    /// Represents a status code of the reply.
    /// </summary>
    public enum ObeliskReplyStatusCode
    {
        Trying = 100,
        Success = 200,
        InvalidOrUnknownCommand = 510,
        DeadChannel = 511,
        InvalidCommandSyntax = 520,
    }

    /// <summary>
    /// Represents a reply from the asterisk server.
    /// </summary>
    public class ObeliskReply
    {
        private static readonly Regex StatusPattern = new Regex("^(\\d{3})[ -]", RegexOptions.Compiled);
        private static readonly Regex ResultPattern = new Regex("^200 result= *(\\S+)", RegexOptions.Compiled);

        /// <summary>
        /// Gets the first line of the reply.
        /// </summary>
        public string Line
        {
            get; 
            private set;
        }

        /// <summary>
        /// Gets the result of the reply.
        /// </summary>
        public string Result
        {
            get; 
            private set;
        }

        /// <summary>
        /// Gets the result code of the reply.
        /// </summary>
        public int ResultCode
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the status code of the reply.
        /// </summary>
        public ObeliskReplyStatusCode StatusCode
        {
            get; 
            private set;
        }

        /// <summary>
        /// Initialises a new instance of the ObeliskReply class.
        /// </summary>
        public ObeliskReply(string line)
        {
            Line = line;

            SetResult(line);
            SetStatus(line);
        }
        
        /// <summary>
        /// Sets the status.
        /// </summary>
        private void SetStatus(string line)
        {
            StatusCode = ObeliskReplyStatusCode.InvalidOrUnknownCommand;

            var matcher = StatusPattern.Match(line);

            if (matcher.Success)
                StatusCode = (ObeliskReplyStatusCode)Int32.Parse(matcher.Groups[1].Value);
        }

        /// <summary>
        /// Sets the result.
        /// </summary>
        public void SetResult(string line)
        {
            ResultCode = -1;
            Result = "-1";

            var matcher = ResultPattern.Match(line);

            if (!matcher.Success)
                return;

            Result = matcher.Groups[1].Value;

            int resultCode;
            if (Int32.TryParse(Result, out resultCode))
                ResultCode = resultCode;
        } 
    }
}
