﻿namespace KoenZomers.Ring.SnapshotDownload
{
    /// <summary>
    /// Configuration to use for downloading the Ring Snapshot
    /// </summary>
    public class Configuration
    {
        /// <summary>
        /// Path where to download the snapshot to
        /// </summary>
        public string OutputPath;

        /// <summary>
        /// Username to use to connect to Ring
        /// </summary>
        public string Username;

        /// <summary>
        /// Password to use to connect to Ring
        /// </summary>
        public string Password;

        /// <summary>
        /// Type ID of the Ring device to download the snapshot from
        /// </summary>
        public int? DeviceId;

        /// <summary>
        /// Boolean indicating if a listing of available bots should be returned
        /// </summary>
        public bool ListBots = false;
    }
}
