using System;

namespace Obelisk.Agi.Commands
{
    /// <summary>
    /// Represents a command for Ading or updating an entry in the Asterisk database for a given family, key, and value.
    /// </summary>
    public class DatabasePutCommand : ObeliskCommand
    {
        /// <summary>
        /// Gets or sets the family.
        /// </summary>
        public string Family
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the key.
        /// </summary>
        public string Key
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        public string Value
        {
            get;
            set;
        }

        /// <summary>
        /// Initialises a new instance of the DatabasePutCommand class.
        /// </summary>
        public DatabasePutCommand(string family, string key, string value)
        {
            Family = family;
            Key = key;
            Value = value;
        }

        /// <summary>
        /// Compiles the command.
        /// </summary>
        public override string Compile()
        {
            return String.Format("DATABASE PUT {0} {1} {2}", EscapeAndQuote(Family), EscapeAndQuote(Key), EscapeAndQuote(Value));
        }
    }
}
