using System;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Windows.Forms;

namespace ListIp
{
    public partial class ListIp : Form
    {
        // Software information
        private readonly string _softDevName;
        private readonly string _softVersion;
        private readonly string _softName;
        private readonly string _softDate;

        // IP information
        private string _ipBase;
        private int _ipMin;
        private int _ipMax = 255;
        private int _numberOfIp;

        // Files information
        private string _fileName;
        private string _path;
        private string _fullPath;

        public ListIp()
        {
            // Initialise les infos du logiciel
            _softDevName = Application.CompanyName;
            _softName = Application.ProductName;
            _softVersion = Application.ProductVersion;
            _softDate = AssemblyDate().ToString();

            // Fonction Visual Studio C#
            InitializeComponent();
        }

        /// <summary>
        /// Format the date of assembly.
        /// </summary>
        /// <returns>Date assembly</returns>
        private DateTime AssemblyDate()
        {
            // Assumes that in AssemblyInfo.cs,
            // the version is specified as 0.0.* or the like,
            // with only 2 numbers specified;
            // the next two are generated from the date.
            // This routine decodes them.
            var assemblySoft = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;

            // v.Build is days since Jan. 1, 2000
            // v.Revision*2 is seconds since local midnight
            // (NEVER daylight saving time)
            return new DateTime(assemblySoft.Major, 01, 01, 01, 01, 01);
        }


        /// <summary>
        /// Formate date in function of a pattern.
        /// </summary>
        /// <param name="dateTime">Date to format</param>
        /// <param name="pattern"></param>
        /// <returns>Formatted date</returns>
        private static string FormatDate(DateTime dateTime, int pattern)
        {
            switch (pattern)
            {
                case 0:
                    return string.Format("{0:yyyyMMddHHmm}", dateTime);

                case 1:
                    return string.Format("{0:yyyyMMddHHmmss}", dateTime);

                default:
                    return dateTime.ToString();
            }
        }

        /// <summary>
        /// Check if IP range is good.
        /// </summary>
        /// <returns>Check is OK</returns>
        private bool IsIPRangeOK()
        {
            var baseOK = false;
            var minOK = false;
            var maxOK = false;
            var nbIpOK = false;

            // Teste si les champs sont remplis et converti en int
            if (!string.IsNullOrEmpty(tb_IPBase.Text))
            {
                _ipBase = tb_IPBase.Text;
                baseOK = true;
            }

            string s_error;
            if (!string.IsNullOrEmpty(tb_IPmin.Text))
            {
                // Teste si le champ IP min est un int
                try
                {
                    _ipMin = Convert.ToInt32(tb_IPmin.Text);
                    minOK = true;
                }
                // Affiche une erreur sinon
                catch (Exception ex)
                {
                    s_error = $"{Environment.NewLine}Valeur d'IP min incorrecte.";
                    MessageBox.Show($"{ex.Message}{s_error}");
                    tb_IPmin.Focus();
                    minOK = false;
                }
            }

            if (!string.IsNullOrEmpty(tb_NbIP.Text))
            {
                // Teste si le champ nombre d'IP est un int
                try
                {
                    _numberOfIp = Convert.ToInt32(tb_NbIP.Text);
                    nbIpOK = true;
                }
                // Affiche une erreur sinon
                catch (Exception ex)
                {
                    s_error = $"{Environment.NewLine}Valeur de nombre d'IP incorrecte.";
                    MessageBox.Show($"{ex.Message}{s_error}");
                    tb_NbIP.Focus();
                    nbIpOK = false;
                }

                // Si pas de nombre d'IP précisé
                if (_numberOfIp == 0)
                {
                    if (!string.IsNullOrEmpty(tb_IPmax.Text))
                    {
                        // Teste si le champ IP max est un int
                        try
                        {
                            _ipMax = Convert.ToInt32(tb_IPmax.Text);
                            maxOK = true;
                        }
                        // Affiche une erreur sinon
                        catch (Exception ex)
                        {
                            s_error = $"{Environment.NewLine}Valeur d'IP max incorrecte.";
                            MessageBox.Show($"{ex.Message}{s_error}");
                            tb_IPmax.Focus();
                            maxOK = false;
                        }
                    }
                }
                // Si nombre d'IP précisé, ajout nombre d'IP au min
                else
                {
                    _ipMax = _ipMin + _numberOfIp - 1;
                    maxOK = true;
                }
            }

            // Initialise les bool
            // Teste si tous les champs sont OK
            return baseOK && minOK && maxOK && nbIpOK;
        }

        /// <summary>
        /// Checke if file name is good.
        /// </summary>
        /// <returns>File name is good</returns>
        private bool IsFileNameOK()
        {
            // TODO fileName
            var fileName = $"ListIP-log-{_ipBase}.x-{FormatDate(DateTime.Now, 0)}.txt";
            var pathToDesktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            _fileName = fileName;
            _path = pathToDesktop;
            _fullPath = Path.Combine(_path, _fileName);
            bool b_fileNameOK = true;

            return b_fileNameOK;
        }

        /// <summary>
        /// Make the average of a certain quantity of ping request.
        /// </summary>
        /// <param name="host">Host</param>
        /// <param name="nbOfTry">Numer of try</param>
        /// <param name="timeOut">Time out</param>
        /// <returns>Average time</returns>
        private double PingTimeAverage(string host, int nbOfTry, int timeOut)
        {
            // Initialise les paramètres de connexion
            var pingSender = new Ping();
            var totalTime = 0.0;

            // Boucle le nombre de fois à tester le ping
            for (var i = 0; i < nbOfTry; i++)
            {
                // Envoie le ping
                var pingReply = pingSender.Send(host, timeOut);
                // Si réponse
                if (pingReply.Status == IPStatus.Success)
                {
                    // Additionne les temps de réponse
                    totalTime += pingReply.RoundtripTime;
                }
            }

            // Moyenne des temps de réponse
            return totalTime / nbOfTry;
        }

        /// <summary>
        /// Write tab of string in a file.
        /// </summary>
        /// <param name="linezToPrint">Tab to write</param>
        /// <param name="path">Path of the file</param>
        /// <returns>Print file is OK</returns>
        private bool PrintToFile(string[] linezToPrint, string path, int numberOfIp)
        {
            var isPrintOK = false;

            try
            {
                // Utilise la librairie de fichier
                using (StreamWriter sw_file = new StreamWriter(path))
                {
                    // Parcours chaque ligne du tableau
                    foreach (var s_line in linezToPrint)
                    {
                        // Ecrit chaque ligne dans le fichier
                        sw_file.WriteLine(s_line);
                    }
                    isPrintOK = true;
                }
            }
            // Si une exception est levée
            catch (Exception ex)
            {
                var lineToDisplay = string.Empty;

                // Si pas trop d'IP à afficher dans la MessageBox
                if (numberOfIp <= 10)
                {
                    foreach (string s_line in linezToPrint)
                    {
                        lineToDisplay += $"{Environment.NewLine}{s_line}";
                    }
                }

                MessageBox.Show($"{ex.Message}{lineToDisplay}");
                isPrintOK = false;
            }

            return isPrintOK;
        }



        //////////////////
        // INTERACTIONS //
        //////////////////

        /// <summary>
        /// Start the listing.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnButtonStartListingClick(object sender, EventArgs e)
        {
            // Si les TextBox sont bien remplies
            if (IsIPRangeOK() && IsFileNameOK())
            {
                // Message d'information tant qu'il n'y a pas d'asynchrone
                MessageBox.Show("Test en cours. " +
                    "Le programme sera indisponible le temps du traitement. " + 
                    "Pour un grand nombre d'IP, le temps sera long " +
                    "(environ 10 sec par IP, soit environ 45 min pour les 256 IP).");

                var nbOfLines = _ipMax - _ipMin + 1;
                var content = new string[nbOfLines];

                // Pour chaque IP
                for (var i = _ipMin; i <= _ipMax; i++)
                {
                    // Création de l'IP
                    var ip = $"{_ipBase}.{i}";

                    // Décalage pour que le tableau commence à 0
                    var j = i - _ipMin;

                    // Création de la date
                    var datetimeNow = DateTime.Now;

                    content[j] = $"Date : {datetimeNow}\t\t";

                    try
                    {
                        // Récupère le nom et le temps de ping
                        var ipName = Dns.GetHostEntry(ip).HostName;
                        content[j] += $"IP :\t\t{ip}\t\tHostName :\t{ipName}\t\tPing : moyenne de ping = {PingTimeAverage(ip, 5, 1000)} ms";
                    }
                    catch (SocketException socketException)
                    {
                        //MessageBox.Show(exSocket.Message);
                        content[j] += $"Test :\t{ip}\t\tErreur :\t{socketException.Message}";
                    }
                    catch (Exception exception)
                    {
                        //MessageBox.Show(ex.Message);
                        content[j] += $"Test :\t{ip}\t\tErreur :\t{exception.Message}";
                    }

                    Console.WriteLine(content[j]);
                }

                // Enregistre les résultats dans un fichier
                if (PrintToFile(content, _fullPath, _numberOfIp))
                {
                    MessageBox.Show($"Test fini. Résultats visibles dans le fichier :{Environment.NewLine}{_fullPath}");
                }
            }
        }

        /// <summary>
        /// Perform the click of start listing when the ENTER key is pressed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnTextBoxIpBaseKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_startListing.PerformClick();
            }
        }

        /// <summary>
        /// Perform the click of start listing when the ENTER key is pressed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnTextBoxIpMinKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_startListing.PerformClick();
            }
        }

        /// <summary>
        /// Perform the click of start listing when the ENTER key is pressed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnTextBoxIpMaxKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_startListing.PerformClick();
            }
        }


        /// <summary>
        /// Perform the click of start listing when the ENTER key is pressed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnTextBoxNbIpKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_startListing.PerformClick();
            }
        }

        /// <summary>
        /// Show help message box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnButtonHelpClick(object sender, EventArgs e)
        {
            // TExte d'aide
            var s_help = $"HELP !{Environment.NewLine}{Environment.NewLine}" +
                $"Ce logiciel permet de lister toutes les adresses IPv4 d'un réseau ayant pour masque 255.255.255.0 (/24).{Environment.NewLine}{Environment.NewLine}" +
                $"Écrire la base de l'IP qui n'est pas modifiée par le masque. Puis mettre l'octet d'adresse la plus basse dans le champ \"Min\".{Environment.NewLine}" +
                $"Il y a deux possiblités pour définir la plage d'IP à tester :{Environment.NewLine}" +
                $" - Si vous voulez tester un certain nombre d'IP alors, il faut remplir le champ \"Nombre d'IP\".{Environment.NewLine}" +
                $" - Si vous souhaitez aller jusqu'à une IP particulière, il faut remplir le champ \"Max\" (et laisser le champ \"Nombre d'IP\" à 0).";

            // Texte d'à propos
            var s_about = $"À PROPOS :{Environment.NewLine}{Environment.NewLine}" +
                $"{_softDevName} - {_softName}{Environment.NewLine}" +
                $"Compilation :   {_softDate}{Environment.NewLine}" +
                $"Version :   {_softVersion}{Environment.NewLine}";

            // Rempli les paramètres de la Message Box
            var s_messageBoxContent = $"{s_help}{Environment.NewLine}{Environment.NewLine}{Environment.NewLine}{s_about}";
            var s_essageBoxTitle = "Aide";

            MessageBox.Show(this, s_messageBoxContent, s_essageBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
    }
}
