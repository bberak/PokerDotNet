﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BB.Poker.GatewayServer.Properties;

namespace BB.Poker.GatewayServer
{
    public class Program
    {
        static void Main(string[] args)
        {
            Application.Run(new GatewayServerUIShell());
            return;
        }
    }
}
