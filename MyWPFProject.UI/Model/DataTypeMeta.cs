using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.ComponentModel;
using GalaSoft.MvvmLight;

namespace MyWPFProject.UI
{
    public class DataTypeMeta : ObservableObject
    {
        private int _value;
        public int Value
        {
            get => _value;
            set
            {
                _value = value; RaisePropertyChanged(() => Value);
            }
        }

        private string _name;
        public string Name
        {
            get => _name;
            set
            {
                _name = value; RaisePropertyChanged(() => Name);
            }
        }

        private string _description;
        public string Description
        {
            get => _description;
            set
            {
                _description = value; RaisePropertyChanged(() => Description);
            }
        }
    }
}
