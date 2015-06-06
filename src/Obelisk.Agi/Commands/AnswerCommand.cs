namespace Obelisk.Agi.Commands
{
    /// <summary>
    /// Represents a command for answering.
    /// </summary>
    public sealed class AnswerCommand : ObeliskCommand
    {
        /// <summary>
        /// Compiles the command.
        /// </summary>
        public override string Compile()
        {
            return "ANSWER";
        } 
    }
}
