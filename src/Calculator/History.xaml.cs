using Microsoft.Maui.Controls;
using System.Collections.ObjectModel;

namespace Calculator;

public partial class History1 : ContentPage
{
    public ObservableCollection<HistoryItem> Items = new ObservableCollection<HistoryItem>();
    public History1()
    {
        InitializeComponent();
        LoadData();

    }

    private void LoadData()
    {
        Items.Clear();

        Calculator
            .historyItems
            .ForEach(x =>
                        Items.Add(x));
        ListViewItems.ItemsSource = Items;
    }

    protected async override void OnAppearing()
    {
        LoadData();
        base.OnAppearing();
    }

    private void Button_ClickedAsync(object sender, EventArgs e)
    {
        _ = Calculator.DeletAll();
        Items.Clear();
    }

}