using MVVM_a_b.ViewModel;
using System.Windows;

namespace MVVM_a_b.Views
{
    public partial class Main : Window
    {
        public Main()
        {
            InitializeComponent();

            DataContext = new MainVM();

        }
    }
}
