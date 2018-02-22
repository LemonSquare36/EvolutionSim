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

        public void GenerateTiles()
        {
            grassPos = new Vector2(0, 0);
            grass = Main.GameContent.Load<Texture2D>("Sprites/GrassLand");
        }
    }
}
