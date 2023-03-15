using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard_Study.View.Components
{
    public partial class Header : UserControl
    {
        public string Title
        {
            get => lblTitle.Text;
            set => lblTitle.Text = value;
        }

        public Header()
        {
            InitializeComponent();
            Dock = DockStyle.Top;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
