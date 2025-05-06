using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace aylocks.Content.Items.Tools
{
    public class RainGemHook : ModItem
    {
        public override void SetDefaults()
		{
			Item.CloneDefaults(ItemID.AmethystHook);
            Item.rare = ItemRarityID.Green;
            Item.shootSpeed = 18f; 
            Item.shoot = ModContent.ProjectileType<RainGemHookProjectile>();
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.AmethystHook)
                .AddIngredient(ItemID.TopazHook)
                .AddIngredient(ItemID.SapphireHook)
                .AddIngredient(ItemID.EmeraldHook)
                .AddIngredient(ItemID.RubyHook)
                .AddIngredient(ItemID.AmberHook)
                .AddIngredient(ItemID.DiamondHook)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }

    internal class RainGemHookProjectile : ModProjectile
	{
		private static Asset<Texture2D>[] chainTexture;

		public override void Load() { // This is called once on mod (re)load when this piece of content is being loaded.
			// This is the path to the texture that we'll use for the hook's chain. Make sure to update it.
			chainTexture = new Asset<Texture2D>[5];
			for (int index = 0; index < 5; index++)
			{
				chainTexture[index] = ModContent.Request<Texture2D>($"aylocks/Content/Items/Tools/GemChain_{index + 1}");
			}
		}

		public override void SetDefaults() {
			Projectile.CloneDefaults(ProjectileID.GemHookDiamond); // Copies the attributes of the Amethyst hook's projectile.
		}

		// Amethyst Hook is 300, Static Hook is 600.
		public override float GrappleRange() {
			return 500f;
		}

		public override void NumGrappleHooks(Player player, ref int numHooks) {
			numHooks = 1; // The amount of hooks that can be shot out
		}

		// default is 11, Lunar is 24
		public override void GrappleRetreatSpeed(Player player, ref float speed) {
			speed = 11f; // How fast the grapple returns to you after meeting its max shoot distance
		}

		public override void GrapplePullSpeed(Player player, ref float speed) {
			speed = 12.5f; // How fast you get pulled to the grappling hook projectile's landing position
		}

		// Adjusts the position that the player will be pulled towards. This will make them hang 50 pixels away from the tile being grappled.
		public override void GrappleTargetPoint(Player player, ref float grappleX, ref float grappleY) {
			Vector2 dirToPlayer = Projectile.DirectionTo(player.Center);
			float hangDist = 50f;
			grappleX += dirToPlayer.X * hangDist;
			grappleY += dirToPlayer.Y * hangDist;
		}

		// Can customize what tiles this hook can latch onto, or force/prevent latching altogether, like Squirrel Hook also latching to trees
		public override bool? GrappleCanLatchOnTo(Player player, int x, int y) {
			// By default, the hook returns null to apply the vanilla conditions for the given tile position (this tile position could be air or an actuated tile!)
			// If you want to return true here, make sure to check for Main.tile[x, y].HasUnactuatedTile (and Main.tileSolid[Main.tile[x, y].TileType] and/or Main.tile[x, y].HasTile if needed)

			// In any other case, behave like a normal hook
			return null;
		}

		// Draws the grappling hook's chain.
		public override bool PreDrawExtras() {
			Vector2 playerCenter = Main.player[Projectile.owner].MountedCenter;
			Vector2 center = Projectile.Center;
			Vector2 directionToPlayer = playerCenter - Projectile.Center;
			float chainRotation = directionToPlayer.ToRotation() - MathHelper.PiOver2;
			float distanceToPlayer = directionToPlayer.Length();
			int textureIndex = 0;
			while (distanceToPlayer > 20f && !float.IsNaN(distanceToPlayer))
			{
				// (int)MathF.Round(distanceToPlayer) % 6;
				Main.NewText($"Getting texture index: {textureIndex}");
				Mod.Logger.Debug($"Getting texture index: {textureIndex}");
				directionToPlayer /= distanceToPlayer; // get unit vector
				directionToPlayer *= chainTexture[textureIndex].Height(); // multiply by chain link length

				center += directionToPlayer; // update draw position
				directionToPlayer = playerCenter - center; // update distance
				distanceToPlayer = directionToPlayer.Length();

				Color drawColor = Lighting.GetColor((int)center.X / 16, (int)(center.Y / 16));

				// Draw chain
				Main.EntitySpriteDraw(chainTexture[textureIndex].Value, center - Main.screenPosition,
					chainTexture[textureIndex].Value.Bounds, drawColor, chainRotation,
					chainTexture[textureIndex].Size() * 0.5f, 1f, SpriteEffects.None, 0);

				textureIndex++;
				textureIndex %= 5;
			}
			// Stop vanilla from drawing the default chain.
			return false;
		}
	}
}
