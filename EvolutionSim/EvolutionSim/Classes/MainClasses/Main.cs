using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace EvolutionSim
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Main : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        ScreenManager CurrentScreen;
        MainMenu Menu;
        MainArea GameZone;

        //Allows other classes to load code from content manager - Convient
        private static ContentManager  content;
        public static  ContentManager GameContent
        {
            get { return content; }
            set { content = value; }
        }


        public Main()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";

            content = Content;
            IsMouseVisible = true;

            CurrentScreen = new ScreenManager();
            Menu = new MainMenu();
            GameZone = new MainArea();
        }


        protected override void Initialize()
        {
            CurrentScreen = GameZone;
            CurrentScreen.Initialize();
            spriteBatch = new SpriteBatch(GraphicsDevice);
            base.Initialize();
        }

        protected override void LoadContent()
        {
          
            CurrentScreen.LoadContent();

        }


        protected override void UnloadContent()
        {
            
        }

   
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            CurrentScreen.Update();

            base.Update(gameTime);
        }


        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            CurrentScreen.Draw(spriteBatch);

            base.Draw(gameTime);
        }
    }
}
