﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Beeautiful2
{
    class Enemy : Sprite
    {
        const string ENEMY_ASSETNAME = "enemy";
        const int START_POSITION_X = -100;
        const int START_POSITION_Y = -100;
        const int ENEMY_SPEED = 160;
        const int MOVE_UP = -1;
        const int MOVE_DOWN = 1;
        const int MOVE_LEFT = -1;
        const int MOVE_RIGHT = 1;

        enum State
        {
            Alive,
            Dead
        }

        State mCurrentState = State.Alive;
        Vector2 mDirection = Vector2.Zero;
        Vector2 mSpeed = Vector2.Zero;
        KeyboardState mPreviousKeyboardState;



        public void LoadContent(ContentManager theContentManager)
        {
            Position = new Vector2(START_POSITION_X, START_POSITION_Y);
            base.LoadContent(theContentManager, ENEMY_ASSETNAME);

        }



        public void Update(GameTime theGameTime)
        {
            KeyboardState aCurrentKeyboardState = Keyboard.GetState();
            UpdateMovement(aCurrentKeyboardState);
            mPreviousKeyboardState = aCurrentKeyboardState;
            base.Update(theGameTime, mSpeed, mDirection);
        }




        private void UpdateMovement(KeyboardState aCurrentKeyboardState)
        {
            if (mCurrentState == State.Alive)
            {
                mSpeed = Vector2.Zero;
                mDirection = Vector2.Zero;
                /*if (aCurrentKeyboardState.IsKeyDown(Keys.Left) == true)
                {
                    mSpeed.X = ENEMY_SPEED;
                    mDirection.X = MOVE_LEFT;
                }

                else if (aCurrentKeyboardState.IsKeyDown(Keys.Right) == true)
                {
                    mSpeed.X = ENEMY_SPEED;
                    mDirection.X = MOVE_RIGHT;
                }



                if (aCurrentKeyboardState.IsKeyDown(Keys.Up) == true)
                {
                    mSpeed.Y = ENEMY_SPEED;
                    mDirection.Y = MOVE_UP;
                }

                else if (aCurrentKeyboardState.IsKeyDown(Keys.Down) == true)
                {
                    mSpeed.Y = ENEMY_SPEED;
                    mDirection.Y = MOVE_DOWN;
                }*/

            }

        }


    }
}