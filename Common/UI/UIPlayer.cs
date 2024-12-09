﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using TerrariaCells.Common.GlobalItems;

namespace TerrariaCells.Common.UI
{
    public class UIPlayer : ModPlayer
    {
        public override void PostUpdate()
        {
            //toggle UI so that it only shows if the player is holding a weapon that uses it. Only set state if it needs to.
            if (WeaponHoldoutify.Guns.Contains(Player.HeldItem.type))
            {
                if (ModContent.GetInstance<UISystem>().ReloadInterface.CurrentState == null)
                {
                    ModContent.GetInstance<UISystem>().ShowReloadUI();
                }
                
            }
            else if (ModContent.GetInstance<UISystem>().ReloadInterface.CurrentState == ModContent.GetInstance<UISystem>().reloaderUI)
            {
                ModContent.GetInstance<UISystem>().HideReloadUI();
            }
        }
        
    }
}
