using System;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Collections.ObjectModel;
using System.ComponentModel;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using Xceed.Wpf.AvalonDock;
using Xceed.Wpf.AvalonDock.Themes;

namespace MyWPFProject.UI
{
   public class MainDockViewModel: ViewModelBase
    {
        private DockingManager _dockingManager = null;
        public MainDockViewModel()
        {
            InitParams();
        }

        private void InitParams()
        {
            SelectedListBoxValue = 2;
            GenerateContextMenus();
            TreeNodeList = GetTreeNodeList();
            ListViewDataList = GetListViewDataList();
            ListBoxDataList = GetListBoxDataList();
        }

        public RelayCommand<RoutedEventArgs> CmdLoaded => new Lazy<RelayCommand<RoutedEventArgs>>(() => new RelayCommand<RoutedEventArgs>(Loaded)).Value;
        private void Loaded(RoutedEventArgs e)
        {
            _dockingManager = (e.Source as MainDock).dockingManager;
            _dockingManager.Theme = new Xceed.Wpf.AvalonDock.Themes.VS2010Theme();
        }

        private ObservableCollection<ListBoxData> _listboxDataList;
        public ObservableCollection<ListBoxData> ListBoxDataList
        {
            get => _listboxDataList;
            set => Set(ref _listboxDataList, value);
        }
        private ObservableCollection<ListBoxData> GetListBoxDataList()
        {
            return new ObservableCollection<ListBoxData>
            {
                new ListBoxData{ Value=1, Name = "劳动节" },
                new ListBoxData{ Value=2, Name = "中秋节" },
                new ListBoxData{ Value=3, Name = "国庆节" },
            };
        }
        private int _selectedListBoxValue;
        public int SelectedListBoxValue
        {
            get => _selectedListBoxValue;
            set => Set(ref _selectedListBoxValue, value);
        }

        private ObservableCollection<TreeModel> _treeNodeList;
        public ObservableCollection<TreeModel> TreeNodeList
        {
            get => _treeNodeList;
            set => Set(ref _treeNodeList, value);
        }
        private ObservableCollection<TreeModel> GetTreeNodeList()
        {
            return new ObservableCollection<TreeModel>
            {
                new TreeModel{ Name = "MainPrograme", ItemList = new ObservableCollection<TreeModel>{
                    new TreeModel { Name = "Programe"},
                    new TreeModel { Name = "Tags"}
                }
                },
                new TreeModel{ Name = "MainRoutine", ItemList = new ObservableCollection<TreeModel>{
                    new TreeModel { Name = "ST"}
                } },
            };
        }


        private ObservableCollection<ListViewData> _listViewDataList;
        public ObservableCollection<ListViewData> ListViewDataList
        {
            get => _listViewDataList;
            set => Set(ref _listViewDataList, value);
        }
        private ObservableCollection<ListViewData> GetListViewDataList()
        {
            var enumType = typeof(DataType);
            return new ObservableCollection<ListViewData>
            {
                new ListViewData{ ID=DataType.BOOL.GetHashCode(), Name = (enumType.GetField(Enum.GetName(enumType, DataType.BOOL)).GetCustomAttribute(typeof(DescriptionAttribute), false) as DescriptionAttribute)?.Description, Data_Type= DataType.BOOL, IsNumber=false },
                new ListViewData{ ID=DataType.BYTE.GetHashCode(), Name = (enumType.GetField(Enum.GetName(enumType, DataType.BYTE)).GetCustomAttribute(typeof(DescriptionAttribute), false) as DescriptionAttribute)?.Description, Data_Type= DataType.BYTE, IsNumber=false },
                new ListViewData{ ID=DataType.SINT.GetHashCode(), Name = (enumType.GetField(Enum.GetName(enumType, DataType.SINT)).GetCustomAttribute(typeof(DescriptionAttribute), false) as DescriptionAttribute)?.Description, Data_Type= DataType.SINT, IsNumber=true },
                new ListViewData{ ID=DataType.INT.GetHashCode(), Name =(enumType.GetField(Enum.GetName(enumType, DataType.INT)).GetCustomAttribute(typeof(DescriptionAttribute), false) as DescriptionAttribute)?.Description, Data_Type= DataType.INT, IsNumber=true },
                new ListViewData{ ID=DataType.DINT.GetHashCode(), Name =(enumType.GetField(Enum.GetName(enumType, DataType.DINT)).GetCustomAttribute(typeof(DescriptionAttribute), false) as DescriptionAttribute)?.Description, Data_Type= DataType.DINT, IsNumber=true },
                new ListViewData{ ID=DataType.REAL.GetHashCode(), Name =(enumType.GetField(Enum.GetName(enumType, DataType.REAL)).GetCustomAttribute(typeof(DescriptionAttribute), false) as DescriptionAttribute)?.Description, Data_Type= DataType.REAL, IsNumber=true },
            };
        }

        private void Navigate(string navigatePath)
        {
            MessageBox.Show($"按下: {navigatePath}");
        }
        private ObservableCollection<MenusModel> _contextMenus = new ObservableCollection<MenusModel>();
        public ObservableCollection<MenusModel> ContextMenus
        {
            get => _contextMenus;
            set => Set(ref _contextMenus, value);
        }

        private void GenerateContextMenus()
        {
            ContextMenus = new ObservableCollection<MenusModel>
            {
                new MenusModel
                {
                    Content = "File",
                    //IsChecked = true,
                    //CommandParameter = "home",
                    ItemList = new ObservableCollection<NavigateItemModel>
                    {
                        new NavigateItemModel
                        {
                            Content = "Open",
                            IsChecked = true,
                            CommandParameter = "open",
                            NavigateCommand = new Lazy<RelayCommand<string>>(() => new RelayCommand<string>(Navigate)).Value
                        },
                        new NavigateItemModel
                        {
                            Content = "Exit",
                            IsChecked = true,
                            CommandParameter = "exit",
                            NavigateCommand = new Lazy<RelayCommand<string>>(() => new RelayCommand<string>(Navigate)).Value
                        }
                    }
                },
                new MenusModel
                {
                    Content = "Communications",
                    //IsChecked = true,
                    //CommandParameter = "view",
                    ItemList = new ObservableCollection<NavigateItemModel>
                    {
                        new NavigateItemModel
                        {
                            Content = "RSWho",
                            IsChecked = true,
                            CommandParameter = "RSWho",
                            NavigateCommand = new Lazy<RelayCommand<string>>(() => new RelayCommand<string>(Navigate)).Value
                        }
                    }
                },
                new MenusModel
                {
                    Content = "Edit",
                    //IsChecked = true,
                    //CommandParameter = "time",
                    ItemList = new ObservableCollection<NavigateItemModel>
                    {
                        new NavigateItemModel
                        {
                            Content = "Find",
                            IsChecked = true,
                            CommandParameter = "find",
                            NavigateCommand = new Lazy<RelayCommand<string>>(() => new RelayCommand<string>(Navigate)).Value
                        }
                    }
                },
            };
        }

    }
}
