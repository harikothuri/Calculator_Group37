namespace Calculator;

public partial class App : Application
{
    public App()
    {

        InitializeComponent();

        MainPage = new AppShell();
        About = new AppShell();
        _ = Calculator.CreateConnection();
        _ = Calculator.LoadContent();
    }

    public AppShell About { get; }
}
