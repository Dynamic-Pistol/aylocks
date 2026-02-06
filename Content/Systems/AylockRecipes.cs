using aylocks.Content.Items.Materials;
using Terraria;
using Terraria.Enums;
using Terraria.GameContent.Items;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace aylocks.Content.Systems
{
    public class AylockRecipes : ModSystem
    {
        public override void AddRecipeGroups()
        {
            #region Tier 1 Hardmode Ore

            RecipeGroup anyCobaltBar = new RecipeGroup(
                () => $"{Language.GetTextValue("LegacyMisc.37")} {Lang.GetItemNameValue(ItemID.CobaltBar)}"
                , ItemID.CobaltBar, ItemID.PalladiumBar);
            RecipeGroup.RegisterGroup("aylocks:AnyH1Bar", anyCobaltBar);

            RecipeGroup anyCobaltBreastPlate = new RecipeGroup(
                () => $"{Language.GetTextValue("LegacyMisc.37")} {Lang.GetItemNameValue(ItemID.CobaltBreastplate)}"
                , ItemID.CobaltBreastplate, ItemID.PalladiumBreastplate);
            RecipeGroup.RegisterGroup("aylocks:AnyH1BreastPlate", anyCobaltBreastPlate);

            RecipeGroup anyCobaltLegging = new RecipeGroup(
                () => $"{Language.GetTextValue("LegacyMisc.37")} {Lang.GetItemNameValue(ItemID.CobaltLeggings)}"
                , ItemID.CobaltLeggings, ItemID.PalladiumLeggings);
            RecipeGroup.RegisterGroup("aylocks:AnyH1Legging", anyCobaltLegging);

            RecipeGroup anyCobaltHelmetMelee = new RecipeGroup(
                () => $"{Language.GetTextValue("LegacyMisc.37")} {Lang.GetItemNameValue(ItemID.CobaltHelmet)}"
                , ItemID.CobaltHelmet, ItemID.PalladiumMask);
            RecipeGroup.RegisterGroup("aylocks:AnyH1HatMelee", anyCobaltHelmetMelee);

            RecipeGroup anyCobaltHelmetRanger = new RecipeGroup(
                () => $"{Language.GetTextValue("LegacyMisc.37")} {Lang.GetItemNameValue(ItemID.CobaltMask)}"
                , ItemID.CobaltMask, ItemID.PalladiumHelmet);
            RecipeGroup.RegisterGroup("aylocks:AnyH1HatRanger", anyCobaltHelmetRanger);

            RecipeGroup anyCobaltHelmetMage = new RecipeGroup(
                () => $"{Language.GetTextValue("LegacyMisc.37")} {Lang.GetItemNameValue(ItemID.CobaltHat)}"
                , ItemID.CobaltHat, ItemID.PalladiumHeadgear);
            RecipeGroup.RegisterGroup("aylocks:AnyH1HatMage", anyCobaltHelmetMage);

            #endregion
            #region Tier 2 Hardmode Armor
            RecipeGroup anyMythrilBreastPlate = new RecipeGroup(
                () => $"{Language.GetTextValue("LegacyMisc.37")} {Lang.GetItemNameValue(ItemID.MythrilChainmail)}"
                , ItemID.MythrilChainmail, ItemID.OrichalcumBreastplate);
            RecipeGroup.RegisterGroup("aylocks:AnyH2BreastPlate", anyMythrilBreastPlate);

            RecipeGroup anyMythrilLegging = new RecipeGroup(
                () => $"{Language.GetTextValue("LegacyMisc.37")} {Lang.GetItemNameValue(ItemID.MythrilGreaves)}"
                , ItemID.MythrilGreaves, ItemID.OrichalcumLeggings);
            RecipeGroup.RegisterGroup("aylocks:AnyH2Legging", anyMythrilLegging);

            RecipeGroup anyMythrilHelmetMelee = new RecipeGroup(
                () => $"{Language.GetTextValue("LegacyMisc.37")} {Lang.GetItemNameValue(ItemID.MythrilHelmet)}"
                , ItemID.MythrilHelmet, ItemID.OrichalcumMask);
            RecipeGroup.RegisterGroup("aylocks:AnyH2HatMelee", anyMythrilHelmetMelee);

            RecipeGroup anyMythrilHelmetRanger = new RecipeGroup(
                () => $"{Language.GetTextValue("LegacyMisc.37")} {Lang.GetItemNameValue(ItemID.MythrilHat)}"
                , ItemID.MythrilHat, ItemID.OrichalcumHelmet);
            RecipeGroup.RegisterGroup("aylocks:AnyH2HatRanger", anyMythrilHelmetRanger);

            RecipeGroup anyMythrilHelmetMage = new RecipeGroup(
                () => $"{Language.GetTextValue("LegacyMisc.37")} {Lang.GetItemNameValue(ItemID.MythrilHood)}"
                , ItemID.MythrilHood, ItemID.OrichalcumHeadgear);
            RecipeGroup.RegisterGroup("aylocks:AnyH2HatMage", anyMythrilHelmetMage);
            #endregion
            #region Misc

            #endregion
        }

        public override void AddRecipes()
        {
            #region Fishing

            Recipe.Create(ItemID.ScarabFishingRod)
            .AddIngredient(ItemID.FisherofSouls)
            .AddIngredient(ItemID.WaterStrider, 7)
            .AddIngredient(ItemID.FossilOre, 3)
            .AddTile(TileID.GlassKiln)
            .Register();
            Recipe.Create(ItemID.ScarabFishingRod)
            .AddIngredient(ItemID.Fleshcatcher)
            .AddIngredient(ItemID.WaterStrider, 7)
            .AddIngredient(ItemID.FossilOre, 3)
            .AddTile(TileID.GlassKiln)
            .Register();
            Recipe.Create(ItemID.FiberglassFishingPole)
                .AddIngredient(ItemID.Glass, 20)
                .AddIngredient(ItemID.Vine, 7)
                .AddIngredient(ItemID.ScarabFishingRod)
                .AddTile(TileID.Anvils)
                .Register();
            Recipe.Create(ItemID.MechanicsRod)
                .AddIngredient(ItemID.FiberglassFishingPole)
                .AddIngredient(ItemID.Wire, 35)
                .AddIngredient(ModContent.ItemType<MechanicalFishUpgradeKit>())
                .AddTile(TileID.Anvils)
                .Register();
            Recipe.Create(ItemID.SittingDucksFishingRod)
                .AddIngredient(ItemID.MechanicsRod)
                .AddIngredient(ModContent.ItemType<DuckFishUpgradeKit>())
                .AddTile(TileID.BoneWelder)
                .Register();
            Recipe.Create(ItemID.HotlineFishingHook)
                .AddIngredient(ItemID.SittingDucksFishingRod)
                .AddIngredient(ItemID.HellstoneBar, 6)
                .AddIngredient(ItemID.MagmaSnail, 5)
                .AddTile(TileID.Hellforge)
                .Register();
            Recipe.Create(ItemID.GoldenFishingRod)
                .AddIngredient(ItemID.HotlineFishingHook)
                .AddIngredient(ModContent.ItemType<GoldenScale>(), 25)
                .AddTile(TileID.Anvils)
                .Register();
            #endregion
            Recipe.Create(ItemID.GoldenBugNet)
            .AddIngredient(ItemID.FireproofBugNet)
            .AddIngredient(ModContent.ItemType<GoldenScale>(), 10)
            .AddTile(TileID.Anvils)
            .Register();
        }

        public override void PostAddRecipes()
        {
            for (int index = 0; index < Recipe.maxRecipes; index++)
            {
                var recipe = Main.recipe[index];

                #region Tier 2 Hardmode Armor
                if (recipe.HasResult(ItemID.OrichalcumBreastplate) || recipe.HasResult(ItemID.MythrilChainmail))
                {
                    recipe.AddRecipeGroup("aylocks:AnyH1BreastPlate");
                }
                else if (recipe.HasResult(ItemID.OrichalcumLeggings) || recipe.HasResult(ItemID.MythrilGreaves))
                {
                    recipe.AddRecipeGroup("aylocks:AnyH1Legging");
                }
                else if (recipe.HasResult(ItemID.OrichalcumMask) || recipe.HasResult(ItemID.MythrilHelmet))
                {
                    recipe.AddRecipeGroup("aylocks:AnyH1HatMelee");
                }
                else if (recipe.HasResult(ItemID.OrichalcumHelmet) || recipe.HasResult(ItemID.MythrilHat))
                {
                    recipe.AddRecipeGroup("aylocks:AnyH1HatRanger");
                }
                else if (recipe.HasResult(ItemID.OrichalcumHeadgear) || recipe.HasResult(ItemID.MythrilHood))
                {
                    recipe.AddRecipeGroup("aylocks:AnyH1HatMage");
                }
                #endregion
                #region Tier 3 Hardmode Armor
                if (recipe.HasResult(ItemID.TitaniumBreastplate) || recipe.HasResult(ItemID.AdamantiteBreastplate))
                {
                    recipe.AddRecipeGroup("aylocks:AnyH2BreastPlate");
                }
                else if (recipe.HasResult(ItemID.TitaniumLeggings) || recipe.HasResult(ItemID.AdamantiteLeggings))
                {
                    recipe.AddRecipeGroup("aylocks:AnyH2Legging");
                }
                else if (recipe.HasResult(ItemID.TitaniumHelmet) || recipe.HasResult(ItemID.AdamantiteMask))
                {
                    recipe.AddRecipeGroup("aylocks:AnyH2HatMelee");
                }
                else if (recipe.HasResult(ItemID.TitaniumMask) || recipe.HasResult(ItemID.AdamantiteHelmet))
                {
                    recipe.AddRecipeGroup("aylocks:AnyH2HatRanger");
                }
                else if (recipe.HasResult(ItemID.TitaniumHeadgear) || recipe.HasResult(ItemID.AdamantiteHeadgear))
                {
                    recipe.AddRecipeGroup("aylocks:AnyH2HatMage");
                }
                #endregion
                #region Fishing
                if (recipe.HasResult(ItemID.ReinforcedFishingPole))
                {
                    recipe.AddIngredient(ItemID.WoodFishingPole);
                }
                else if (recipe.HasResult(ItemID.FisherofSouls) || recipe.HasResult(ItemID.Fleshcatcher))
                {
                    recipe.AddIngredient(ItemID.ReinforcedFishingPole);
                }
                #endregion
            }
        }
        // We use PostWorldGen for this because we want to ensure that all chests have been placed before adding items.
        public override void PostWorldGen()
        {
            for (int chestIndex = 0; chestIndex < Main.maxChests; chestIndex++)
            {
                Chest chest = Main.chest[chestIndex];
                if (chest == null)
                {
                    continue;
                }
                Tile chestTile = Main.tile[chest.x, chest.y];
                // We need to check if the current chest is the Frozen Chest. We need to check that it exists and has the TileType and TileFrameX values corresponding to the Frozen Chest.
                // If you look at the sprite for Chests by extracting Tiles_21.xnb, you'll see that the 12th chest is the Frozen Chest. Since we are counting from 0, this is where 11 comes from. 36 comes from the width of each tile including padding. An alternate approach is to check the wiki and looking for the "Internal Tile ID" section in the infobox: https://terraria.wiki.gg/wiki/Frozen_Chest
                if (chestTile.TileType == TileID.Containers && chestTile.TileFrameX == 10 * 36)
                {
                    {
                        // Next we need to find the first empty slot for our item
                        for (int inventoryIndex = 0; inventoryIndex < Chest.maxItems; inventoryIndex++)
                        {
                            if (chest.item[inventoryIndex].type == ItemID.None)
                            {
                                for (int i = 0; i < Chest.maxItems; i++)
                                {
                                    if (chest.item[i].type == ItemID.FiberglassFishingPole)
                                    {
                                        chest.item[i].SetDefaults(ItemID.GreaterHealingPotion);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}