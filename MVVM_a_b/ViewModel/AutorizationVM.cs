using MVVM_a_b.Model;
using MVVM_a_b.Views.Controls;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Controls;

namespace MVVM_a_b.ViewModel
{
    public class AutorizationVM: INotifyPropertyChanged
    {
        public event EventHandler Dialog;
        private UserControl selectedControl;
        public UserControl SelectedControl
        {
            get
            {
                return selectedControl;
            }
            set
            {
                selectedControl = value;
                OnPropertyChanged("SelectedControl");
            }
        }

        public AutorizationVM()
        {
            
            AuthControl authControl = new ();
            authControl.EventReg += SwapControl;
            authControl.EventLogin += EventAuth;
            SelectedControl = authControl;
        }
        private void EventAuth(object sender, EventArgs e)
        {
            if(sender is AuthControl auth)
            {
                if(auth.AuthUser != null)
                {
                    Dialog.Invoke(auth.AuthUser, EventArgs.Empty);
                }

            }
        }
        private void SwapControl(object sender, EventArgs e)
        {
            if(sender is AuthControl auth)
            {
                auth.EventReg -= SwapControl;
                RegControl regControl = new();
                regControl.EventAuth += SwapControl;
                SelectedControl = regControl;
            }
            else if(sender is RegControl reg)
            {
                reg.EventAuth -= SwapControl;
                AuthControl authControl = new();
                authControl.EventReg += SwapControl;
                authControl.EventLogin += EventAuth;
                SelectedControl = authControl;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
