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
            foreach (var item in rewardItems)
            {
                switch (item.type)
                {
                    case ItemID.HotlineFishingHook:
                        rewardItems.Remove(item);
                        break;
                    case ItemID.GoldenBugNet:
                        item.SetDefaults(ModContent.ItemType<GoldenScale>());
                        item.stack = Main.rand.Next(5, 10);
                        break;
                    case ItemID.GoldenFishingRod:

                        item.SetDefaults(ModContent.ItemType<GoldenScale>());
                        item.stack = Main.rand.Next(20, 30);
                        break;
                }
            }
        }
    }
}