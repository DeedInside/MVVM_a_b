using MVVM_a_b.Data;
using MVVM_a_b.Model;
using System.Windows;
using System.Windows.Controls;

namespace MVVM_a_b.Views.Controls
{
    public partial class AuthControl : UserControl
    {
        private User authUser;
        public string Login { get; set; }
        public string Password { get; set; }
        public AuthControl(User authUser)
        {
            InitializeComponent();
            DataContext = this;
            this.authUser = authUser;
        }
        private RelayCommand loginUser;
        public RelayCommand LoginUser
        {
            get
            {
                return loginUser ??
                  (loginUser = new RelayCommand(obj =>
                  {
                      if(!string.IsNullOrWhiteSpace(Login) && !string.IsNullOrWhiteSpace(Password))
                      {
                          User? user = LocalDataContext.Users.FirstOrDefault(
                              q => q.Login == Login && q.Password == Password);

                          if (user != null)
                          {
                              authUser = user;
                          }
                          else
                          {
                              MessageBox.Show("такой пользователь не найден");
                          }
                      }
                      else
                      {
                          MessageBox.Show("Заполните все поля");
                      }
                  }));
            }
        }
    }
}
