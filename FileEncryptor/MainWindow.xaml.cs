using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace FileEncryptor
{
    public partial class MainWindow : Window
    {
        private bool skipPrompt = false;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void EncryptButton_Click(object sender, RoutedEventArgs e)
        {
            
// Encrypt file logic
            string filePath = PromptFilePath("Verschlüsselung");
            if (string.IsNullOrEmpty(filePath)) return;

            if (MessageBox.Show($"Möchten Sie die Datei {Path.GetFileName(filePath)} wirklich verschlüsseln?", "Bestätigung", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.No) return;

            string password = PromptPassword();
            if (password == null) return;

            try
            {
                EncryptFile(filePath, filePath + ".encrypted", password);
                ShowSuccessMessage("Die Datei wurde erfolgreich verschlüsselt.");
                File.Delete(filePath); // Delete original file
            }
            catch (Exception ex)
            {
                ShowErrorWindow("Fehler bei der Verschlüsselung", ex.Message);
            }

            AskNextAction();
        }

        private void DecryptButton_Click(object sender, RoutedEventArgs e)
        {
// Decrypt file logic
            string filePath = PromptFilePath("Entschlüsselung");
            if (string.IsNullOrEmpty(filePath)) return;

            string password = PromptPassword();
            if (password == null) return;

            int attempts = 0;
            string decryptedFilePath = filePath.Replace(".encrypted", "");

            while (attempts < 5)
            {
                try
                {
                    DecryptFile(filePath, decryptedFilePath, password);
                    ShowSuccessMessage("Die Datei wurde erfolgreich entschlüsselt.");
                    File.Delete(filePath);
                    break;
                }
                catch (CryptographicException)
                {
                    if (++attempts >= 5)
                    {
                        File.Delete(filePath);
                        ShowErrorWindow("Maximale Versuche erreicht", "Die Datei wurde gelöscht.");
                    }
                    else
                    {
                        ShowErrorWindow("Fehlerhafte Entschlüsselung", $"Versuche verbleibend: {5 - attempts}");
                        password = PromptPassword();
                    }
                }
                catch (Exception ex)
                {
                    ShowErrorWindow("Unerwarteter Fehler", ex.Message);
                    break;
                }
            }

            AskNextAction();
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void AskNextAction()
        {
            if (skipPrompt) return;

            var result = MessageBox.Show("Möchten Sie eine weitere Aktion durchführen?", "Fortsetzen", MessageBoxButton.YesNoCancel, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes) return;
            if (result == MessageBoxResult.No) Application.Current.Shutdown();
            else skipPrompt = true;
        }

        private string PromptFilePath(string action)
        {
            var dialog = new Microsoft.Win32.OpenFileDialog
            {
                Filter = "Alle Dateien (*.*)|*.*",
                Title = $"Datei für {action} auswählen"
            };
            return dialog.ShowDialog() == true ? dialog.FileName : string.Empty;
        }

        private string PromptPassword()
        {
            var passwordWindow = new PasswordWindow("Bitte geben Sie das Passwort ein:");
            passwordWindow.ShowDialog();
            return passwordWindow.Password;
        }

        private void EncryptFile(string inputFile, string outputFile, string password)
        {
            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(password.Substring(0, 16));
                aes.IV = new byte[16];

                using (var fileStream = new FileStream(outputFile, FileMode.Create))
                using (var cryptoStream = new CryptoStream(fileStream, aes.CreateEncryptor(), CryptoStreamMode.Write))
                using (var inputStream = new FileStream(inputFile, FileMode.Open))
                {
                    inputStream.CopyTo(cryptoStream);
                }
            }
        }

        private void DecryptFile(string inputFile, string outputFile, string password)
        {
            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(password.Substring(0, 16));
                aes.IV = new byte[16];

                using (var fileStream = new FileStream(outputFile, FileMode.Create))
                using (var cryptoStream = new CryptoStream(fileStream, aes.CreateDecryptor(), CryptoStreamMode.Write))
                using (var inputStream = new FileStream(inputFile, FileMode.Open))
                {
                    inputStream.CopyTo(cryptoStream);
                }
            }
        }

        private void ShowSuccessMessage(string message)
        {
            MessageBox.Show(message, "Erfolg", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void ShowErrorWindow(string title, string message)
        {
            var errorWindow = new ErrorWindow(title, message);
            errorWindow.ShowDialog();
        }
    }
}
