using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace monogame_topic2
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        Texture2D circleTexture;
        Texture2D rectangleTexture;
        Texture2D birdTexture;
        SpriteFont text;
        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            _graphics.PreferredBackBufferWidth = 600;
            _graphics.PreferredBackBufferHeight = 500;
            _graphics.ApplyChanges();
            this.Window.Title = "bird";
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            circleTexture = Content.Load<Texture2D>("circle");
            rectangleTexture = Content.Load<Texture2D>("rectangle");
            birdTexture = Content.Load<Texture2D>("tree.png");
            text = Content.Load<SpriteFont>("text");
            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();
            _spriteBatch.Draw(rectangleTexture, new Rectangle(0, 400, 600, 100), Color.Green);
            _spriteBatch.Draw(rectangleTexture, new Rectangle(275, 200, 50, 200), Color.Chocolate);
            _spriteBatch.Draw(circleTexture, new Rectangle(176, 120, 250, 170), Color.Green);
            _spriteBatch.Draw(birdTexture, new Rectangle(200, 100, 50, 50), Color.White);
            _spriteBatch.DrawString(text, "bird", new Vector2(269, 170), Color.Black);
            _spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}