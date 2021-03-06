using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace Bluemagic.Items.ChaosSpirit
{
    public class CataclysmCrystal : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Grants one cataclysm point");
            Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(5, 4));
        }

        public override void SetDefaults()
        {
            item.width = 28;
            item.height = 28;
            item.maxStack = 99;
            item.rare = 11;
            item.expert = true;
            item.value = Item.sellPrice(2, 0, 0, 0);
            item.consumable = true;
            item.useStyle = 4;
            item.useTime = 30;
            item.useAnimation = 30;
            item.UseSound = SoundID.Item29;
        }

        public override bool CanUseItem(Player player)
        {
            CustomStats stats = player.GetModPlayer<BluemagicPlayer>().cataclysmStats;
            return stats.CanUpgrade();
        }

        public override bool UseItem(Player player)
        {
            CustomStats stats = player.GetModPlayer<BluemagicPlayer>().cataclysmStats;
            stats.Points++;
            return true;
        }

        public override Color? GetAlpha(Color lightColor)
        {
            return Color.White;
        }
    }
}