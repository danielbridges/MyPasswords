
namespace MyPasswords
{
    using System.Collections.Generic;
    using System.Windows;
    using Library;
    using FileHelpers;

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            var csvPersister = new CsvPersister("c:\\temp\\pw1.txt", new DelimitedFileEngine<Credentials>());
            var newCreds = new List<Credentials>
            {
                new Credentials { Account = "Account1", Password = "Password2", Site = "site1" }
            };

            csvPersister.Save(newCreds);
        }

        private void LoadButton_Click(object sender, RoutedEventArgs e)
        {
            var csvRepository = new CsvRepository("c:\\temp\\pw1.txt", new DelimitedFileEngine<Credentials>());
            var results = csvRepository.Load();

        }
    }
}
