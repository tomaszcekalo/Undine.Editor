using Avalonia.Controls;
using Avalonia.Interactivity;
using Undine.Editor.Avalonia.ViewModels;
using Undine.MonoGame.Primitives2D;
using Undine.MonoGame;
using Microsoft.Xna.Framework;

namespace Undine.Editor.Avalonia.Views;

public partial class MainView : UserControl
{
    public MainView()
    {
        InitializeComponent();
    }

    private void Button_Click(object? sender, RoutedEventArgs e)
    {
        var viewModel = DataContext as MainViewModel;
        var container = viewModel?.EcsContainer;
        var entity = container?.CreateNewEntity();
        entity?.AddComponent(new TransformComponent { Position = new Vector2(100, 100) });
        entity?.AddComponent(new Primitives2DComponent
        {
            Color = Color.Red,
            Size = new Vector2(100, 100),
            DrawType = Primitives2DDrawType.FillRectangle
        });
    }
}