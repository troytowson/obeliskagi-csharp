using System;

namespace Obelisk.Agi.Commands
{
    /// <summary>
    /// Represents a command for deleting an entry in the Asterisk database for a given family and key.
    /// </summary>
    public class DatabaseDeleteCommand: ObeliskCommand
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
        /// Initialises a new instance of the DatabaseDeleteCommand class.
        /// </summary>
        public DatabaseDeleteCommand(string family, string key)
        {
            Family = family;
            Key = key;
        }
        
        /// <summary>
        /// Compiles the command.
        /// </summary>
        public override string Compile()
        {
            return String.Format("DATABASE DEL {0} {1}", EscapeAndQuote(Family), EscapeAndQuote(Key));
        } 
    }
}
