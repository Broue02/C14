using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RDP_Generator
{
    public class GetConfig
    {
        /// <summary>
        /// Méthode lisant le fichier de configuration enregistré pour s'en servir comme template
        /// </summary>
        /// <param name="dossier">Chemin d'accès au fichier</param>
        /// <returns>Liste de configurations</returns>
        public static ArrayList GetConfigArray(string dossier)
        {
            try
            {
                ArrayList splitSettings = new ArrayList();

                FileStream fs = new FileStream(dossier, FileMode.Open, FileAccess.Read, FileShare.None);
                StreamReader sr = new StreamReader(fs);

                string contenu;
                string[] rawSettings;
                string[] splitChars = { "\r\n", "\n"};

                contenu = sr.ReadToEnd();

                sr.Close();
                fs.Close();

                rawSettings = contenu.Split(splitChars, StringSplitOptions.RemoveEmptyEntries);

                foreach (string line in rawSettings)
                {
                    string[] ligneSetting = new string[3];

                    ligneSetting = line.Split(':');

                    if (ligneSetting[2] == "")
                    {
                        ligneSetting[2] = " ";
                    }

                    Settings setting = new Settings(ligneSetting[0], ligneSetting[1], ligneSetting[2]);
                    splitSettings.Add(setting);
                }

                return splitSettings;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }

        }
    }
}
