﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CaveStory
{
    public struct CollisionInfo
    {
        public GameUnit position;
        public BitArray tileType;

        public CollisionInfo(GameUnit position, BitArray tileType)
        {
            this.position = position;
            this.tileType = tileType;
        }
    }
}
