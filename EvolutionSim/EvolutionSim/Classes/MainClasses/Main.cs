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
        Camera camera;
        KeyboardState key;

        ScreenManager CurrentScreen;
        MainMenu Menu;
        MainArea GameZone;

        //Allows other classes to load code from content manager - Convient
        private static ContentManager content;
        public static ContentManager GameContent
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
            //Screen Creation
            CurrentScreen = new ScreenManager();
            Menu = new MainMenu();
            GameZone = new MainArea();
            //Camera Creation and base Window Size
            camera = new Camera();
            graphics.PreferredBackBufferHeight = 1080;
            graphics.PreferredBackBufferWidth = 1920;
            graphics.ApplyChanges();
        }


        protected override void Initialize()
        {
            //Spritebatch Creation
            spriteBatch = new SpriteBatch(GraphicsDevice);

            //Screen Intiialized at start of Main Initalization
            CurrentScreen = GameZone;
            GameZone.getSpriteBatch(spriteBatch);
            CurrentScreen.Initialize();
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
            //Keyboard State updated with the game
            key = Keyboard.GetState();
            //Camera Move Command
            camera.Move(key);
            //fullscreen command set to O
            if (key.IsKeyDown(Keys.O))
            {
                camera.ChangeScreenSize(graphics);
            }

            base.Update(gameTime);
        }


        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            //The matrix the game is drawn to
            var viewMatrix = camera.Transform(GraphicsDevice);

            //Spritebatch begin command called on the outside of commands to minimize its calls. Uses viewmatrix to draw the screen
            spriteBatch.Begin(SpriteSortMode.Deferred, BlendState.NonPremultiplied, null, null, null, null, viewMatrix * Matrix.CreateScale(1));

            //Draw Things here
            CurrentScreen.Draw(spriteBatch);

            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
