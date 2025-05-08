using System.Collections.Generic;
using aylocks.Content.Items.Materials;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace aylocks.Content
{
    public class AylockPlayer : ModPlayer
    {
        public override void AnglerQuestReward(float rareMultiplier, List<Item> rewardItems)
        {
            var hotlineRodIdIndex = rewardItems.FindIndex((item) => item.type == ItemID.HotlineFishingHook);
            rewardItems.RemoveAt(hotlineRodIdIndex);
            var goldenRodIdIndex = rewardItems.FindIndex((item) => item.type == ItemID.GoldenFishingRod);
            rewardItems.RemoveAt(goldenRodIdIndex);
            if (rareMultiplier < 20 && Condition.DownedSkeletron.IsMet())
            {
                var mechanicalUpgradeKit = new Item(ModContent.ItemType<MechanicalFishUpgradeKit>());
                rewardItems.Add(mechanicalUpgradeKit);
            }
        }
    }
}