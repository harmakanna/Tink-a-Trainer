using Avalonia.Controls;
using Avalonia.Interactivity;

namespace Tink_a_Trainer;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
    public void TrainerViewMainWindow(object sender, RoutedEventArgs args)
    {
        trainerViewMainWindow.Text = "Button clicked!";
    }
}