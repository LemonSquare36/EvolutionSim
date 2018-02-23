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
        private Texture2D grass_tile;
        private Vector2 grassPos;

        private const int tileSize = 32;    //this remains the same as the grass tile sizes are 32x32 px
        private const int ChunkSize = 512;  //this is 32(tile size)x16, 16x16 tiles = 1 chunk.

        private int worldSizeX = 5;        //This is what you can edit
        private int worldSizeY = 3;        //this too.

        private int originX = 0;         //This is where the world drawing begins from
        private int originY = 0;

        private int tileOriginX;           //These two values are used to store tile data of their positions
        private int tileOriginY;                

        public void loadTextures()
        {
            grass_tile = Main.GameContent.Load<Texture2D>("Sprites/Grass_Tile");
        }

        public void GenerateTiles()
        {
            tileOriginX = originX;
            tileOriginY = originY;
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
                            spriteBatch.Draw(grass_tile, grassPos, Color.White);
                        }
                    }
                    tileOriginX += ChunkSize;
                }
                tileOriginX = originX;
                tileOriginY += ChunkSize;
            }
            tileOriginX = originX;
            tileOriginY = originY;
        }
    }
}
