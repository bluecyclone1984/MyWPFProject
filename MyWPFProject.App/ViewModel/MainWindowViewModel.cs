using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using GalaSoft.MvvmLight;
using MyWPFProject.UI;

namespace MyWPFProject.App
{
    public class MainWindowViewModel : ViewModelBase
    {
        private string _windowTitle;
        public string WindowTitle
        {
            get => _windowTitle;
            set => Set(ref _windowTitle, value);
        }

        private UserControl _content;
        public UserControl Content
        {
            get => _content;
            set => Set(ref _content, value);
        }

        public MainWindowViewModel()
        {
            InitWindow();
        }

        private void InitWindow()
        {
            _windowTitle = "周祎栋的WPF项目";
            _content = new Layout();
        }
    }
}
