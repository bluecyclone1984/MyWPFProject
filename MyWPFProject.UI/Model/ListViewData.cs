using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using System.Collections.ObjectModel;

namespace MyWPFProject.UI
{
    public class ListViewData : ViewModelBase
    {
        private int _id;
        public int ID
        {
            get => _id;
            set => Set(ref _id, value);
        }

        private string _name;
        public string Name
        {
            get => _name;
            set => Set(ref _name, value);
        }

        private DataType _data_type;
        public DataType Data_Type
        {
            get => _data_type;
            set => Set(ref _data_type, value);
        }

        private bool _isNumber;
        public bool IsNumber
        {
            get => _isNumber;
            set => Set(ref _isNumber, value);
        }

        private bool _isVisible;
        public bool IsVisible
        {
            get => _isVisible;
            set => Set(ref _isVisible, value);
        }
    }
}
