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
        WorldGenerator worldGen = new WorldGenerator();

        public MainArea()
        {

        }
        public override void Initialize()
        {
            worldGen.GenerateTiles();
        }

        public override void LoadContent()
        {
            
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
