using System;

namespace Obelisk.Agi.Commands
{
    /// <summary>
    /// Represents a command for getting a database value.
    /// </summary>
    public class DatabaseGetCommand : ObeliskCommand
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
        /// Initialises a new instance of the DatabaseGetCommand class.
        /// </summary>
        public DatabaseGetCommand(string family, string key)
        {
            Family = family;
            Key = key;
        }

        /// <summary>
        /// Compiles the command.
        /// </summary>
        public override string Compile()
        {
            return String.Format("DATABASE GET {0} {1}", EscapeAndQuote(Family), EscapeAndQuote(Key));
        } 
    }
}
