﻿using Undine.Editor.MonogameWpf.MonoGameControls;

namespace Undine.Editor.MonogameWpf
{
    public class MainWindowViewModel : MonoGameViewModel
    {
        private SpriteBatch _spriteBatch;
        private Texture2D _texture;
        private Vector2 _position;
        private float _rotation;
        private Vector2 _origin;
        private Vector2 _scale;

        public override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            _texture = Content.Load<Texture2D>("monogame-logo");
        }

        public override void Update(GameTime gameTime)
        {
            _position = GraphicsDevice.Viewport.Bounds.Center.ToVector2();
            _rotation = (float)Math.Sin(gameTime.TotalGameTime.TotalSeconds) / 4f;
            _origin = _texture.Bounds.Center.ToVector2();
            _scale = Vector2.One;
        }

        public override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            _spriteBatch.Begin();
            _spriteBatch.Draw(_texture, _position, null, Color.White, _rotation, _origin, _scale, SpriteEffects.None, 0f);
            _spriteBatch.End();
        }
    }
}