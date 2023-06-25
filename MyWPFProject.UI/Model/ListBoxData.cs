using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using System.Collections.ObjectModel;

namespace MyWPFProject.UI
{
    public class ListBoxData : ObservableObject
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
    }
}
