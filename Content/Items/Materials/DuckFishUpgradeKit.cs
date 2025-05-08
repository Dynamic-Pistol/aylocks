using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace aylocks.Content.Items.Materials
{
    public class DuckFishUpgradeKit : ModItem
    {
        public override void SetDefaults()
        {
            Item.maxStack = Item.CommonMaxStack; // The item's max stack value
            Item.value = Item.sellPrice(gold:1, silver:50);
            Item.useAnimation = 30;
            Item.useTime = 30;
            Item.useStyle = 4;
            Item.consumable = true;
        }

        public override bool? UseItem(Player player)
        {
            var chumItem = new Item(ItemID.BloodFishingRod);
            var chumSpeed = chumItem.shootSpeed;
            Main.NewText($"Chum Caster speed = {chumSpeed}");
            return true;
        }
    }
}
