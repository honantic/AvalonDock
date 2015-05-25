using System.Windows;
using System.Windows.Controls;

namespace AvalonProject
{
    /// <summary>
    /// TestPage.xaml 的交互逻辑
    /// </summary>
    public partial class TestPage : Page
    {
        public TestPage()
        {
            InitializeComponent();
        }

        private void btn_ShowInfo_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("这是自定义的AvalonDock选项卡内容！");
        }
    }
}
