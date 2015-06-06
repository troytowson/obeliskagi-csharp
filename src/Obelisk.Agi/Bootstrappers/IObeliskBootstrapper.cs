namespace Obelisk.Agi.Bootstrappers
{
    /// <summary>
    /// Represents a contract for all bootstrappers.
    /// </summary>
    public interface IObeliskBootstrapper
    {
        /// <summary>
        /// Initialise the bootstrapper.
        /// </summary>
        void Initialise();

        /// <summary>
        /// Gets the script by the name.
        /// </summary>
        IObeliskScript GetScript(string scriptName);
    }
}
