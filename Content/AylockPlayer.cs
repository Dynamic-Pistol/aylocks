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
            var goldenNetIdIndex = rewardItems.FindIndex((item) => item.type == ItemID.GoldenBugNet);
            rewardItems[goldenNetIdIndex].type = ModContent.ItemType<GoldenScale>();
            rewardItems[goldenNetIdIndex].stack = Main.rand.Next(5, 10);
            var goldenRodIdIndex = rewardItems.FindIndex((item) => item.type == ItemID.GoldenFishingRod);
            rewardItems[goldenRodIdIndex].type = ModContent.ItemType<GoldenScale>();
            rewardItems[goldenRodIdIndex].stack = Main.rand.Next(20, 30);
        }
    }
}