using System;
using System.Windows.Forms;

namespace HideluzEstacionamentos
{
    public partial class FormSplash : Form
    {
        public FormSplash()
        {
            InitializeComponent();
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            SplashProgressBar.PerformStep();
        }
    }
}
