using System.Collections.Generic;
using System.Windows;

namespace WpfUserControl
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // Создаем экземпляр класса
            MyDataContext dc = new MyDataContext();
            // Заполняем данными
            dc.Name = "Test Name";
            dc.Number = 1;
            dc.ListMessage = new List<string>();
            dc.ListMessage.Add("Строка 1");
            dc.ListMessage.Add("Строка 2");
            dc.ListMessage.Add("Строка 3");
            // Устанавливаем контекст
            DataContext = dc;
        }
    }
}
