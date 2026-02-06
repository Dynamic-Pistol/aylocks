using aylocks.Content.Items.Materials;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Enums;
using Terraria.ID;
using Terraria.ModLoader;

namespace aylocks.Content.Items.Weapons
{
    public class RainGemStaff: ModItem
    {
        public override void SetStaticDefaults() {
            Item.staff[Type] = true;
        }

        public override void SetDefaults()
        {
            Item.DefaultToStaff(ModContent.ProjectileType<RainGemProjectile>(), 14, 14, 10);
                
            Item.SetWeaponValues(34, 7, 6);
            
            Item.SetShopValues(ItemRarityColor.LightRed4, 4_500_000);
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.AmethystStaff)
                .AddIngredient(ItemID.TopazStaff)
                .AddIngredient(ItemID.SapphireStaff)
                .AddIngredient(ItemID.EmeraldStaff)
                .AddIngredient(ItemID.RubyStaff)
                .AddIngredient(ItemID.DiamondStaff)
                .AddIngredient(ItemID.AmberStaff)
                .AddIngredient(ModContent.ItemType<SoulOfBite>(), 25)
                .AddTile(TileID.DemonAltar)
                .Register();
        }
    }

    public class RainGemProjectile : ModProjectile
    {
        public override void SetDefaults()
        {
            Projectile.CloneDefaults(ProjectileID.DiamondBolt);
            Projectile.width = 16; // The width of projectile hitbox
            Projectile.height = 16; // The height of projectile hitbox
            Projectile.Opacity = 1;
            Projectile.light = 0.4f;
            
        }

        public override void SetStaticDefaults()
        {
            Main.projFrames[Projectile.type] = 6;
        }

        public override void AI()
        {
            if (++Projectile.frameCounter < 6) return;
            Projectile.frameCounter = 0;
            Projectile.frame = ++Projectile.frame % Main.projFrames[Projectile.type];
        }
    }
}
