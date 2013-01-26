using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace HeartWorks
{
    /// <summary>

    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        ExtendedSpriteBatch sb;
        Player player;
        PlayerLives plLives;
        Sprite minimap, bgTL, bgTR, bgBL, bgBR;
        PipeT1[] pipeT1;
        PipeT2[] pipeT2;
        PipeT3[] pipeT3;
        PipeT4[] pipeT4;
        Cog[] cogs;
        Camera2D cam;
        Viewport viewport;
        Song song;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            player=new Player();
            plLives = new PlayerLives();
            minimap = new Sprite();
            bgTL = new Sprite();
            bgTR = new Sprite();
            bgBL = new Sprite();
            bgBR = new Sprite();
            pipeT1 = new PipeT1[5];
            pipeT2 = new PipeT2[5];
            pipeT3 = new PipeT3[5];
            pipeT4 = new PipeT4[5];
            cogs = new Cog[12];
            MediaPlayer.IsVisualizationEnabled = true;

            int i = 0;
            for (i = 0; i < pipeT1.Length; i++)
            {
                pipeT1[i] = new PipeT1();
            }
            for (i = 0; i < pipeT2.Length; i++)
            {
                pipeT2[i] = new PipeT2();
            }
            for (i = 0; i < pipeT3.Length; i++)
            {
                pipeT3[i] = new PipeT3();
            }
            for (i = 0; i < pipeT4.Length; i++)
            {
                pipeT4[i] = new PipeT4();
            }

            for (i = 0; i < cogs.Length; i++)
            {
                cogs[i] = new Cog();
            }

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            sb = new ExtendedSpriteBatch(GraphicsDevice);
            viewport = graphics.GraphicsDevice.Viewport;
           // plLives.LoadContent(Content, "");
            player.LoadContent(Content, "dot");
            bgTL.LoadContent(Content, "bgTL");
            bgTR.LoadContent(Content, "bgTR");
            bgBL.LoadContent(Content, "bgBL");
            bgBR.LoadContent(Content, "bgBR");
            bgTL.Position = new Vector2(0, 0);
            bgTR.Position = new Vector2(1024, 0);
            bgBL.Position = new Vector2(0, 720);
            bgBR.Position = new Vector2(1024, 720);
            cam = new Camera2D(viewport);
            song = Content.Load<Song>("heartbeat");

            MediaPlayer.Play(song); 

            // TODO: use this.Content to load your game content here
        }
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            // Allows the game to exit
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();
            player.Update(gameTime);
            cam.Update(player);

            
            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            sb.Begin(SpriteSortMode.Deferred, BlendState.AlphaBlend, null, null, null, null, cam.Transform);
            bgTL.Draw(sb, Color.White);
            bgTR.Draw(sb, Color.White);
            bgBL.Draw(sb, Color.White);
            bgBR.Draw(sb, Color.White);
            player.Draw(sb, Color.White);
            sb.End();

            base.Draw(gameTime);
        }
    }
}
