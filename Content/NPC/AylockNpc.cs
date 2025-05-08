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
            int difficultyBonus = 1;
            if (Main.masterMode)
            {
                difficultyBonus = 10;
            }
            else if (Main.expertMode)
            {
                difficultyBonus = 5;
            }
            
            if (npc.type == NPCID.EyeofCthulhu)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<SoulOfBright>(), 1, 3 * difficultyBonus, 6 * difficultyBonus));
            }
            else if (npc.type == NPCID.SkeletronHead)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<SoulOfScright>(), 1, 8 * difficultyBonus, 12 * difficultyBonus));
            }
            else if (npc.type == NPCID.BrainofCthulhu || System.Array.IndexOf([NPCID.EaterofWorldsBody, NPCID.EaterofWorldsHead, NPCID.EaterofWorldsTail
                     ], npc.type) > -1)
            {
                var leadingConditionRule =
                    new LeadingConditionRule(new Conditions.LegacyHack_IsABoss());
                leadingConditionRule.OnSuccess(ItemDropRule.Common(ModContent.ItemType<SoulOfHeight>(), 1, 5 * difficultyBonus, 10 * difficultyBonus));
                npcLoot.Add(leadingConditionRule);
            }
        }
    }
}