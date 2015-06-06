using System;
using System.Text;

namespace Obelisk.Agi.Commands
{
    /// <summary>
    /// Represents the base for all commands
    /// </summary>
    public abstract class ObeliskCommand
    {
        /// <summary>
        /// Initialises a new instance of the ObeliskCommand class.
        /// </summary>
        internal ObeliskCommand()
        {
        }

        /// <summary>
        /// Compiles command.
        /// </summary>
        /// <returns></returns>
        public abstract string Compile();

        /// <summary>
        /// Escapes and quotes a string.
        /// </summary>
        protected string EscapeAndQuote(string input)
        {
            if (String.IsNullOrWhiteSpace(input))
                input = String.Empty;
                
            return String.Format("\"{0}\"", input.Replace("\\\\", "\\\\\\\\").Replace("\\\"", "\\\\\"").Replace("\\\n", ""));
        }

        /// <summary>
        /// Escapes and quotes an array of strings.
        /// </summary>
        protected string EscapeAndQuote(string[] options)
        {
            if (options == null)
                return EscapeAndQuote(String.Empty);

            var sb = new StringBuilder();
            
            foreach (var option in options)
            {
                sb.AppendFormat("{0}{1}", sb.Length == 0 ? "" : ",", option);
            }
            
            return EscapeAndQuote(sb.ToString());
        }
    }
}
