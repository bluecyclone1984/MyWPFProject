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
using System.ComponentModel;
using System.Reflection;
using System.Windows.Input;


namespace MyWPFProject.UI
{
    public class ToolBarViewModel : ViewModelBase
    {
        private string _textBoxContent;
        public string TextBoxContent
        {
            get => _textBoxContent;
            set => Set(ref _textBoxContent, value);
        }

        private double _textBoxNumber;
        public double TextBoxNumber
        {
            get => _textBoxNumber;
            set => Set(ref _textBoxNumber, value);
        }
        private List<DataTypeMeta> _dataTypeSources;
        public List<DataTypeMeta> DataTypeSources
        {
            get => _dataTypeSources;
            set => Set(ref _dataTypeSources, value);
        }
        private void GenerateDataTypeSources()
        {
            _dataTypeSources = new List<DataTypeMeta>();
            var enumType = typeof(DataType);
            foreach (var item in Enum.GetValues(enumType))
            {
                _dataTypeSources.Add(new DataTypeMeta()
                {
                    Name = Enum.GetName(enumType, item),
                    Value = item.GetHashCode(),
                    Description = (enumType.GetField(Enum.GetName(enumType, item)).GetCustomAttribute(typeof(DescriptionAttribute), false) as DescriptionAttribute)?.Description
                });
            }
        }
        private SelectType _selectTypeEnum;
        public SelectType SelectTypeEnum
        {
            get => _selectTypeEnum;
            set => Set(ref _selectTypeEnum, value);
        }

        private string _mouseText;
        public string MouseText
        {
            get => _mouseText;
            set => Set(ref _mouseText, value);
        }
        private string _mouseClickText;
        public string MouseClickText
        {
            get => _mouseClickText;
            set => Set(ref _mouseClickText, value);
        }
        private int _selectedDataType;
        public int SelectedDataType
        {
            get => _selectedDataType;
            set => Set(ref _selectedDataType, value);
        }


        public RelayCommand<UserControl> CmdLoaded => new Lazy<RelayCommand<UserControl>>(() => new RelayCommand<UserControl>(Loaded)).Value;
        private void Loaded(UserControl control)
        {
            //MessageBox.Show("ToolBar: " + control.ActualWidth + " * " + control.ActualHeight);
        }

        public RelayCommand<MouseEventArgs> CmdMouseMove => new RelayCommand<MouseEventArgs>(MouseMove);
        private void MouseMove(MouseEventArgs e)
        {
            // 显示鼠标所在位置
            Point point = e.GetPosition(e.Device.Target);
            MouseText = point.X + ", " + point.Y;
        }

        public RelayCommand<RoutedEventArgs> CmdButtonClick => new Lazy<RelayCommand<RoutedEventArgs>>(() => new RelayCommand<RoutedEventArgs>(ButtonClick)).Value;
        private void ButtonClick(RoutedEventArgs e)
        {
            MessageBox.Show("Add " + (e.Source as Button)?.Content);
        }

        public RelayCommand<string> CmdBtnCommand => new Lazy<RelayCommand<string>>(() => new RelayCommand<string>(BtnCommand)).Value;
        private void BtnCommand(string info)
        {
            MessageBox.Show("Remove " + info);
        }

        /// <summary>
        /// 鼠标点击事件
        /// </summary>
        public RelayCommand<MouseButtonEventArgs> CmdMouseDown => new Lazy<RelayCommand<MouseButtonEventArgs>>(() => new RelayCommand<MouseButtonEventArgs>(MouseDown)).Value;
        private void MouseDown(MouseButtonEventArgs e)
        {
            // 判断按下的鼠标按键
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                MouseClickText = "左键按下";
            }
            else if (e.RightButton == MouseButtonState.Pressed)
            {
                MouseClickText = "右键按下";
            }
            else if (e.MiddleButton == MouseButtonState.Pressed)
            {
                MouseClickText = "中键按下";
            }
        }

        /// <summary>
        /// 数字输入框键盘按键事件
        /// </summary>
        public RelayCommand<KeyEventArgs> CmdKeyDown => new Lazy<RelayCommand<KeyEventArgs>>(() => new RelayCommand<KeyEventArgs>(NumKeyDown)).Value;
        private void NumKeyDown(KeyEventArgs e)
        {
            if (((e.Key >= Key.D0 && e.Key <= Key.D9) || (e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9) ||
               e.Key == Key.Delete || e.Key == Key.Back || e.Key == Key.Left || e.Key == Key.Right || e.Key == Key.Home || e.Key == Key.End)
              && e.KeyboardDevice.Modifiers == ModifierKeys.None)
            {
                e.Handled = false;
            }
            else if ((e.Key == Key.Decimal || e.Key == Key.OemPeriod) && e.KeyboardDevice.Modifiers == ModifierKeys.None)
            {
                TextBox txt = e.Source as TextBox;
                if (txt.Text.Contains(".")) e.Handled = true;
                else e.Handled = false;
            }
            else e.Handled = true;
        }

        public RelayCommand<SelectionChangedEventArgs> CmdSelectionChanged => new Lazy<RelayCommand<SelectionChangedEventArgs>>(() => new RelayCommand<SelectionChangedEventArgs>(ComboBox_SelectionChanged)).Value;
        private void ComboBox_SelectionChanged(SelectionChangedEventArgs e)
        {
            MessageBox.Show($"选中{((e.Source as ComboBox)?.SelectedItem as DataTypeMeta)?.Description}");
        }

        public ToolBarViewModel()
        {
            InitParams();
        }

        private void InitParams()
        {
            TextBoxContent = "我的文本";
            TextBoxNumber = 10.5;
            SelectTypeEnum = SelectType.Yes;
            SelectedDataType = DataType.BYTE.GetHashCode();
            GenerateDataTypeSources();
        }

    }
}
