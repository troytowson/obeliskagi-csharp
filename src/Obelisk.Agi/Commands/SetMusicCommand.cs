using System;

namespace Obelisk.Agi.Commands
{
    /// <summary>
    /// Represents the status of the music.
    /// </summary>
    public enum MusicStatus
    {
        On,
        Off,
    }

    /// <summary>
    /// Represents a command for setting the hold music status.
    /// </summary>
    public class SetMusicCommand : ObeliskCommand
    {
        /// <summary>
        /// Gets or sets the status of the music.
        /// </summary>
        public MusicStatus Status
        {
            get;
            set;
        }

        /// <summary>
        /// Initialises a new instance of the SetMusicCommand class.
        /// </summary>
        public SetMusicCommand(MusicStatus status)
        {
            Status = status;
        } 
        
        /// <summary>
        /// Compiles the command.
        /// </summary>
        public override string Compile()
        {
            return String.Format("SET MUSIC {0}", Status.ToString().ToUpper());
        } 
    }
}
