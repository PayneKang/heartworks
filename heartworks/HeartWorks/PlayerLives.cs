using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace HeartWorks
{
    class PlayerLives:Sprite
    {
        public PlayerLives(float posX,float posY)
        {
            Position = new Vector2(posX, posY);
        }
    }
}
