namespace Calculator;

public partial class App : Application
{
    public App()
    {

        InitializeComponent();

        MainPage = new AppShell();
        About = new AppShell();
        _ = Calculator.CreateConnection();
    }

    public AppShell About { get; }
}
