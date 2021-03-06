﻿using DRA_PLUGIN.Handlers;
using Smod2;
using Smod2.API;
using Smod2.Attributes;
using Smod2.Config;
using Smod2.EventHandlers;
using Smod2.Events;
using Smod2.Lang;
using System.Threading;

namespace DRA_PLUGIN
{
    [PluginDetails(
        author = "Kade",
        name = "Desktop Remote Admin",
        description = "A Desktop version of Remote Admin.",
        id = "kade.dra",
        version = "2.0",
        SmodMajor = 3,
        SmodMinor = 4,
        SmodRevision = 0
        )]
    public class DesktopRemoteAdmin : Plugin
    {
        public override void OnDisable()
        {
            Info("Ended Service...");
        }

        public override void OnEnable()
        {
                Info("\n---------------\nD E S K T O P  R E M O T E  A D M I N\nCreated by Kade#6969\nThe best Desktop Tool for remote adminstration!\n---------------");
        }

        public override void Register()
        {
            // Configs
            AddConfig(new ConfigSetting("dra_password", "notSet", true, "The password used to login to the UI."));
            AddConfig(new ConfigSetting("dra_status", true, true, "Set it to false to disable to plugin"));
            AddConfig(new ConfigSetting("dra_port", 7790, true, "The port for it to connect."));
            AddConfig(new ConfigSetting("dra_logs", false, true, "How much logs are annoying (true = hella annoying)"));
            // Events
            AddEventHandlers(new RoundEvent(this));
            Info("Waiting for WaitingForPlayers Scene to start the server...");
        }
    }
}
