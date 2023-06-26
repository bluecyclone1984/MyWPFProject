using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using System.Collections.ObjectModel;

namespace MyWPFProject.UI
{
    public class MenuViewModel : ViewModelBase
    {
        private MainDock _mainDockcontent;
        public MainDock MainDockContent
        {
            get => _mainDockcontent;
            set => Set(ref _mainDockcontent, value);
        }

        // public RelayCommand<string> NavigateCommand => new Lazy<RelayCommand<string>>(() => new RelayCommand<string>(Navigate)).Value;
        private void Navigate(string navigatePath)
        {
            MessageBox.Show($"按下: {navigatePath}");
        }
        private ObservableCollection<MenusModel> _menus = new ObservableCollection<MenusModel>();
        public ObservableCollection<MenusModel> Menus
        {
            get => _menus;
            set => Set(ref _menus, value);
        }

        public MenuViewModel(MainDock mainDock)
        {
            MainDockContent = mainDock;
            Menus = new ObservableCollection<MenusModel>
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
