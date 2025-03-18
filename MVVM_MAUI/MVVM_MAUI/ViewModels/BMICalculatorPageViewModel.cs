using CommunityToolkit.Mvvm.ComponentModel;

namespace MVVM_MAUI.ViewModels;

public partial class BMICalculatorPageViewModel : ObservableObject
{
    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(BMIScore), nameof(BMIResult))]
    public double _height;

    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(BMIScore), nameof(BMIResult))]
    public double _weight;

    public double BMIScore => Math.Round(Weight / Math.Pow(Height / 100, 2), 2);

    public string BMIResult
    {
        get
        {
            return BMIScore switch
            {
                < 18.5 => "Underweight",
                < 25 => "Healthy",
                < 30 => "Overweight" ,
                _ => "Obese"
            };
        }
    }
}
