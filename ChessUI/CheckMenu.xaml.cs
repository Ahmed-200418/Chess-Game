using System.Windows;
using System.Windows.Controls;
using ChessLogic;

namespace ChessUI
{
    /// <summary>
    /// Interaction logic for CheckMenu.xaml
    /// </summary>
    public partial class CheckMenu : UserControl
    {
        public event Action? OptionSelected;

        public CheckMenu(Player player)
        {
            InitializeComponent();
            CheckText.Text = $"{player} IS IN CHECK";
        }

        private void Continue_Click(object sender, RoutedEventArgs e)
        {
            OptionSelected?.Invoke();
        }
    }
}
