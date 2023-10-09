using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Main : Form
    {
        int progress_num = 0;

        public Main()
        {
            InitializeComponent();
            txtText.Text = null;

        }

        private void start(object sender, EventArgs e)
        {
            btnStart.Hide();
            txtText.Text = "게임이 시작됩니다.";
        }

        private void progress(object sender, EventArgs e)
        {
            progress_num++;
        }

        private void progressChecker_Tick(object sender, EventArgs e)
        {
            progress_num++;
            txtText.Text = progress_num.ToString();
        }
    }
}
