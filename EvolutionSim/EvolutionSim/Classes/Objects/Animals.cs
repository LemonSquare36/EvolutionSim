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
    class Animals : Entity
    {
        int points = 10;


        public Animals(Point Location)
        {
            Hitbox = new Rectangle(Location, new Point(16, 16));
        }
        public override void Initialize()
        {

        }

        public override void LoadContent()
        {
            texture = Main.GameContent.Load<Texture2D>("Sprites/Creature");
        }

        public override void Update()
        {

        }

        public override void Draw(SpriteBatch spritebatch)
        {
            
        }
    }
}
