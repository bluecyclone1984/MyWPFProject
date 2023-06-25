using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using System.Collections.ObjectModel;

namespace MyWPFProject.UI
{
    public class TreeModel : ViewModelBase
    {
        private string name;
        public string Name
        {
            get => name;
            set => Set(ref name, value);
        }

        public ObservableCollection<TreeModel> _itemList;
        public ObservableCollection<TreeModel> ItemList
        {
            get => _itemList;
            set => Set(ref _itemList, value);
        }
    }
}
