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
       /// <summary>
       ///  Essa url leva a download da update esse link deve ser fixo para evitar dores de cabeça.
       /// </summary>
       public static string Downloadurl = "https://neonn.000webhostapp.com/Downloads/Update.zip";
       /// <summary>
       /// Essa url leva e aonde checa a versão no arquivo xml do servidor HTTP
       /// para mandar uma update basta trocar o numero no
       /// <Version></Version>
       /// </summary>
       public static string CheckxmlUrl = "https://neonn.000webhostapp.com/Downloads/version.xml";
       /// <summary>
       /// Pasta onde ficara o update ao lado do cliente, de preferencia a isso.
       /// </summary>
       public static string FileExistingZip = Settings.Default.GameLocation + "Update.zip";
       /// <summary>
       /// Pasta onde ficara o jogo
       /// </summary>
       public static string FolderGame = Settings.Default.GameLocation;
       /// <summary>
       /// Versão do launcher
       /// não altera para evitar dores de cabeça
       /// </summary>
       public static int LauncherVersion = Settings.Default.Version;
       /// <summary>
       /// Versão do arquivo xml no servidor
       /// </summary>
       public static  int WebVersionxml;
    }
}
