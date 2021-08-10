using IPlugin;
using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace PluginWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static public List<IPlugin.IPlugin> Plugins = new List<IPlugin.IPlugin>();

        static public void LoadAllPlugins()
        {
            var files = Directory.GetFiles("Extentions");
            var assemblies = new List<Assembly>();
            foreach (var f in files.Where(x => x.EndsWith(".dll")))
            {
                var assembly = Assembly.LoadFile(Directory.GetCurrentDirectory() + "\\" + f);
                foreach (var type in assembly.GetTypes().Where(x => x.GetInterface("IPlugin") != null))
                {
                    Plugins.Add(Activator.CreateInstance(type) as IPlugin.IPlugin);
                }
            }

        }
        public MainWindow()
        {
            InitializeComponent();
            LoadAllPlugins();
            myList.ItemsSource = Plugins;
        }

        private void myList_Click(object sender, RoutedEventArgs e)
        {
            if(sender is IPlugin.IPlugin plugin)
            {
                MessageBox.Show(plugin.Creator, plugin.GetDateTime.ToString(), MessageBoxButton.OK);
            }
        }
    }
}
