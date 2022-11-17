using Microsoft.Maui.Controls;
using System.Collections.ObjectModel;

namespace Calculator;

//[QueryProperty(nameof(HistoryItems), "Items")]
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
        //collectionView.ItemsSource = await _dataService.GetAllToDosAsync();
        //ListViewItems.ItemsSource = Calculator.historyItems;
    }
    //private void ContentPage_NavigatedTo(object sender, NavigatedToEventArgs e)
    //{
    //    LoadData();
    //}
}