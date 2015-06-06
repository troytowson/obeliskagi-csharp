using System;
using System.Net;
using Obelisk.Agi.Bootstrappers;

namespace Obelisk.Agi
{
    /// <summary>
    /// Represents the configuration for Obelisk.
    /// </summary>
    public class ObeliskConfiguration
    {
        /// <summary>
        /// Gets the port number.
        /// </summary>
        public int Port
        {
            get; 
            private set;
        }

        /// <summary>
        /// Gets the IP address
        /// </summary>
        public IPAddress Address
        {
            get; 
            private set;
        }

        /// <summary>
        /// Gets the boostrapper.
        /// </summary>
        public IObeliskBootstrapper Bootstrapper
        {
            get; 
            private set;
        }

        /// <summary>
        /// Initialises a new instance of the Obelisk class.
        /// </summary>
        public ObeliskConfiguration(IPAddress address, int port)
        {
            Address = address;
            Port = port;
        }

        /// <summary>
        /// Initialises a new instance of the Obelisk class.
        /// </summary>
        public ObeliskConfiguration(string address, int port)
            : this(IPAddress.Parse(address), port)
        {
        }

        /// <summary>
        /// Initialises a new instance of the Obelisk class.
        /// </summary>
        public ObeliskConfiguration()
            : this(Common.BIND_ADDRESS, Common.BIND_PORT)
        {
        }

        /// <summary>
        /// Uses the boostrapper within Obelisk.
        /// </summary>
        public void UseBootstrapper<T>() where T : IObeliskBootstrapper
        {
            Bootstrapper = Activator.CreateInstance<T>();
            Bootstrapper.Initialise();
        } 
    }
}
