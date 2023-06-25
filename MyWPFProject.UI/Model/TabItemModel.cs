using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace MyWPFProject.UI
{
    public class TabItemModel : ViewModelBase
    {
        private string _name;
        public string Name
        {
            get => _name;
            set => Set(ref _name, value);
        }

        private UserControl _content;
        public UserControl Content
        {
            get => _content;
            set => Set(ref _content, value);
        }

        private int _size = 16;
        public int Size
        {
            get => _size;
            set => Set(ref _size, value);
        }
    }
}
