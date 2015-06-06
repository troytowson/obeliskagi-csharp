using System;
using System.Net.Sockets;
using System.Threading.Tasks;
using Obelisk.Agi.Bootstrappers;

namespace Obelisk.Agi.Internals
{
    /// <summary>
    /// Represents a connection to a client.
    /// </summary>
    internal class ObeliskConnectionInternal
    {
        /// <summary>
        /// Gets the tcp client used for the channel.
        /// </summary>
        public TcpClient Client
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the Bootstrapper used in the configuration.
        /// </summary>
        public IObeliskBootstrapper Bootstrapper
        {
            get;
            private set;
        }

        /// <summary>
        /// Initialises a new instance of the ObeliskClient class.
        /// </summary>
        public ObeliskConnectionInternal(TcpClient client, IObeliskBootstrapper bootstrapper)
        {
            Client = client;
            Bootstrapper = bootstrapper;
        }

        /// <summary>
        /// Starts the communications.
        /// </summary>
        public static void OpenChannel(TcpClient client, IObeliskBootstrapper bootstrapper)
        {
            Task.Factory.StartNew(async obj =>
            {
                var connection = obj as ObeliskConnectionInternal;
                if (connection == null)
                    return;

                try
                {
                    using (var channel = new ObeliskChannelInternal(connection.Client))
                    {
                        await channel.GetContextAsync();
                        
                        var script = connection.Bootstrapper.GetScript(channel.Context.Script);
                        await script.RunAsync(channel);

                        var reply = await channel.ReadReplyAsync();
                        if (reply.Line.StartsWith("HANGUP"))
                            channel.Dispose();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("", ex);
                }
            }, new ObeliskConnectionInternal(client, bootstrapper));
        }
    }
}