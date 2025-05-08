using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace aylocks.Content.Recipes
{
    public class AylockRecipes : ModSystem
    {
        public override void AddRecipeGroups()
        {
            #region Tier 1 Hardmode Armor

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
        }

        public override void AddRecipes()
        {
            
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
                else if (recipe.HasResult(ItemID.TitaniumBreastplate) || recipe.HasResult(ItemID.AdamantiteBreastplate))
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
            }
        }
    }
}