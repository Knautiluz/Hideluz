using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace HideluzEstacionamentos
{
    public partial class Splash : Form
    {
        public static bool ProgressComplete;
        public static List<string> Types = new List<string>();
        public Splash()
        {
            InitializeComponent();
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            SplashProgressBar.PerformStep();
            ProgressComplete = true;
        }
    }
}
