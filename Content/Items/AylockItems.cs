using aylocks.Content.Items.Materials;
using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;

namespace aylocks.Content.Items
{
    public class AylockItems : GlobalItem
    {
        public override void ModifyItemLoot(Item item, ItemLoot itemLoot)
        {
            if (item.type == ItemID.EyeOfCthulhuBossBag)
            {
                itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<SoulOfSmite>(), 1, 8, 14));
            }
            else if (item.type == ItemID.SkeletronBossBag)
            {
                itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<SoulOfMite>(), 1, 14, 18));
            }
            else if (item.type is ItemID.BrainOfCthulhuBossBag or ItemID.EaterOfWorldsBossBag)
            {
                itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<SoulOfBite>(), 1, 20, 35));
            }
        }

        public override void SetDefaults(Item entity)
        {
            if (entity.type == ItemID.FisherofSouls)
            {
                entity.shootSpeed = 13.5f;
            }
            else if (entity.type == ItemID.Fleshcatcher)
            {
                entity.shootSpeed = 13f;
            }
        }
    }
    
}