using System.Threading;
using System.Globalization;
namespace multi_languages
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            if (Properties.Settings.Default.Language == "en") Thread.CurrentThread.CurrentUICulture = new CultureInfo("en");
            else if (Properties.Settings.Default.Language == "fa") Thread.CurrentThread.CurrentUICulture = new CultureInfo("fa");
            else if (Properties.Settings.Default.Language == "fr") Thread.CurrentThread.CurrentUICulture = new CultureInfo("fr");
            else Thread.CurrentThread.CurrentUICulture = new CultureInfo("en");
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Language = "En";
            Properties.Settings.Default.Save();
            Application.Exit();
        }

        private void persianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Language = "fa";
            Properties.Settings.Default.Save();
            Application.Exit();
        }

        private void frenchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Language = "fr";
            Properties.Settings.Default.Save();
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}