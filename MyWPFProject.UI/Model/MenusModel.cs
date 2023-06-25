using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using GalaSoft.MvvmLight;
using System.Collections.ObjectModel;

namespace MyWPFProject.UI
{
    public class MenusModel : ViewModelBase
    {
        /// <summary>
        /// 一级目录显示的文本
        /// </summary>
        private string _content;
        public string Content
        {
            get => _content;
            set => Set(ref _content, value);
        }


        /// <summary>
        /// 尺寸
        /// </summary>
        private int _size = 16;
        public int Size
        {
            get => _size;
            set => Set(ref _size, value);
        }

        /// <summary>
        /// 二级菜单信息
        /// </summary>
        private ObservableCollection<NavigateItemModel> _itemList;
        public ObservableCollection<NavigateItemModel> ItemList
        {
            get => _itemList;
            set => Set(ref _itemList, value);
        }
    }
}
