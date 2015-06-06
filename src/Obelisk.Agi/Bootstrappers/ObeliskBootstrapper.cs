namespace Obelisk.Agi.Bootstrappers
{
    /// <summary>
    /// Represents a base bootstrapper.
    /// </summary>
    public abstract class ObeliskBootstrapper<TContainer> : IObeliskBootstrapper 
        where TContainer : class  
    {
        /// <summary>
        /// Gets the container.
        /// </summary>
        protected TContainer Container
        {
            get; 
            private set;
        }
        
        /// <summary>
        /// Initialises a the bootstrapper.
        /// </summary>
        public void Initialise()
        {
            Container = GetContainer();
            Configure(Container);
        }

        /// <summary>
        /// Gets the script by the name.
        /// </summary>
        public IObeliskScript GetScript(string scriptName)
        {
            var container = GetChannelContainer(Container);
            return GetScript(container, scriptName);
        }

        /// <summary>
        /// Gets the container for the channel.
        /// </summary>
        protected abstract TContainer GetChannelContainer(TContainer container);

        /// <summary>
        /// Gets the script from the specific container with the name.
        /// </summary>
        protected abstract IObeliskScript GetScript(TContainer container, string script);

        /// <summary>
        /// Gets the container.
        /// </summary>
        protected abstract TContainer GetContainer();

        /// <summary>
        /// Configures the bootstrapper.
        /// </summary>
        protected abstract void Configure(TContainer container);
    }
}
