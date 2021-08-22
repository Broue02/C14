using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RDP_Generator
{
    class DefaultConfig
    {
        //Dany.... Je suis désolé de cette atrocité...
        //Juste a ajouter des éléments si la config "Default" ne convient pas aux besoins
        public static string[] GetDefaultConfig()
        {
            string[] config = new string[47];
            config[0] = "screen mode id:i:2";
            config[1] = "use multimon:i:0";
            config[2] = "desktopwidth:i:1920";
            config[3] = "desktopheight:i:1080";
            config[4] = "session bpp:i:32";
            config[5] = "winposstr:s:0,3,0,0,800,600";
            config[6] = "compression:i:1";
            config[7] = "keyboardhook:i:2";
            config[8] = "audiocapturemode:i:0";
            config[9] = "videoplaybackmode:i:1";
            config[10] = "connection type:i:7";
            config[11] = "networkautodetect:i:1";
            config[12] = "bandwidthautodetect:i:1";
            config[13] = "displayconnectionbar:i:1";
            config[14] = "enableworkspacereconnect:i:0";
            config[15] = "disable wallpaper:i:0";
            config[16] = "allow font smoothing:i:0";
            config[17] = "allow desktop composition:i:0";
            config[18] = "disable full window drag:i:1";
            config[19] = "disable menu anims:i:1";
            config[20] = "disable themes:i:0";
            config[21] = "disable cursor setting:i:0";
            config[22] = "bitmapcachepersistenable:i:1";
            config[23] = "full address:s:";
            config[24] = "audiomode:i:0";
            config[25] = "redirectprinters:i:1";
            config[26] = "redirectcomports:i:0";
            config[27] = "redirectsmartcards:i:1";
            config[28] = "redirectclipboard:i:1";
            config[29] = "redirectposdevices:i:0";
            config[30] = "drivestoredirect:s:";
            config[31] = "autoreconnection enabled:i:1";
            config[32] = "authentication level:i:2";
            config[33] = "prompt for credentials:i:0";
            config[34] = "negotiate security layer:i:1";
            config[35] = "remoteapplicationmode:i:0";
            config[36] = "alternate shell:s:";
            config[37] = "shell working directory:s:";
            config[38] = "gatewayhostname:s:";
            config[39] = "gatewayusagemethod:i:2";
            config[40] = "gatewaycredentialssource:i:4";
            config[41] = "gatewayprofileusagemethod:i:0";
            config[42] = "promptcredentialonce:i:0";
            config[43] = "gatewaybrokeringtype:i:0";
            config[44] = "use redirection server name:i:0";
            config[45] = "rdgiskdcproxy:i:0";
            config[46] = "kdcproxyname:s:";

            return config;
        }
    }
}
