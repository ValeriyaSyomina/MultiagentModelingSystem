﻿using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SceneRendering
{
    public interface IScene
    {
        List<DrawableEntity> Objects { get; }
    }
}
