using StructureMap;

namespace Obelisk.Agi.Bootstrappers.Structuremap
{
    /// <summary>
    /// Represents a bootstrapper that uses structure map.
    /// </summary>
    public class StructuremapBootstrapper : ObeliskBootstrapper<IContainer>
    {
        /// <summary>
        /// Gets a new container.
        /// </summary>
        protected override IContainer GetContainer()
        {
            return new Container();
        }

        /// <summary>
        /// Configures the container.
        /// </summary>
        protected override void Configure(IContainer container)
        {
        }

        /// <summary>
        /// Gets the container for the channel.
        /// </summary>
        protected override IContainer GetChannelContainer(IContainer container)
        {
            return container.GetNestedContainer();
        }

        /// <summary>
        /// Gets the specific script from the provided container.
        /// </summary>
        protected override IObeliskScript GetScript(IContainer container, string script)
        {
            return container.GetInstance<IObeliskScript>(script);
        }
    }
}
