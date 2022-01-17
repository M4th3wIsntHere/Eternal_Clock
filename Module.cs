using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Mod
{
    public class Module : ETGModule
    {
        public static readonly string MOD_NAME = "Eternal Clock on top of aged bell";
        public static readonly string VERSION = "1.0.0";
        public static readonly string TEXT_COLOR = "#00FFFF";

        public override void Start()
        {
            PlayerItem AgedBell = PickupObjectDatabase.GetById(237) as PlayerItem;
            AgedBell.SetName("Eternal Clock");
            AgedBell.SetShortDescription("Stop Time!");
            AgedBell.SetLongDescription("This clock appears to be made of different materials at different times. It contains the power of time control as it's user's wish, made and used by powerful ancient sorceresses.");
        }

        public static void Log(string text, string color="FFFFFF")
        {
            ETGModConsole.Log($"<color={color}>{text}</color>");
        }

        public override void Exit() { }
        public override void Init() { }
    }
}
