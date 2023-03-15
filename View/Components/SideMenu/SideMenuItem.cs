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
    public partial class SideMenuItem : UserControl
    {
        public string ItemText
        {
            get => button.Text;
            set => button.Text = value;
        }

        public Image Icon
        {
            get => button.Image;
            set => button.Image = value;
        }

        public UserControl Destination { get; set; }

        public override DockStyle Dock { get { return base.Dock; } set { base.Dock = value; } }

        public event EventHandler<ItemSelectionEventArgs> Clicked;

        public bool Selected
        {
            get
            {
                return borderLeft.Visible;
            }
            set
            {
                borderLeft.Visible = value;
                BackColor = value ? Settings.SecondaryColor : Settings.PrimaryColor;
            }
        }

        public SideMenuItem()
        {
            InitializeComponent();

            Dock = DockStyle.Top;
            SendToBack();
            Selected = false;

            //if (Destination == null) throw new Exception("SideMenuItem.Destination precisa ser atribuído.");
            button.Click += (sender, e) =>
            {
                Clicked?.Invoke(this, new ItemSelectionEventArgs(this));
                Selected = true;
            };
        }
    }
}
