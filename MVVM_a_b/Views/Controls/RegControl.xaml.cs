using MVVM_a_b.Data;
using MVVM_a_b.Model;
using System.Windows;
using System.Windows.Controls;

namespace MVVM_a_b.Views.Controls
{

    public partial class RegControl : UserControl
    {
        public event EventHandler? EventAuth;
        public string Login { get; set; }
        public string OnePassword { get; set; }
        public string TwoPassword { get; set; }

        public RegControl()
        {
            InitializeComponent();
            DataContext = this;
        }

        private RelayCommand regUser;
        public RelayCommand RegUser
        {
            get
            {
                return regUser ??
                  (regUser = new RelayCommand(obj =>
                  {
                      if(!string.IsNullOrWhiteSpace(Login) && !string.IsNullOrWhiteSpace(OnePassword)
                      && !string.IsNullOrWhiteSpace(OnePassword))
                      {
                          User? userLogin = LocalDataContext.Users.FirstOrDefault(q => q.Login == Login);
                          if (userLogin == null)
                          {
                              if(OnePassword == TwoPassword)
                              {
                                  User newUser = new  User()
                                  {
                                      Login = Login,
                                      Password = OnePassword,
                                      Role = LocalDataContext.Roles[0]
                                  };

                                  LocalDataContext.Users.Add(newUser);
                                  EventAuth?.Invoke(this, EventArgs.Empty);
                              }
                              else
                              {
                                  MessageBox.Show("Пароли не совпадают");
                              }
                          }
                          else
                          {
                              MessageBox.Show("Логин занят");
                          }
                      }
                      else
                      {
                          MessageBox.Show("Заполните все поля");
                      }
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
                      EventAuth?.Invoke(this, EventArgs.Empty);
                  }));
            }
        }
    }
}
