using Microsoft.Xna.Framework;
using MonoGame.DesktopGL;

namespace Undine.Editor.Avalonia.ViewModels;

public class MainViewModel : ViewModelBase
{
    public string Greeting => "Welcome to Avalonia!";
    public Game CurrentGame { get; set; } = new Game1();
}
