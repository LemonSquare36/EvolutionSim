using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace EvolutionSim


{
    class MainArea : ScreenManager
    {

        private Texture2D grass;
        private Vector2 grassPos;

        public MainArea()
        {

        }
        public override void Initialize()
        {
            grassPos = new Vector2(0, 0);
        }

        public override void LoadContent()
        {
            grass = Main.GameContent.Load<Texture2D>("Sprites/GrassLand");
        }

        public override void Update()
        {

        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Begin();
            spriteBatch.Draw(grass, grassPos, Color.White);
            spriteBatch.End();
        }
    }
}
