using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PhotoEditor
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
         
        public MainWindow()
        {
            InitializeComponent();
        }

       
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e) //Wyłącz wszystkie włączone okna !!!
        {
           
        }

        private void LayerAdder_Click(object sender, RoutedEventArgs e)
        {

        }

        private void LayerDeleter_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Menu_File_Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Menu_File_Open_Click(object sender, RoutedEventArgs e)
        {
            Layer layer = new Layer(100, 100); //FOR TESTING PURPOSE!!!
            MessageBox.Show("A");
            
        }
    }
}
