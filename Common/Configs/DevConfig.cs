﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader.Config;

namespace TerrariaCells.Common.Configs
{
    public class DevConfig : ModConfig
    {
        //[Newtonsoft.Json.JsonIgnore]
        private static DevConfig _instance;
        //[Newtonsoft.Json.JsonIgnore]
        public static DevConfig Instance => _instance ??= Terraria.ModLoader.ModContent.GetInstance<DevConfig>();

        public override ConfigScope Mode => ConfigScope.ServerSide;

        [Header("BuilderSettings")]

		///<summary>Toggle ability to build. Also allows tiles to be interacted with normally.</summary>
		[DefaultValue(false)]
        public bool BuilderMode;

		/// <summary>Prevents tile damage from explosives.</summary>
		[DefaultValue(true)]
        public bool PreventExplosionDamage;

		/// <summary>Toggles intended Pylon mechanics.</summary>
		[DefaultValue(true)]
        public bool DoPylonDiscoveries;

		[Header("InventorySettings")]

		/// <summary>Effectively controls whether this mod affects the interface.</summary>
		[DefaultValue(true)]
		public bool EnableInventoryChanges;

		/// <summary>Since the default inventory is used and manipulated in this mod, you can disable that behaviour here if you wish.</summary>
		[DefaultValue(true)]
		public bool EnableInventoryLock;

		/// <summary>
		/// Disables the interfaces that show the inventory.
		/// <para>Note that this disables the functionality of the visible inventory as well.</para>
		/// </summary>
		[DefaultValue(true)]
		public bool HideVanillaInventory;
	}
}
