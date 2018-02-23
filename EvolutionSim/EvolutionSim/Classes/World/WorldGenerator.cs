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

        private const int tileSize = 32;
        private const int ChunkSize = 512;

        private int worldSizeX = 2; //This is what you can edit
        private int worldSizeY = 2; //this too.

        private int tileOriginX = 0;
        private int tileOriginY = 0;

        public void loadTextures()
        {
            grass = Main.GameContent.Load<Texture2D>("Sprites/GrassLand");
        }

        public void GenerateTiles()
        {

        }

        public void RenderTiles(SpriteBatch spriteBatch)
        {
            for (int WY = 0; WY < worldSizeY; WY++)
            {
                for (int WX = 0; WX < worldSizeX; WX++)
                {
                    for (int _x = tileOriginX; _x < tileOriginX + ChunkSize; _x += tileSize)
                    {
                        for (int _y = tileOriginY; _y < tileOriginY + ChunkSize; _y += tileSize)
                        {
                            grassPos = new Vector2(_x, _y);
                            spriteBatch.Draw(grass, grassPos, Color.White);
                            //System.Diagnostics.Debug.WriteLine("debug");
                        }
                    }
                    tileOriginX += ChunkSize;
                }
                tileOriginX = 0;
                tileOriginY += ChunkSize;
            }
            tileOriginX = 0;
            tileOriginY = 0;
        }
    }
}
