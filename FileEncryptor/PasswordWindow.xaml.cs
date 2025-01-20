using System.Windows;

namespace FileEncryptor
{
    public partial class PasswordWindow : Window
    {
        public string Message { get; }
        public string Password { get; private set; }

        public PasswordWindow(string v)
        {
            Password = string.Empty;
            InitializeComponent();
            Message = "Bitte geben Sie das Passwort ein:"; 
            DataContext = this;
        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            Password = PasswordBox.Password;
            DialogResult = true;
            Close();
        }
    }
}
