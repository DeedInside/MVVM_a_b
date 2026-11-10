using MVVM_a_b.Model;
using MVVM_a_b.ViewModel;
using System.Windows;

namespace MVVM_a_b.Views
{
    public partial class AutorizationWindow : Window
    {
        public User AuthUser { get; set; }
        public AutorizationWindow()
        {
            InitializeComponent();
            AutorizationVM vm = new AutorizationVM();
            vm.Dialog += Dialog;
            DataContext = vm;
            
        }
        public void Dialog(object sender, EventArgs e)
        {
            if(sender is User user)
            {
                AuthUser = user;
                DialogResult = true;
            }
            else
            {
                DialogResult = false;
            }
        }
    }
}
