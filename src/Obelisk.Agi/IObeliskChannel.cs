using System;
using System.Threading.Tasks;
using Obelisk.Agi.Commands;

namespace Obelisk.Agi
{
    public interface IObeliskChannel : IDisposable
    {
        /// <summary>
        /// Gets the context of the channel.
        /// </summary>
        IObeliskChannelContext Context { get; }

        /// <summary>
        /// Reads a reply.
        /// </summary>
        Task<ObeliskReply> ReadReplyAsync();

        /// <summary>
        /// Sends a command.
        /// </summary>
        Task<ObeliskReply> SendCommandAsync(ObeliskCommand command);
    }
}