namespace Calculator;

public partial class Menu : ContentPage
{
    public Menu()
    {
        InitializeComponent();
    }

    void ChangeToLight(object sender, EventArgs e)
    {
        DoWork(Theme.Light);
    }


    void ChangeToGreen(object sender, EventArgs e)
    {
        DoWork(Theme.Green);
    }

    void ChangeToPink(object sender, EventArgs e)
    {
        DoWork(Theme.Pink);
    }

    private void ChangeToDark(object sender, EventArgs e)
    {
        DoWork(Theme.Dark);
    }
    private void DoWork(Theme theme)
    {
        ICollection<ResourceDictionary> mergedDictionaries = Application.Current.Resources.MergedDictionaries;
        if (mergedDictionaries != null)
        {
            mergedDictionaries.Clear();
            switch (theme)
            {
                case Theme.Dark:
                    mergedDictionaries.Add(new Dark());
                    break;
                case Theme.Light:
                    mergedDictionaries.Add(new Light());
                    break;
                case Theme.Pink:
                    mergedDictionaries.Add(new Pink());
                    break;
                case Theme.Green:
                    mergedDictionaries.Add(new Green());
                    break;
            }
        }
    }
}