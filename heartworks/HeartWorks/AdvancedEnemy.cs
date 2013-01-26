using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Audio;

namespace HeartWorks
{
    class AdvancedEnemy:Sprite
    {
        public Vector2 velocity;
        private const int textSize = 128;
        private const int gunOrigSizeX = 32;
        private const int gunOrigSizeY = 32;
        private const int bodyOrigSize = 64;
        private Vector2 origin;
        private Vector2 gunOrigin;
        public int Health, Life;

        public AdvancedEnemy()
        {
            int posX = 175;
            int posY = 175;
            Position = new Vector2(posX, posY);
            box = new Rectangle(posX, posY, textSize, textSize);
            alive = true;
            origin.X = bodyOrigSize;
            origin.Y = bodyOrigSize;
            gunOrigin = new Vector2(gunOrigSizeX, gunOrigSizeY);
            Health = 100;
            Life = 1;
        }

        public AdvancedEnemy(int posX, int posY)
        {
            this.posX = posX;
            this.posY = posY;
            Position = new Vector2(posX, posY);
            box = new Rectangle(posX, posY, textSize, textSize);
            alive = true;
            origin.X = bodyOrigSize;
            origin.Y = bodyOrigSize;
            gunOrigin = new Vector2(gunOrigSizeX, gunOrigSizeY);
            Health = 100;
            Life = 1;
        }


        public int posY { get; set; }

        public int posX { get; set; }
    }
}
