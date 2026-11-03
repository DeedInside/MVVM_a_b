using MVVM_a_b.Model;
using MVVM_a_b.ViewModel;
using System.Windows;

namespace MVVM_a_b.Views
{
    public partial class AutorizationWindow : Window
    {
        private User authUser = null;
        public User AuthUser {
            get
            {
                return authUser;
            }
            set
            {
                //todo создание объекта 1 раз
                if(value is User && value != null)
                {
                    authUser = value;
                    DialogResult = true;
                }
            }
        }
        public AutorizationWindow()
        {
            InitializeComponent();
            DataContext = new AutorizationVM(AuthUser);
        }
    }
}
