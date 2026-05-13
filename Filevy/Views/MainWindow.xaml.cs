using System.Windows;
using Filevy.ViewModels;

namespace Filevy
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
        }
    }
}