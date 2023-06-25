using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Collections.ObjectModel;
using System.ComponentModel;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;

namespace MyWPFProject.UI
{
    public class SettingDialogViewModel: ViewModelBase
    {
        public SettingDialogViewModel()
        {
        }

        private void initParams()
        {
            SelectedItemIndex = 0;
        }

        private int _selectedItemIndex;
        public int SelectedItemIndex
        {
            get => _selectedItemIndex;
            set => Set(ref _selectedItemIndex, value);
        }

        private ObservableCollection<TabItemModel> _tabitemList;
        public ObservableCollection<TabItemModel> TabItemList
        {
            get => _tabitemList;
            set => Set(ref _tabitemList, value);
        }
    }
}
