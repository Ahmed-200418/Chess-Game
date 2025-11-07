using System;
using System.Windows;
using System.Windows.Controls;

namespace ChessUI
{
    public partial class StartMenu : UserControl
    {
        public event Action<Option> OptionSelected;

        public StartMenu()
        {
            InitializeComponent();
        }

        private void StartGame_Click(object sender, RoutedEventArgs e)
        {
            OptionSelected?.Invoke(Option.Start);
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            OptionSelected?.Invoke(Option.Exit);
        }
    }
}
