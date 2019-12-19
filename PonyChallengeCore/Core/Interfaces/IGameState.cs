﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PonyChallengeCore.Core.Interfaces
{
    public interface IGameState
    {
        string MazeState { get; set; }
        string MoveStatus { get; set; }
        string HiddenUrl { get; set; }
    }
}
