using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using GalaSoft.MvvmLight;
using Xceed.Wpf.AvalonDock;
using Xceed.Wpf.AvalonDock.Themes;

namespace MyWPFProject.UI
{
    public class LayoutViewModel: ViewModelBase
    {
        public LayoutViewModel()
        {
            MainDockContent = new MainDock();
            MenuContent = new Menu(MainDockContent);
            ToolBarContent = new ToolBar(MainDockContent);
            
        }

        private Menu _menucontent;
        public Menu MenuContent
        {
            get => _menucontent;
            set => Set(ref _menucontent, value);
        }

        private ToolBar _toolBarcontent;
        public ToolBar ToolBarContent
        {
            get => _toolBarcontent;
            set => Set(ref _toolBarcontent, value);
        }

        private MainDock _mainDockcontent;
        public MainDock MainDockContent
        {
            get => _mainDockcontent;
            set => Set(ref _mainDockcontent, value);
        }
    }
}
