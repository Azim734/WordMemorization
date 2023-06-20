using System.Windows;
using System.Windows.Input;

namespace WordMemorization.Windows;

public partial class RegisterWindow : Window
{
    public RegisterWindow()
    {
        InitializeComponent();
    }

    private void Border_MouseDown(object sender, MouseButtonEventArgs e)
    {
        if ( e.ChangedButton == MouseButton.Left)
        {
            this.DragMove();
        }
    }
}
