using System.Threading.Tasks;

namespace Obelisk.Agi
{
    /// <summary>
    /// Represents a contract for all Fast Agi scripts.
    /// </summary>
    public interface IObeliskScript
    {
        /// <summary>
        /// Runs the script on the specific channel.
        /// </summary>
        Task RunAsync(IObeliskChannel channel);
    }
}
