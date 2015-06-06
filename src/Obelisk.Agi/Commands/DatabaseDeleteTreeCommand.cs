using System;

namespace Obelisk.Agi.Commands
{
    /// <summary>
    /// Represnts a command to delete a family or specific keytree within a family in the Asterisk database.
    /// </summary>
    public class DatabaseDeleteTreeCommand : ObeliskCommand
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
        /// Gets or sets the keytree.
        /// </summary>
        public string Keytree
        {
            get;
            set;
        }

        /// <summary>
        /// Initialises a new instance of the DatabaseDeleteTreeCommand class.
        /// </summary>
        public DatabaseDeleteTreeCommand(string family, string keytree)
        {
            Family = family;
            Keytree = keytree;
        }

        /// <summary>
        /// Compiles a command.
        /// </summary>
        public override string Compile()
        {
            return String.Format("DATABASE DELTREE {0} {1}", EscapeAndQuote(Family), EscapeAndQuote(Keytree));
        } 
    }
}
