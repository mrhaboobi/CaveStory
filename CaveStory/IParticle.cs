﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CaveStory
{
    public interface IParticle
    {
        bool Update(GameTime gameTime);
        void Draw(SpriteBatch spriteBatch);
    }
}
