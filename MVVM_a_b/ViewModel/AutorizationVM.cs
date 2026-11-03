using MVVM_a_b.Model;
using MVVM_a_b.Views.Controls;
using System.Windows.Controls;

namespace MVVM_a_b.ViewModel
{
    public class AutorizationVM
    {
        public UserControl SelectedControl { get; set; }

        public AutorizationVM(User authuser)
        {
            SelectedControl = new AuthControl(authuser);
        }
    }
}
