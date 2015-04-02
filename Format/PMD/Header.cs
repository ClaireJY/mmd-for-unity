﻿using UnityEngine;
using System.Collections;

namespace MMD
{
    namespace Format
    {
        namespace PMD
        {
            public class Header : Chunk
            {
                public string magic;
                public float version;
                public string modelName;
                public string comment;
            }
        }
    }
}