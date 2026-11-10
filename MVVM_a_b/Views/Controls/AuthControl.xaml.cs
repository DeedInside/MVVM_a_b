using MVVM_a_b.Data;
using MVVM_a_b.Model;
using System.Windows;
using System.Windows.Controls;

namespace MVVM_a_b.Views.Controls
{
    public partial class AuthControl : UserControl
    {
        public event EventHandler? EventReg;
        public event EventHandler? EventLogin;
        public User AuthUser { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public AuthControl()
        {
            InitializeComponent();
            DataContext = this;
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
                              AuthUser = user;
                              EventLogin.Invoke(this, EventArgs.Empty);
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

        private RelayCommand regUser;
        public RelayCommand RegUser
        {
            get
            {
                return regUser ??
                  (regUser = new RelayCommand(obj =>
                  {
                      EventReg?.Invoke(this, EventArgs.Empty);
                  }));
            }
        }
        private RelayCommand exitUser;
        public RelayCommand ExitUser
        {
            get
            {
                return exitUser ??
                  (exitUser = new RelayCommand(obj =>
                  {
                      //todo выход из приложения
                  }));
            }
        }
    }
}
