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
    public class NotifyPropertyChangedInstance : NotifyPropertyChangedBase
    {
        private string name;
        private string code;

        public string Name
        {
            get { return name; }
            set { name = value; OnPropertyChanged("Name"); }
        }

        public string Code
        {
            get { return code; }
            set { code = value; OnPropertyChanged("Code"); }
        }
    }
}
