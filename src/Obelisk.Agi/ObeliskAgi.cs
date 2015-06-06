using System;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;
using Obelisk.Agi.Internals;

namespace Obelisk.Agi
{
    /// <summary>
    /// Represents the entry point for the Asterisk Gateway Interface.
    /// </summary>
    public class ObeliskAgi
    {
        private readonly object _isRunningLockObj = new object();

        private bool _isRunning;
        private TcpListener _socket;

        /// <summary>
        /// Gets the IP end point.
        /// </summary>
        public IPEndPoint EndPoint
        {
            get
            {
                return new IPEndPoint(Configuration.Address, Configuration.Port);
            }
        }

        /// <summary>
        /// Gets the configuration used.
        /// </summary>
        public ObeliskConfiguration Configuration
        {
            get;
            private set;
        }

        /// <summary>
        /// Initialises a new instance of the Obelisk class.
        /// </summary>
        private ObeliskAgi(ObeliskConfiguration configuration)
        {
            Configuration = configuration;
        }

        /// <summary>
        /// Starts Obelisk.
        /// </summary>
        public void Start()
        {
            if (IsRunning())
                throw new Exception("Unable to start as Obelisk has already been started.");

            _socket = new TcpListener(EndPoint);

            Task.Factory.StartNew(async () =>
            {
                SetRunning(true);
                _socket.Start();

                while (IsRunning())
                {
                    TcpClient tcpClient;

                    if ((tcpClient = await _socket.AcceptTcpClientAsync()) == null)
                        continue;

                    ObeliskConnectionInternal.OpenChannel(tcpClient, Configuration.Bootstrapper);
                }
            });
        }

        /// <summary>
        /// Indicates that the service is running.
        /// </summary>
        public bool IsRunning()
        {
            lock (_isRunningLockObj)
                return _isRunning;
        }

        /// <summary>
        /// Sets the running flag in a lock.
        /// </summary>
        private void SetRunning(bool value)
        {
            lock (_isRunningLockObj)
                _isRunning = value;
        }

        /// <summary>
        /// Stops Obelisk.
        /// </summary>
        public void Stop()
        {
            SetRunning(false);
            _socket.Stop();
        }

        /// <summary>
        /// Creates a obelisk from a specific configurations.
        /// </summary>
        public static ObeliskAgi Create(ObeliskConfiguration configuration)
        {
            if (configuration.Bootstrapper == null)
                throw new Exception("No bootstrapper has been assigned to the configuration.");

            return new ObeliskAgi(configuration);
        }
    }
}
