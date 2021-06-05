using System.Windows;

namespace WpfApp.View
{
    /// <summary>
    /// Логика взаимодействия для WindowNewEmployee.xaml
    /// </summary>
    public partial class WindowNewEmployee : Window
    {
        public WindowNewEmployee()
        {
            InitializeComponent();
        }

        /// <summary>
        /// сохранение данных
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtSave_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }
    }
}
