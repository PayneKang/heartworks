using System;  
using System.Collections.Generic;  
using System.Linq;  
using System.Text;  
using Microsoft.Xna.Framework;  
using Microsoft.Xna.Framework.Graphics;  
using Microsoft.Xna.Framework.Input;
namespace HeartWorks  

 {  
     public class Camera2D  
     {  
         #region Fields  
    
         protected float zoom;  
         protected Matrix transform;  
         protected Matrix inverseTransform;  
         protected Vector2 pos;  
         protected float rotation;  
         protected Viewport viewport;  
         protected MouseState mState;  
         protected KeyboardState keyState;  
         protected Int32 scroll;
         protected const float moveAmount =4f;
         protected Vector2 correctPos = new Vector2(4480, 2520);
         protected const int minX = 0;
         protected const int minY = 0;
         protected const int maxX = 2024;
         protected const int maxY = 1480;
        #endregion  
   
         #region Properties  
    
         public float Zoom  
         {  
             get { return zoom; }  
             set { zoom = value; }  
         }  
         /// <summary>  
         /// /// Camera View Matrix Property  
        /// </summary>  
         public Matrix Transform  
         {  
             get { return transform; }  
             set { transform = value; }  
         }  
         /// <summary>  
         /// Inverse of the view matrix, can be used to get objects screen coordinates  
         /// from its object coordinates  
         /// </summary>  
         public Matrix InverseTransform  
         {  
             get { return inverseTransform; }  
         }  
         public Vector2 Pos  
         {  
             get { return pos; }  
             set { pos = value; }  
        }  
         public float Rotation  
         {  
             get { return rotation; }  
             set { rotation = value; }  
         }      
        #endregion  
    
         #region Constructor  
    
         public Camera2D(Viewport viewport)  
         {  
             zoom = 1.0f;  
             scroll = 1;  
             rotation = 0.0f;
             //Player tank=new Player();
             //pos = tank.Position -correctPos;  
             //viewport = viewport;  
         }  
    
        #endregion  
   
         #region Methods  
   
         /// <summary>  
         /// Update the camera view  
         /// </summary>  
        public void Update(Player pl)  
         {  
             //Call Camera Input
            Input(pl);
             //_pos = tank.Position;  
             //Clamp zoom value  
             zoom = MathHelper.Clamp(zoom, 0.0f, 10.0f);  
              
            //Create view matrix  
             transform =    Matrix.CreateRotationZ(rotation) *   
                             Matrix.CreateScale(new Vector3(zoom, zoom, 1)) *   
                             Matrix.CreateTranslation(pos.X,pos.Y, 0);  
             //Update inverse matrix  
             inverseTransform = Matrix.Invert(transform);  
         }

         /// <summary>  
         /// Example Input Method, rotates using cursor keys and zooms using mouse wheel  
         /// </summary> 
          
       protected virtual void Input(Player pl)  
         {  
            
            keyState = Keyboard.GetState();  
              //Check Move  
             
              if (keyState.IsKeyDown(Keys.Up))  
              {
                 
                 pos.Y+= 5;
                  
              }  
             if (keyState.IsKeyDown(Keys.Down))
             {
                 pos.Y -= 5;
             }
             if (keyState.IsKeyDown(Keys.Left))
             {

                 pos.X += 5;

             }
             if (keyState.IsKeyDown(Keys.Right))
             {
                 pos.X -= 5;
             }
         } 

   
         #endregion  
    }  
 } 
