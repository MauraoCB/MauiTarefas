using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiTarefas.Pages;
using System.Collections.ObjectModel;


namespace MauiTarefas.ViewModels
{
    public partial class DetalhesPageViewModel: ObservableObject
    {
        [ObservableProperty]
        string text;

        [RelayCommand]
        async Task GoBack()
        {
            await Shell.Current.GoToAsync("..");
        }

        [RelayCommand]
        async Task GoContato()
        {
            await Shell.Current.GoToAsync(nameof(ContatosPage));
        }
    }
}
