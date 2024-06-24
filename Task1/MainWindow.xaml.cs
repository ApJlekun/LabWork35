using Microsoft.Win32;
using System.IO;
using System.Windows;

namespace Task1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OpenFileButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new()
            {
                Filter = "Текстовые (*.txt)|*.txt|C# (*.cs)|*.cs|HTML (*.html)|*.html|CSS (*.css)|*.css|JavaScript (*.js)|*.js|SQL (*.sql)|*.sql",
                InitialDirectory = Environment.CurrentDirectory,
                Title = "Открытие файла",
            };

            if (dialog.ShowDialog() != true)
                return;
            {
                textBox.Text = File.ReadAllText(dialog.FileName);
                Title = dialog.FileName;
            }
        }

        private void SaveButton_click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog dialog = new()
            {
                Filter = "Текстовые (*.txt)|*.txt|C# (*.cs)|*.cs|HTML (*.html)|*.html|CSS (*.css)|*.css|JavaScript (*.js)|*.js|SQL (*.sql)|*.sql",
                InitialDirectory = Environment.CurrentDirectory,
                Title = "Выбор файла",
            };
            if (dialog.ShowDialog() != true)
            {
                File.WriteAllText(dialog.FileName, textBox.Text);
                MessageBox.Show("file saved");
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (MessageBox.Show("Хотите закрыть приложение", "Подтвердите",
            MessageBoxButton.YesNo,
            MessageBoxImage.Question) != MessageBoxResult.Yes)
                e.Cancel = true;
        }
    }
}
