using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
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
        }

        public override void AddRecipes()
        {
        }

        public override void PostAddRecipes()
        {
            for (int index = 0; index < Recipe.maxRecipes; index++)
            {
                var recipe = Main.recipe[index];
                if (recipe.HasResult(ItemID.TitaniumBreastplate))
                {
                    recipe.AddRecipeGroup("AnyH2BreastPlate");
                }
                else if (recipe.HasResult(ItemID.TitaniumLeggings))
                {
                    recipe.AddRecipeGroup("aylocks:AnyH2Legging");
                }
                else if (recipe.HasResult(ItemID.TitaniumHelmet))
                {
                    recipe.AddRecipeGroup("aylocks:AnyH2HatMelee");
                }
                else if (recipe.HasResult(ItemID.TitaniumMask))
                {
                    recipe.AddRecipeGroup("aylocks:AnyH2HatRanger");
                }
                else if (recipe.HasResult(ItemID.TitaniumHeadgear))
                {
                    recipe.AddRecipeGroup("aylocks:AnyH2HatMage");
                }
            }
        }
    }
}