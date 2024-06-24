using Microsoft.Win32;
using System.IO;
using System.Windows;

namespace Task4
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

        private void OpenButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new()
            {
                Filter = "расширеия |*.png, *.jpg *.jpeg, *.bmp; |все файлы|*.*",
                InitialDirectory = Environment.CurrentDirectory,
                Title = "Выбор файла",
                Multiselect = true,
            };

            if (dialog.ShowDialog() == true)
            {
                ImagesListView.ItemsSource = dialog.FileNames;
            }
        }
    }
}