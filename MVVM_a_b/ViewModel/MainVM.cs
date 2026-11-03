using MVVM_a_b.Model;
using System.Windows;

namespace MVVM_a_b.ViewModel
{
    public class MainVM
    {
        public User AuthUser { get; set; }

        public MainVM(User user)
        {
            AuthUser = user;
            MessageBox.Show(AuthUser.ToString());
        }
    }
}
