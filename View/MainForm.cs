using Dashboard_Study.View.Components;
using System.Runtime.InteropServices;
using Icons = Dashboard_Study.Properties.Resources;

namespace Dashboard_Study.View
{
    public partial class MainForm : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]


        private static extern IntPtr CreateRoundRectRgn
(
  int nLeftRect,
  int nTopRect,
  int nRightRect,
  int nBottomRect,
  int nWidthEllipse,
 int nHeightEllipse

);

        private Routes _routes { get; set; }

        public MainForm()
        {
            InitializeComponent();
            MakeFormRounded();
            _routes = new Routes(contentPlace);

            CreateSideMenuItems();
            sideMenu.SelectedIndex = 0;
        }

        private void MakeFormRounded() => Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));

        private void CreateSideMenuItems()
        {

            sideMenu.Items.Add(new SideMenuItem { ItemText = "Dashboard", Icon = Icons.Conact, Destination = new DashboardPage() });
            sideMenu.Items.Add(new SideMenuItem { ItemText = "Analytics", Icon = Icons.Conact, Destination = new AnalyticsPage() });
            sideMenu.Items.Add(new SideMenuItem { ItemText = "Calendar", Icon = Icons.Conact, Destination = new CalendarPage() });
            sideMenu.Items.Add(new SideMenuItem { ItemText = "ContactUs", Icon = Icons.Conact, Destination = new ContactUsForm() });
            sideMenu.Items.Add(new SideMenuItem { ItemText = "Settings", Icon = Icons.Conact, Destination = new SettingsPage(), Dock = DockStyle.Bottom }); ;
        }

        private void sideMenu_ItemSelectionChanged(object sender, ItemSelectionEventArgs args)
        {
            header.Title = args.Item.ItemText;
            _routes.GoTo(args.Item.Destination);
        }
    }
}
