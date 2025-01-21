using System.Windows;

namespace AegisCrypt
{
    public partial class ErrorWindow : Window
    {
        public ErrorWindow(string title, string message)
        {
            InitializeComponent();
            ErrorTitle.Text = title;  
            ErrorMessage.Text = message;  
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Close(); 
        }
    }
}
