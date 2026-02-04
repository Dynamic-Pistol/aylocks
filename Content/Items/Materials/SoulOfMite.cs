using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace aylocks.Content.Items.Materials
{ 
    public class SoulOfMite : ModItem
    {
        public override void SetStaticDefaults()
        {
            Main.RegisterItemAnimation(Item.type, new DrawAnimationVertical(5, 4));
			ItemID.Sets.ItemIconPulse[Type] = true; // The item pulses while in the player's inventory
			ItemID.Sets.ItemNoGravity[Type] = true; // Makes the item have no gravity
        }

        public override void SetDefaults()
        {
            Item.maxStack = Item.CommonMaxStack; // The item's max stack value
            Item.value = Item.sellPrice(silver: 5, copper: 20);
            
        }

		public override void PostUpdate() {
			Lighting.AddLight(Item.Center, Color.WhiteSmoke.ToVector3() * 0.55f * Main.essScale); // Makes this item glow when thrown out of inventory.
		}

		public override Color? GetAlpha(Color lightColor) {
			return new Color(0, 255, 255, 50); // Makes this item render at full brightness.
		}
    }
}
