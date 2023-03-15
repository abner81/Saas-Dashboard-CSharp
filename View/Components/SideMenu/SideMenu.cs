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
    public partial class SideMenu : UserControl
    {
        private SideMenuItemCollection _items;


        public SideMenuItemCollection Items
        {
            get
            {
                if (_items == null)
                {
                    _items = new SideMenuItemCollection(this);

                }
                return _items;
            }
            set => _items = value;
        }

        public event EventHandler<ItemSelectionEventArgs> ItemSelectionChanged;

        private void _items_ItemAdded(object? sender, ItemAddedEventArgs e)
        {
            e.Item.Clicked += Item_Selected;
        }


        private void Item_Selected(object? sender, ItemSelectionEventArgs e)
        {
            SideMenuItem clicked = e.Item;
            foreach (var menuItem in _items)
            {
                if (menuItem.ItemText != clicked.ItemText) menuItem.Selected = false;
            }

            ItemSelectionChanged?.Invoke(this, new ItemSelectionEventArgs(clicked));
        }
        public SideMenuItem SelectedItem
        {
            get
            {
                return _items[SelectedIndex];
            }
        }


        private int _selectedIndex = -1;
        public int SelectedIndex
        {
            get
            {
                return _selectedIndex;
            }
            set
            {
                _selectedIndex = value;
                foreach (var item in Items)
                {
                    item.Selected = false;
                }

                _items[_selectedIndex].Selected = true;
                Item_Selected(this,new ItemSelectionEventArgs(_items[_selectedIndex]));
            }
        }

        public SideMenu()
        {
            InitializeComponent();

            Dock = DockStyle.Fill;

            Items.ItemAdded += _items_ItemAdded;
        }
    }
}

