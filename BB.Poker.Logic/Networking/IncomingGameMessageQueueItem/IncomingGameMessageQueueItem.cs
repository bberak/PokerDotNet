﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BB.Poker.Common;

namespace BB.Poker.Logic
{
    public class IncomingGameMessageQueueItem : GameMessageQueueItem
    {
        public RouteInfo RouteInfo { get; set; }
    }
}
