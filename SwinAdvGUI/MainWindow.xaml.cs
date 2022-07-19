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
using Iteration1;

namespace SwinAdvGUI
{
    // Interaction logic for MainWindow.xaml
    public partial class MainWindow : Window
    {
        SwinAdvInstance _newProgram; //class in iteration1 library.
        public MainWindow()
        {
            InitializeComponent();
            _newProgram = new SwinAdvInstance();  //using from Iteration1 library.
            Console.Text = _newProgram.Output;
        }
        private void EnterClick(object sender, RoutedEventArgs e)
        {
            Console.Text = "\n" + _newProgram.InputCommand(commandBox.Text);
            commandBox.Clear();
            if (Console.Text == "\nbye!")
            {
                App.Current.Shutdown();
            }
        }

        private void TextChanged(object sender, RoutedEventArgs e)
        {

        }
    }
}
