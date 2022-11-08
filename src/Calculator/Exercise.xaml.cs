using Calculator.Exercise;
using System.Diagnostics.Metrics;
using System.Net.Http.Headers;
namespace Calculator;

public partial class Exercise1 : ContentPage
{
    List<ExerciseDTO> _exercises;
    int counter = 0;
    int correctAnswers = 0;
    public Exercise1()
    {
        InitializeComponent();
        FetchContent();
    }

    private void FetchContent()
    {
        var apiUrl = "https://localhost:7115/Exercises";
        correctAnswers = 0;
        _exercises = GetExercises(apiUrl);
    }
}