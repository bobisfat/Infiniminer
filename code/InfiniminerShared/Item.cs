using System;
using System.Collections.Generic;
using System.Text;
using Lidgren.Network;
using Lidgren.Network.Xna;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using Microsoft.Xna.Framework.Net;
using Microsoft.Xna.Framework.Storage;

namespace Infiniminer
{
    public class Item
    {
        public uint ID;
        public PlayerTeam Team;
        public Vector3 Heading;
        public Vector3 Position;
        public Vector3 Velocity = Vector3.Zero;
        public Vector3 deltaPosition;
        public ItemType Type;
        public DateTime Frozen;//frozen until greater than this time

        public bool QueueAnimationBreak = false;

        // Things that affect animation.
        public SpriteModel SpriteModel;
        private Game gameInstance;

        public Item(Game gameInstance, ItemType iType)
        {
            Frozen = DateTime.Now;

            Type = iType;
            this.gameInstance = gameInstance;
            if (gameInstance != null)
            {
                this.SpriteModel = new SpriteModel(gameInstance, 4);
                UpdateSpriteTexture();
                this.IdleAnimation = true;
            }
        }

        private bool idleAnimation = false;
        public bool IdleAnimation
        {
            get { return idleAnimation; }
            set
            {
                if (idleAnimation != value)
                {
                    idleAnimation = value;
                    if (gameInstance != null)
                    {
                        if (idleAnimation)
                            SpriteModel.SetPassiveAnimation("1,0.2");
                        else
                            SpriteModel.SetPassiveAnimation("0,0.2;1,0.2;2,0.2;1,0.2");
                    }
                }
            }
        }

        private void UpdateSpriteTexture()
        {
            if (gameInstance == null)
                return;

            string textureName = "";

            switch(Type)
            {
                case ItemType.Gold:
                    textureName = "sprites/tex_sprite_lemonorgoldnum";
                    break;
                case ItemType.Ore:
                    textureName = "sprites/tex_sprite_lemonorgoldnum";
                    break;
                default:
                    textureName = "sprites/tex_sprite_lemonorgoldnum";
                    break;
            }
            
            Texture2D orig = gameInstance.Content.Load<Texture2D>(textureName);
           
            this.SpriteModel.SetSpriteTexture(orig);
        }
    }
}