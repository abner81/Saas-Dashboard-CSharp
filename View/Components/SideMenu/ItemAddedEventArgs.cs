using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard_Study.View.Components
{
    public class ItemAddedEventArgs : EventArgs
    {
        public SideMenuItem Item { get; private set; }

        public ItemAddedEventArgs(SideMenuItem sideMenuItem)
        {
            Item = sideMenuItem;
        }
    }
}
