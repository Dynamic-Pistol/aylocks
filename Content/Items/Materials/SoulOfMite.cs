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
        }

        public override void SetDefaults()
        {
            Item.maxStack = Item.CommonMaxStack; // The item's max stack value
            Item.value = Item.sellPrice(silver: 5, copper: 20);
        }
    }
}
