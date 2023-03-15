using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard_Study.View.Components
{
    public class ItemSelectionEventArgs : EventArgs
    {
        public SideMenuItem Item { get; private set; }

        public ItemSelectionEventArgs(SideMenuItem item)
        {
            Item = item;
        }
    }
}
