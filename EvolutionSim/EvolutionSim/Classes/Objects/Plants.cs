using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace EvolutionSim
{
    class Plants : Entity
    {
        private Texture2D plant_tile;
        private Vector2 plant_pos;

        WorldGenerator worldGenInfo;

        private int X_LEFT;
        private int Y_UP;

        private int X_RIGHT;
        private int Y_DOWN;

        public Plants()
        {
            tag = "plant";
            int food;
        }
        public override void Initialize()
        {
            X_LEFT = worldGenInfo.originX; //TODO
            Y_UP = worldGenInfo.originY; //Yes idealy, I should use getters and setters here.

            X_RIGHT = worldGenInfo.worldSizeX * worldGenInfo.ChunkSize;
            Y_DOWN = worldGenInfo.worldSizeY * worldGenInfo.ChunkSize;
        }

        public override void LoadContent()
        {
            plant_tile = Main.GameContent.Load<Texture2D>("Sprites/Plant_Grass");
        }

        public override void Update()
        {
            
        }

        public override void Draw(SpriteBatch spriteBatch)          //TODO this doesnt get called?
        {
            for (int i = 0; i < 10; i++)                                
            {
                plant_pos = new Vector2(1024,i);
                spriteBatch.Draw(plant_tile, plant_pos, Color.White); //This is here for testing
            }                                                         //Im trying to generate plants
        }                                                             //within the world bounds eventually
    }
}
