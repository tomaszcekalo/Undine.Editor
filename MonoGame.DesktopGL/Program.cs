using Undine.MinEcs;

var minEcsContainer = new MinEcsContainer();
using var game = new MonoGame.DesktopGL.Game1(minEcsContainer);
game.Run();