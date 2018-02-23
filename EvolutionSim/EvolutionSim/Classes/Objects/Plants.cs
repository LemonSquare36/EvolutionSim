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

        private Texture2D plant_grass;

        public Plants()
        {
            tag = "plant";
            int food;
        }
        public override void Initialize()
        {

        }

        public override void LoadContent()
        {
            plant_grass = Main.GameContent.Load<Texture2D>("Sprites/Plant_Grass");
        }

        public override void Update()
        {

        }

        public override void Draw(SpriteBatch spritebatch)
        {

        }
    }
}
