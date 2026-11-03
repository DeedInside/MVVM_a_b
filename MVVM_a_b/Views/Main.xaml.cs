using MVVM_a_b.ViewModel;
using System.Windows;

namespace MVVM_a_b.Views
{
    public partial class Main : Window
    {
        public Main()
        {
            AutorizationWindow autorization = new AutorizationWindow();

            if(autorization.ShowDialog() == true)
            {
                InitializeComponent();
                DataContext = new MainVM(autorization.AuthUser);
            }
            else
            {
                Close();
            }
        }
    }
}
