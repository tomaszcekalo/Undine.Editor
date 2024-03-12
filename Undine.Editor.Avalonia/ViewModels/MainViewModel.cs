using Microsoft.Xna.Framework;
using MonoGame.DesktopGL;
using Undine.Core;
using Undine.MinEcs;
using Undine.MonoGame;
using Undine.MonoGame.Primitives2D;

namespace Undine.Editor.Avalonia.ViewModels;

public class MainViewModel : ViewModelBase
{

    public string Greeting => "Welcome to Avalonia!";
    public Game CurrentGame { get; set; } 
    public EcsContainer EcsContainer { get; set; }
    public MainViewModel()
    {
        EcsContainer = new MinEcsContainer();
        CurrentGame = new Game1(EcsContainer);
    }
}
