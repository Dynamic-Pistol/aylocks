using Terraria;
using Terraria.ModLoader;

namespace aylocks.Content.Items.Materials
{ 
    public class GoldenScale : ModItem
    {
        public override void SetDefaults()
        {
            Item.maxStack = Item.CommonMaxStack; // The item's max stack value
            Item.value = Item.sellPrice(gold:1, silver:50);
        }
    }
}