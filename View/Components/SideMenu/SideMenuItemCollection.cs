using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard_Study.View.Components
{
    public class SideMenuItemCollection : IEnumerable<SideMenuItem>
    {
        private SideMenu _sideMenu;
        private Collection<SideMenuItem> _collection;

        public SideMenuItemCollection(SideMenu owner)
        {
            _collection = new Collection<SideMenuItem>();
            this._sideMenu = owner;
       
        }

        public event EventHandler<ItemAddedEventArgs> ItemAdded;

        public SideMenuItem this[int index] { get => _collection[index]; set => throw new NotImplementedException(); }

        public int Count => _collection.Count;

        public bool IsReadOnly => throw new NotImplementedException();

        public void Add(SideMenuItem item)
        {
            _collection.Add(item);
            _sideMenu.Controls.Add(item);
            _sideMenu.Controls.SetChildIndex(item, 0);
            ItemAdded?.Invoke(this, new ItemAddedEventArgs(item));
        }

        public void Clear()
        {
            _collection.Clear();
            _sideMenu.Controls.Clear();
        }

        public bool Contains(SideMenuItem item)
        {
           return _collection.Contains(item);
        }

        public void CopyTo(SideMenuItem[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<SideMenuItem> GetEnumerator()
        {
            return _collection.GetEnumerator();
        }

        public int IndexOf(SideMenuItem item)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, SideMenuItem item)
        {
            _collection.Insert(index, item);
        }

        public bool Remove(SideMenuItem item)
        {
           return _collection.Remove(item);
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _collection.GetEnumerator();
        }
    }
}
