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

namespace PassGen
{
    public partial class MainWindow : Window
    {
        public string[] digits = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        public string[] lowercaseLetters = new string[] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
        public string[] uppercaseLetters = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
        public string[] specialSymbols = new string[] { "#", "!", "$", ";", "_", "&", "^", "%", "&", "*", "(", ")", "{", "}", "[", "]" };

        public const int USE_DIGITS = 1;
        public const int USE_LOWERCASE_LETTERS = 2;
        public const int USE_UPPERCASE_LETTERS = 3;
        public const int USE_SPECIAL_SYMBOLS = 4;

        public MainWindow()
        {
            InitializeComponent();
        }










        private void ButtonClose(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
