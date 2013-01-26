using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Audio;

namespace HeartWorks
{
    class PipeT1:Sprite
    {
        public Texture2D image;

        public bool LoadContent(ContentManager Content, string filename)
        {
            image = Content.Load<Texture2D>(filename);
            image_loaded = true;
            size.X = image.Width;
            size.Y = image.Height;
            /* pipeMove = Content.Load<SoundEffect>("pipeMove");
            pipeMoveInst = pipeMove.CreateInstance(); */
            return true;
        }
    }
}
