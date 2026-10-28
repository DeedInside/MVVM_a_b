using MVVM_a_b.ViewModel;
using System.Windows;

namespace MVVM_a_b.Views
{
    public partial class AutorizationWindow : Window
    {
        public AutorizationWindow()
        {
            InitializeComponent();

            DataContext = new AutorizationVM();
        }
    }
}
