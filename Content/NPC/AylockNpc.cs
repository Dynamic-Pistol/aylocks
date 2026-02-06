using aylocks.Content.Items.Materials;
using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;

namespace aylocks.Content.NPC
{
    public class AylockNpc : GlobalNPC
    {
        public override void ModifyNPCLoot(Terraria.NPC npc, NPCLoot npcLoot)
        {

            if (npc.type == NPCID.EyeofCthulhu)
            {
                var leadingConditionRule =
                    new LeadingConditionRule(new Conditions.LegacyHack_IsABoss());
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<SoulOfSmite>(), 1, 8, 10));
                npcLoot.Add(leadingConditionRule);
            }
            else if (npc.type == NPCID.SkeletronHead)
            {
                var leadingConditionRule =
                    new LeadingConditionRule(new Conditions.LegacyHack_IsABoss());
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<SoulOfMite>(), 1, 8, 12));
                npcLoot.Add(leadingConditionRule);
            }
            else if (npc.type == NPCID.Creeper || System.Array.IndexOf([NPCID.EaterofWorldsBody, NPCID.EaterofWorldsHead, NPCID.EaterofWorldsTail
                     ], npc.type) > -1)
            {
                var leadingConditionRule =
                    new LeadingConditionRule(new Conditions.NotExpert());

                leadingConditionRule.OnSuccess(ItemDropRule.Common(ModContent.ItemType<SoulOfBite>(), 4, 1, 3));
                npcLoot.Add(leadingConditionRule);
            }
            else if (npc.type == NPCID.BrainofCthulhu || System.Array.IndexOf([NPCID.EaterofWorldsBody, NPCID.EaterofWorldsHead, NPCID.EaterofWorldsTail
                     ], npc.type) > -1)
            {
                var leadingConditionRule =
                    new LeadingConditionRule(new Conditions.LegacyHack_IsBossAndNotExpert());

                leadingConditionRule.OnSuccess(ItemDropRule.Common(ModContent.ItemType<SoulOfBite>(), 1, 6, 8));
                npcLoot.Add(leadingConditionRule);
            }
        }

        public override void ModifyShop(NPCShop shop)
        {
            if (shop.NpcType == NPCID.TravellingMerchant)
            {
                //Old way
                // if (shop.TryGetEntry(ItemID.SittingDucksFishingRod, out var entry))
                // {
                //     // entry.Disable();
                //     // shop.Add(new Item(ModContent.ItemType<DuckFishUpgradeKit>())
                //     // {
                //     //     shopCustomPrice = Item.buyPrice(gold: 5, silver:20),
                //     // }, Condition.DownedSkeletron);
                // }
            
                //New way
                for (int i = 0; i < shop.Entries.Count; i++) {
                    if (shop.Entries[i].Item.type == ItemID.SittingDucksFishingRod){
                        shop.Entries[i].Item.SetDefaults(ModContent.ItemType<DuckFishUpgradeKit>());
                        break;
                    }
                }
            }
            else if (shop.NpcType == NPCID.Mechanic)
            {
                for (int i = 0; i < shop.Entries.Count; i++) {
                    if (shop.Entries[i].Item.type == ItemID.MechanicsRod){
                        shop.Entries[i].Item.SetDefaults(ModContent.ItemType<MechanicalFishUpgradeKit>());
                        break;
                    }
                }
            }
        }


    }
}