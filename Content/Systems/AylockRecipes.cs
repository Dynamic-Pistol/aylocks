using aylocks.Content.Items.Materials;
using Terraria;
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

            Recipe.Create(ItemID.FiberglassFishingPole)
                .AddIngredient(ItemID.Glass, 20)
                .AddIngredient(ItemID.Vine, 7)
                .AddIngredient(ItemID.FisherofSouls)
                .AddTile(TileID.Anvils)
                .Register();
            Recipe.Create(ItemID.FiberglassFishingPole)
                .AddIngredient(ItemID.Glass, 20)
                .AddIngredient(ItemID.Vine, 7)
                .AddIngredient(ItemID.Fleshcatcher)
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
                .AddTile(TileID.MythrilAnvil)
                .Register();
            Recipe.Create(ItemID.GoldenFishingRod)
                .AddIngredient(ItemID.HotlineFishingHook)
                .AddIngredient(ItemID.GoldBar, 15)
                .AddRecipeGroup("aylocks:AnyH1Bar", 3)
                .AddTile(TileID.MythrilAnvil)
                .Register();

            #endregion
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
                else if (recipe.HasResult(ItemID.OrichalcumLeggings) ||  recipe.HasResult(ItemID.MythrilGreaves))
                {
                    recipe.AddRecipeGroup("aylocks:AnyH1Legging");
                }
                else if (recipe.HasResult(ItemID.OrichalcumMask) ||   recipe.HasResult(ItemID.MythrilHelmet))
                {
                    recipe.AddRecipeGroup("aylocks:AnyH1HatMelee");
                }
                else if (recipe.HasResult(ItemID.OrichalcumHelmet) ||  recipe.HasResult(ItemID.MythrilHat))
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
                else if (recipe.HasResult(ItemID.TitaniumLeggings) ||  recipe.HasResult(ItemID.AdamantiteLeggings))
                {
                    recipe.AddRecipeGroup("aylocks:AnyH2Legging");
                }
                else if (recipe.HasResult(ItemID.TitaniumHelmet) ||   recipe.HasResult(ItemID.AdamantiteMask))
                {
                    recipe.AddRecipeGroup("aylocks:AnyH2HatMelee");
                }
                else if (recipe.HasResult(ItemID.TitaniumMask) ||  recipe.HasResult(ItemID.AdamantiteHelmet))
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
        
    }
}