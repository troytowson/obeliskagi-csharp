using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using System.Threading.Tasks;
using Obelisk.Agi.Commands;

namespace Obelisk.Agi.Internals
{
    /// <summary>
    /// Represents an implementation of the obelisk channel interface.
    /// </summary>
    internal class ObeliskChannelInternal : IObeliskChannel
    {
        private bool _isDisposed;
        private readonly TcpClient _client;
        private readonly StreamReader _reader;
        private readonly StreamWriter _writer;

        /// <summary>
        /// Initialises a new instance of the ObeliskChannelInternal class.
        /// </summary>
        public ObeliskChannelInternal(TcpClient client)
        {
            _client = client;
            _writer = new StreamWriter(client.GetStream()) { AutoFlush = true };
            _reader = new StreamReader(client.GetStream());
            _isDisposed = false;
        }

        /// <summary>
        /// Gets the context.
        /// </summary>
        public IObeliskChannelContext Context
        {
            get; 
            private set;
        }

        /// <summary>
        /// Reads a request.
        /// </summary>
        public async Task GetContextAsync()
        {
            var lines = new List<string>();
            string line;

            while (!String.IsNullOrWhiteSpace((line = await _reader.ReadLineAsync())))
            {
                lines.Add(line);
            }

            Context = new ObeliskChannelContextInternal(lines);
        }

        /// <summary>
        /// Reads a reply.
        /// </summary>
        public async Task<ObeliskReply> ReadReplyAsync()
        {
            string line;
            try
            {
                line = await _reader.ReadLineAsync();
            }
            catch (Exception)
            {
                throw new Exception("Unable to read from the stream.");
            }

            if (String.IsNullOrWhiteSpace(line))
                throw new Exception("unable to read from the stream.");

            return new ObeliskReply(line);
        }

        /// <summary>
        /// Sends the command.
        /// </summary>
        public async Task<ObeliskReply> SendCommandAsync(ObeliskCommand command)
        {
            await _writer.WriteAsync(command.Compile());
            return await ReadReplyAsync();
        }

        /// <summary>
        /// Disposes the channel.
        /// </summary>
        public void Dispose()
        {
            if (_isDisposed) 
                return;

            _isDisposed = true;
            _client.Close();
            _reader.Close();
            _writer.Close();
        }
    }
}