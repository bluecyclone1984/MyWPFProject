using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using System.Collections.ObjectModel;

namespace MyWPFProject.UI
{
    public class NavigateItemModel : ViewModelBase
    {
        /// 界面显示的文本
        /// </summary>
        private string _content;
        public string Content
        {
            get => _content;
            set => Set(ref _content, value);
        }

        /// <summary>
        /// 是否选中状态
        /// </summary>
        private bool _isChecked;
        public bool IsChecked
        {
            get => _isChecked;
            set => Set(ref _isChecked, value);
        }

        /// <summary>
        /// 导航参数（要导航到的页面的名字）
        /// </summary>
        private string _commandParameter;
        public string CommandParameter
        {
            get => _commandParameter;
            set => Set(ref _commandParameter, value);
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
        /// 导航命令
        /// </summary>
        public RelayCommand<string> NavigateCommand { get; set; }
    }
}
