using System.Net;

namespace Obelisk.Agi
{
    public static class Common
    {
        /// <summary> 
        /// The default AGI bind address. 
        /// </summary>
        public static readonly IPAddress BIND_ADDRESS = IPAddress.Any;

        /// <summary>
        /// The detault port number.
        /// </summary>
        public static readonly int BIND_PORT = 4573;
        
        /// <summary>
        /// The default AGI thread pool size. 
        /// </summary>
        public static readonly int POOL_SIZE = 10;
    }
}