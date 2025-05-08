using aylocks.Content.Items.Materials;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.UI;

namespace aylocks.Content.Items.Weapons
{
    public class Siymar : ModItem
    {
        public override void SetStaticDefaults()
        {
            Item.ToolTip = ItemTooltip.FromLanguageKey("It smells really bad.");
        }

        public override void SetDefaults()
        {
            Item.CloneDefaults(ItemID.BatBat);
            Item.damage = 40;
            Item.useTime = 6;
            Item.width = 50;
            Item.height = 50;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.Flymeal)
                .AddIngredient(ItemID.TentacleSpike)
                .AddIngredient(ItemID.ZombieArm)
                .AddIngredient(ItemID.BatBat)
                .AddIngredient(ItemID.AntlionMandible)
                .AddIngredient(ModContent.ItemType<SoulOfMite>(), 35)
                .Register();
        }

        public override void OnHitNPC(Player player, Terraria.NPC target, Terraria.NPC.HitInfo hit, int damageDone)
        {
            target.AddBuff(BuffID.Stinky, 60 * 100);
            target.AddBuff(BuffID.BloodButcherer, 60 * 5);
            target.AddBuff(BuffID.Slow, 60 * 5);
            if (damageDone >= 80)
            {
                player.AddBuff(BuffID.Swiftness, 60 * 3);
            }
        }
    }
}
