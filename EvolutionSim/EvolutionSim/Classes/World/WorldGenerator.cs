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
    public class WorldGenerator
    {
        private Texture2D grass;
        private Vector2 grassPos;

        public void loadTextures()
        {
            grass = Main.GameContent.Load<Texture2D>("Sprites/GrassLand");
        }

        public void GenerateTiles()
        {

        }

        public void RenderTiles(SpriteBatch spriteBatch)
        {

            for (int _x = 0; _x < 256; _x++)
            {
                for (int _y = 0; _y < 256; _y++)
                {
                    grassPos = new Vector2(_x, _y);

                    spriteBatch.Draw(grass, grassPos, Color.White);
                }
            }
        }
    }
}
