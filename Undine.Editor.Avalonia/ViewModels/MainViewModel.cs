using Microsoft.Xna.Framework;
using MonoGame.DesktopGL;
using Undine.MinEcs;

namespace Undine.Editor.Avalonia.ViewModels;

public class MainViewModel : ViewModelBase
{
    public string Greeting => "Welcome to Avalonia!";
    public Game CurrentGame { get; set; } = new Game1(new MinEcsContainer());
}
