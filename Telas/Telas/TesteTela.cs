using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telas
{
    public partial class TesteTela : Form
    {
        bool sadebarExpand = true;
        public TesteTela()
        {
            InitializeComponent();
        }

        private void sadebarTime_Tick(object sender, EventArgs e)
        {
            if (sadebarExpand)
            {
                sadebarConteiner.Width -= 15;
                if (sadebarConteiner.Width == sadebarConteiner.MinimumSize.Width)
                {
                    sadebarExpand = false;
                    sadebarTime.Stop();
                }
            }
            else
            {
                sadebarConteiner.Width += 15;
                if (sadebarConteiner.Width == sadebarConteiner.MaximumSize.Width)
                {
                    sadebarExpand = false;
                    sadebarTime.Stop();
                }
            }
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            sadebarTime.Start();
        }
    }
}
