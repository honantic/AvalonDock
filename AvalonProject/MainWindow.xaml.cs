using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using Xceed.Wpf.AvalonDock;
using Xceed.Wpf.AvalonDock.Layout;

namespace AvalonProject
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        int clickCount = 0;


        private void item_AddNew_Click(object sender, RoutedEventArgs e)
        {
            clickCount++;

            Frame frame = new Frame();
            frame.Content = new TestPage();

            LayoutAnchorable layOutAnc = new LayoutAnchorable() { Title = "新选项卡"+clickCount };
            layOutAnc.Content = frame;
            layOutAnc.Closing += Tab_Close;//添加退出事件处理句柄

            layOutPane.Children.Add(layOutAnc);
        }

        private void Tab_Close(object sender, CancelEventArgs e)
        {
            if (true)
            {
                if (MessageBox.Show("还没有保存，是否要退出？", "提示", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {

                }
                else
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
