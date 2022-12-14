using SQLite;
using SQLitePCL;

namespace Calculator;

public static class Calculator
{
    static SQLiteAsyncConnection Database = null;
    public static string DatabaseFilePath = Path.Combine("C:\\Share", "HistorySQLite1.db3");

    public static List<HistoryItem> historyItems = new List<HistoryItem>();

    public const SQLiteOpenFlags Flags =
                                        SQLiteOpenFlags.ReadWrite |
                                        SQLiteOpenFlags.Create |
                                        SQLiteOpenFlags.SharedCache;
    public static async Task CreateConnection()
    {
        if (Database is not null)
            return;

        Database = new SQLiteAsyncConnection(DatabaseFilePath, Flags);
        var result = await Database.CreateTableAsync<HistoryItem_DB>();
        var test = 10;
    }
    public static double Calculate(double value1, double value2, string mathOperator)
    {
        double result = 0;
        switch (mathOperator)
        {
            case "÷":
                result = value1 / value2;
                break;
            case "×":
                result = value1 * value2;
                break;
            case "+":
                result = value1 + value2;
                break;
            case "-":
                result = value1 - value2;
                break;
        }

        string question = value1.ToString() + mathOperator + value2.ToString();
        try
        {
            _ = SaveAndRetriveContentAsync(new HistoryItem_DB() { QuestionAnswer = question + " = " + result.ToString() });
        }
        catch (Exception ex)
        {
            var test = 12;
        }
        return result;
    }

    private static async Task SaveAndRetriveContentAsync(HistoryItem_DB historyItem)
    {
        await Database.InsertAsync(historyItem);
        await LoadContent();

    }
    public static async Task LoadContent()
    {
        var test = await Database.Table<HistoryItem_DB>().ToListAsync();
        historyItems.Clear();
        test.ForEach(x => historyItems.Add(new HistoryItem() { DateTime1 = x.DateTime1, QuestionAnswer = x.QuestionAnswer }));
    }
    public static async Task<int> DeletAll()
    {
        return await Database.DeleteAllAsync<HistoryItem_DB>();
    }
}

public static class DoubleExtensions
{
    public static string ToTrimmedString(this double target, string decimalFormat)
    {
        string strValue = target.ToString(decimalFormat); //Get the stock string

        //If there is a decimal point present
        if (strValue.Contains("."))
        {
            //Remove all trailing zeros
            strValue = strValue.TrimEnd('0');

            //If all we are left with is a decimal point
            if (strValue.EndsWith(".")) //then remove it
                strValue = strValue.TrimEnd('.');
        }

        return strValue;
    }
}
