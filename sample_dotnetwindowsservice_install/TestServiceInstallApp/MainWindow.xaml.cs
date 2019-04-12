using System;
using System.Collections.Generic;
using System.Configuration.Install;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;

namespace TestServiceInstallApp
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private readonly string _selfFolderPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        private readonly string _targetServiceFileName = "TestService1.exe";

        private void OnClickInstall(object sender, RoutedEventArgs e)
        {
            var targetServicePath = Path.Combine(_selfFolderPath, _targetServiceFileName);
            ManagedInstallerClass.InstallHelper(new[] { "/LogFile=InstallLog.txt", "/ShowCallStack", targetServicePath });

            MessageBox.Show("Success");
        }

        private void OnClickUninstall(object sender, RoutedEventArgs e)
        {
            var targetServicePath = Path.Combine(_selfFolderPath, _targetServiceFileName);
            ManagedInstallerClass.InstallHelper(new[] { "/u", "/LogFile=UnInstallLog.txt", "/ShowCallStack", targetServicePath });

            MessageBox.Show("Success");
        }
    }
}
