using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RDP_Generator
{
    public partial class frmConfig : Form
    {
        string dossier = "";
        string fichierRDPdefault = Environment.CurrentDirectory;
        ArrayList splitSettings = new ArrayList();
        public frmConfig()
        {
            InitializeComponent();
            cmdVider.FlatAppearance.BorderSize = 0;
        }

        /// <summary>
        /// Événement Load. Regarde si le fichier temporaire existe. Charge ses infos si c'est le cas, sinon charge les infos par défaut.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmConfig_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            splitSettings.Clear();

            string fichier = fichierRDPdefault + "\\configTemp.rdp";
            if (File.Exists(fichier))
            {
                Charger_Template(fichier);
            }
            else
            {
                cmdDefaut.PerformClick();
            }
        }

        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        /// <summary>
        /// Mouse Down du header. Initie le déplacement du formulaire
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pnlHeader_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        /// <summary>
        /// Mouse Move du header. Effectue les calculs et le déplacement du formulaire.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pnlHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        /// <summary>
        /// Mouse Up du header. Lève le flag de déplacement.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pnlHeader_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        /// <summary>
        /// Bouton Quitter. Ferme le formulaire sans sauvegarder
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Bouton Minimiser. Minimise le programme
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdMinimiser_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        /// <summary>
        /// Procédure vidant complètement les contrôles du formulaire de configuration.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdVider_Click(object sender, EventArgs e)
        {
            lvConfigs.Items.Clear();

            if(splitSettings is null)
                splitSettings = new ArrayList();

            splitSettings.Clear();
            txtConfig.Clear();
            txtDomaine.Clear();

            //cmdAjouter.Enabled = false;
            cmdModifier.Enabled = false;
            cmdOk.Enabled = false;
            cmdEnregistrer.Enabled = false;
            cmdSupprimer.Enabled = false;
        }

        /// <summary>
        /// Bouton Ajoute. Ouvre un formulaire AjoutModifConfig pour ajouter une configuration tout en avertissant l'utilisateur.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdAjouter_Click(object sender, EventArgs e)
        {
            DialogResult choice = MessageBox.Show("Assurez-vous d'entrer des configurations existantes lors de l'ajout d'une ligne de configuration", "Attention!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            
            if (choice == DialogResult.Yes)
            {
                frmAjoutModifConfig form = new frmAjoutModifConfig("Ajout", 0 ,"null", splitSettings);
                form.ShowDialog();
            }
            
        }

        /// <summary>
        /// Bouton Parcourir pour gabarit de configuration. Ouvre un OpenFileDialog pour avoir le chemin du fichier.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdParcourir_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "rdp files (*.rdp)|*.rdp|All files (*.*)|*.*";

                DialogResult result = ofd.ShowDialog();

                if (result == DialogResult.OK)
                {
                    splitSettings.Clear();

                    dossier = ofd.FileName;

                    string[] dossierSplit = dossier.Split('\\');
                    txtConfig.Text = dossierSplit[dossierSplit.Length - 1];

                    splitSettings = GetConfig.GetConfigArray(dossier);
                    Remplir_ListView();

                    cmdAjouter.Enabled = true;
                    cmdModifier.Enabled = true;
                    cmdDefaut.Enabled = true;
                    cmdEnregistrer.Enabled = true;
                    cmdOk.Enabled = true;
                }
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Procédure mettant à jour le ListView de configurations
        /// </summary>
        /// <param name="element">Informations de config</param>
        /// <param name="index">Index de la config à changer</param>
        public void UpdateElement(Settings element, int index)
        {
            ListViewItem ligne = new ListViewItem(element.settingName);
            ligne.SubItems.Add(element.settingType);
            ligne.SubItems.Add(element.settingValue);

            ligne.Tag = element.settingName;


            foreach (Settings setting in splitSettings)
            {
                if (setting.settingName == lvConfigs.Items[index].Text)
                {
                    setting.settingName = element.settingName;
                    setting.settingType = element.settingType;
                    setting.settingValue = element.settingValue;
                }
            }

            Remplir_ListView();
        }

        /// <summary>
        /// Procédure ajoutant un élément au ListView de configuration.
        /// </summary>
        /// <param name="element"></param>
        /// <param name="tag"></param>
        public void AddElement(Settings element, string tag)
        {
            ListViewItem ligne = new ListViewItem(element.settingName);

            ligne.SubItems.Add(element.settingType);
            ligne.SubItems.Add(element.settingValue);
            ligne.Tag = tag;

            lvConfigs.Items.Add(ligne);

            splitSettings.Add(element);
            Remplir_ListView();
        }

        /// <summary>
        /// Procédure remplissant le ListView de configuration avec les informations de 'splitSettings'.
        /// </summary>
        private void Remplir_ListView()
        {
            try
            {
                lvConfigs.Items.Clear();

                ListViewItem ligne = new ListViewItem();

                if (splitSettings is null)
                    throw new Exception("Configuration vide. Fichier RDP potentiellement non-valide.");

                foreach (Settings config in splitSettings)
                {
                    ligne = new ListViewItem(config.settingName);

                    if (config.settingName == "domaine")
                    {
                        txtDomaine.Clear();
                        txtDomaine.Text = config.settingValue;
                        continue;
                    }

                    if (config.settingType == "i")
                    {
                        ligne.SubItems.Add("Integer");
                    }
                    else
                        ligne.SubItems.Add("String");

                    ligne.SubItems.Add(config.settingValue);
                    ligne.Tag = config.settingName;

                    lvConfigs.Items.Add(ligne);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmdVider.PerformClick();
            }
        }

        /// <summary>
        /// Bouton Modifier. Ouvre une instance de AjoutModifConfig pour modifier une ligne de configuration
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdModifier_Click(object sender, EventArgs e)
        {
            if (lvConfigs.Items.Count != 0 && lvConfigs.SelectedItems.Count != 0)
            {
                frmAjoutModifConfig frm = new frmAjoutModifConfig("Modif", lvConfigs.SelectedItems[0].Index, lvConfigs.SelectedItems[0].Tag.ToString(), splitSettings);

                frm.ShowDialog();
            }
        }

        /// <summary>
        /// Bouton supprimer. Supprimer une ligne de configuration du ListView.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdSupprimer_Click(object sender, EventArgs e)
        {
            if (lvConfigs.Items.Count != 0 && lvConfigs.SelectedItems.Count != 0)
            {
                ListViewItem ligne = lvConfigs.SelectedItems[0];

                Settings domaine = (Settings)splitSettings[0];

                if (domaine.settingName == "domaine")
                    splitSettings.RemoveAt(ligne.Index + 1);
                else
                    splitSettings.RemoveAt(ligne.Index);

                lvConfigs.Items[lvConfigs.SelectedItems[0].Index].Remove();

                Remplir_ListView();

                if (lvConfigs.Items.Count != 0)
                    lvConfigs.Items[0].Selected = true;
            }
        }

        /// <summary>
        /// Bouton Enregistrer. Enregistre le gabarit de configuration pour usage ultérieur.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdEnregistrer_Click(object sender, EventArgs e)
        {
            if (splitSettings.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.FileName = dossier;
                sfd.Filter = "rdp files (*.rdp)|*.rdp";
                sfd.DefaultExt = "rdp";
                sfd.Title = "Sauvegardez votre fichier RDP:";

                string saveSetting = "";
                string domaine = "";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (txtDomaine.Text.Trim() != "")
                    {
                        domaine = "domaine:s:" + txtDomaine.Text.Trim() + "\n";
                        saveSetting = domaine;
                    }

                    if (File.Exists(sfd.FileName))
                        File.Delete(sfd.FileName);

                    Stream s = File.Open(sfd.FileName, FileMode.CreateNew);
                    StreamWriter sw = new StreamWriter(s);

                    foreach (Settings setting in splitSettings)
                    {
                        if (setting.settingName != "domaine")
                            saveSetting += setting.settingName + ":" + setting.settingType + ":" + setting.settingValue + "\n";
                    }

                    sw.Write(saveSetting);

                    sw.Close();
                    s.Close();

                    MessageBox.Show("Fichier de configuration enregistré à l'emplacement spécifié!", "Enregistrement...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        /// <summary>
        /// Bouton OK. Enregistre la configuration actuelle comme fichier temporaire pour aider à la manipulation dans frmMain.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdOk_Click(object sender, EventArgs e)
        {
            string fichier = fichierRDPdefault + "\\configTemp.rdp";
            if (File.Exists(fichier))
            {
                File.Delete(fichier);
            }

            Stream s = File.Open(fichier, FileMode.CreateNew);
            StreamWriter sw = new StreamWriter(s);
            string saveSetting = "";
            string domaine = "";

            if (txtDomaine.Text.Trim() != "")
            {
                domaine = "domaine:s:" + txtDomaine.Text.Trim() + "\n";
                saveSetting = domaine;
            }

            foreach(Settings setting in splitSettings)
            {
                if (setting.settingName != "domaine")
                    saveSetting += setting.settingName + ":" + setting.settingType + ":" + setting.settingValue + "\n";
            }

            sw.Write(saveSetting);

            sw.Close();
            s.Close();

            MessageBox.Show("Fichier de configuration temporaire enregistré!", "Enregistrement...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        /// <summary>
        /// Procédure chargeant les informations du gabarit de configurations et les affichant dans le ListView
        /// </summary>
        /// <param name="fichier"></param>
        private void Charger_Template(string fichier)
        {
            txtConfig.Text = "configTemp.rdp";
            dossier = fichierRDPdefault + "\\configTemp.rdp";
            FileStream fs = new FileStream(fichier, FileMode.Open, FileAccess.Read, FileShare.None);
            StreamReader sr = new StreamReader(fs);

            string contenu;
            string[] rawSettings;
            string[] splitChars = { "\r\n", "\n" };

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

            ListViewItem ligne = new ListViewItem();

            foreach (Settings setting in splitSettings)
            {
                if (setting.settingName == "domaine")
                {
                    string value = setting.settingValue;
                    txtDomaine.Text = value;
                    continue;
                }

                ligne = new ListViewItem(setting.settingName);
                ligne.SubItems.Add(setting.settingType);
                ligne.SubItems.Add(setting.settingValue);
                ligne.Tag = setting.settingName;

                lvConfigs.Items.Add(ligne);
            }

            cmdAjouter.Enabled = true;
            cmdModifier.Enabled = true;
            cmdEnregistrer.Enabled = true;
            cmdOk.Enabled = true;
            cmdSupprimer.Enabled = true;

            lvConfigs.Items[0].Selected = true;
        }

        /// <summary>
        /// Bouton Defaut. Charge la configuration par défaut du programme
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdDefaut_Click(object sender, EventArgs e)
        {
            try
            {
                txtConfig.Text = "Default";

                splitSettings.Clear();

                string[] dc = DefaultConfig.GetDefaultConfig();
                ListViewItem ligne = new ListViewItem();
                
                lvConfigs.Items.Clear();

                foreach(string element in dc)
                {
                    string[] setting = new string[3];

                    setting = element.Split(':');

                    ligne = new ListViewItem(setting[0]);
                    ligne.SubItems.Add(setting[1]);
                    ligne.SubItems.Add(setting[2]);
                    ligne.Tag = setting[0];

                    Settings settingObj = new Settings(setting[0], setting[1], setting[2]);
                    splitSettings.Add(settingObj);

                    lvConfigs.Items.Add(ligne);
                }

                cmdEnregistrer.Enabled = true;
                cmdOk.Enabled = true;
                cmdAjouter.Enabled = true;
                cmdModifier.Enabled = true;
                cmdSupprimer.Enabled = true;

                lvConfigs.Items[0].Selected = true;
            }
            catch(Exception)
            {
                MessageBox.Show("Erreur survenue lors du chargement de configuration par défaut.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
        }
    }

