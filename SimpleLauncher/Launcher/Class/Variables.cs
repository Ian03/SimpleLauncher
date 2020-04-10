using SimpleLauncher.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLauncher
{
    class ClsVariables
    {
        public static string Checknews = "https://simpleslauncher.000webhostapp.com/Updatesfiles/path.txt";
        /// <summary>
        ///  This url leads to download the update.This link must be fixed to avoid headaches.
        /// </summary>
        public static string Downloadurl = "https://simpleslauncher.000webhostapp.com/Updatesfiles/Update.zip";
        /// <summary>
        /// This url takes and where to check the version in the HTTP server's xml file
        /// to send an update just change the number in the
       /// <Version></Version>
       /// </summary>
       public static string CheckxmlUrl = "https://simpleslauncher.000webhostapp.com/Updatesfiles/version.xml";
        /// <summary>
        /// This url takes and where to check the version in the HTTP server's xml file
        /// to activate maintenance just put value 1 on the server
        /// <Version></Version>
        /// </summary>
        public static string CheckxmlMaintenance = "https://simpleslauncher.000webhostapp.com/Updatesfiles/Version.xml";
        /// <summary>
        ///Folder where the update is located next to the client, preferably to that.
        /// </summary>
        public static string FileExistingZip = Settings.Default.GameLocation + "Update.zip";
        /// <summary>
        /// Folder where the game will be
       /// </summary>
       public static string FolderGame = Settings.Default.GameLocation;
        /// <summary>
        /// Launcher version
        /// does not change to avoid headaches
       /// </summary>
       public static int LauncherVersion = Settings.Default.Version;
        /// <summary>
        /// Enable Maintence
        /// </summary>
        public static int LauncherMaintenance = Settings.Default.Maintenance;
        /// <summary>
        /// Version of the xml file on the server
        /// </summary>
        public static  int WebVersionxml;
        /// <summary>
        /// Link of the website to which you will be redirected
        /// <Version></Version>
        /// </summary>
        ///                                        https://Linkhere
        public static string MaintenanceWebsite = "https://simpleslauncher.000webhostapp.com/";
    }
}
