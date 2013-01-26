using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Audio;

namespace HeartWorks
{
    class Cog:Sprite
    {
        public Texture2D image;

        public bool LoadContent(ContentManager Content, string filename)
        {
            image = Content.Load<Texture2D>(filename);
            image_loaded = true;
            size.X = image.Width;
            size.Y = image.Height;
            /* cogMove = Content.Load<SoundEffect>("cogMove");
             cogMoveInst = cogMove.CreateInstance(); */
            return true;
        }
    }
}
