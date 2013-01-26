using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Audio;

namespace HeartWorks
{
    public class Player : Sprite
    {
        #region Fields
        public Vector2 velocity;
        protected Texture2D tank;
        private Vector2 origin;
        public float gunAngle;
        private Vector2 gunOrigin;
        private SpriteEffects spritEf;
        private const int textSize = 128;
        private const int gunOrigSizeX = 32;
        private const int gunOrigSizeY = 32;
        private const int bodyOrigSize = 64;
        private int playerTimer = 0;
        private bool playerAllowFire = false;
        MouseState oldms;
        public int Health, Life;
        public Rectangle box;
        public bool alive;
        public Vector2 Position;
        public int score;
        Vector2 direction;
        public Vector2 mousePos;
        #endregion
        public Player()
        {
            int posX = 100;
            int posY = 100;
            Position = new Vector2(posX, posY);
            box = new Rectangle(posX, posY, textSize, textSize);
            alive = true;
            origin.X = bodyOrigSize;
            origin.Y = bodyOrigSize;
            gunOrigin = new Vector2(gunOrigSizeX, gunOrigSizeY);
            Health = 100;
            Life = 3;
            score = 0;
        }
        public void LoadContent(ContentManager theContentManager, string theAssetName)
        {
            tank = theContentManager.Load<Texture2D>(theAssetName);
            //tankFire = theContentManager.Load<SoundEffect>("tankfire");

        }
        public void Update(GameTime gameTime)
        {

#if WINDOWS
            if (Keyboard.GetState().IsKeyDown(Keys.Left) || Keyboard.GetState().IsKeyDown(Keys.A))
#elif XBOX
            if ((GamePad.GetState().IsButtonDown(Buttons.LeftThumbstickLeft) || (GamePad.GetState().IsButtonDown(Buttons.DPadLeft))
#endif
            {
                //RotationAngle-=0.1f;
                Position.X -= 5;
            }
#if WINDOWS
            if (Keyboard.GetState().IsKeyDown(Keys.Right) || Keyboard.GetState().IsKeyDown(Keys.D))
#elif XBOX
            if ((GamePad.GetState().IsButtonDown(Buttons.LeftThumbstickRight) || (GamePad.GetState().IsButtonDown(Buttons.DPadRight))
#endif
            {
                //RotationAngle-=0.1f;
                Position.X += 5;
            }
#if WINDOWS
            if (Keyboard.GetState().IsKeyDown(Keys.Down) || Keyboard.GetState().IsKeyDown(Keys.S))
#elif XBOX
            if ((GamePad.GetState().IsButtonDown(Buttons.LeftThumbstickDown) || (GamePad.GetState().IsButtonDown(Buttons.DPadDown))
#endif
            {
                //RotationAngle-=0.1f;
                Position.Y += 5;
            }
#if WINDOWS
            if (Keyboard.GetState().IsKeyDown(Keys.Up) || Keyboard.GetState().IsKeyDown(Keys.W))
#elif XBOX
            if ((GamePad.GetState().IsButtonDown(Buttons.LeftThumbstickUp) || (GamePad.GetState().IsButtonDown(Buttons.DPadUp))
#endif
            {
                //RotationAngle-=0.1f;
                Position.Y -= 5;
            }

        }
        public void Draw(SpriteBatch theSpriteBatch, Color color)
        {
            if (alive)
                theSpriteBatch.Draw(tank, Position, null, color, gunAngle,
                                  origin, 1f, spritEf, 0f);
        }
    }
}
