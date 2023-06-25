using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace MyWPFProject.App
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            SplashScreen splashScreen = new SplashScreen("/Resource/SplashScreen.jpeg");
            splashScreen.Show(true);
            //上面Show()方法中设置为true时，程序启动完成后启动图片就会自动关闭，
            //设置为false时，启动图片不会自动关闭，需要使用下面一句设置显示时间，例如3s
            //splashScreen.Close(new TimeSpan(0, 0, 3));
            base.OnStartup(e);
        }
    }
}
