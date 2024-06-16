using BepInEx;
using DiskCardGame;
using InscryptionAPI.Card;
using InscryptionAPI.Helpers;
using Steamworks;

namespace TribalLibary
{
    [BepInPlugin(PluginGuid, PluginName, PluginVersion)]
    [BepInDependency("cyantist.inscryption.api", BepInDependency.DependencyFlags.HardDependency)]
    public class Plugin : BaseUnityPlugin
    {
        private const string PluginGuid = "tribes.libary";
        private const string PluginName = "ATribalLibary";
        private const string PluginVersion = "2.1.0";

        public static Tribe abominationTribe;
        public static Tribe amphibianTribe;
        public static Tribe androidTribe;
        public static Tribe cellsTribe;
        public static Tribe ceremorphTribe;
        public static Tribe chessTribe;
        public static Tribe conduitsTribe;
        public static Tribe cryptidTribe;
        public static Tribe fairyTribe;
        public static Tribe felineTribe;
        public static Tribe fishTribe;
        public static Tribe fleshyTribe;
        public static Tribe fungusTribe;
        public static Tribe gemsTribe;
        public static Tribe guardianTribe;
        public static Tribe hellionTribe;
        public static Tribe horrorTribe;
        public static Tribe humanoidTribe;
        public static Tribe lichTribe;
        public static Tribe machineTribe;
        public static Tribe mulluskTribe;
        public static Tribe mythicalTribe;
        public static Tribe nightmareTribe;
        public static Tribe objectTribe;
        public static Tribe planetTribe;
        public static Tribe plantTribe;
        public static Tribe possessedTribe;
        public static Tribe rodentTribe;
        public static Tribe scholarTribe;
        public static Tribe securityTribe;
        public static Tribe shapelessTribe;
        public static Tribe shapeshifterTribe;
        public static Tribe skeletalTribe;
        public static Tribe spectralTribe;
        public static Tribe stoneTribe;
        public static Tribe utilityTribe;
        public static Tribe wingedbeastTribe;

        public void Awake()
        {

            Logger.LogInfo($"Sucsessfully Loaded {PluginName}!");
            int i = 0;

            abominationTribe = TribeManager.Add(PluginGuid, "abomination", tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_abomination.png"), appearInTribeChoices: true, choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_BASIC_abomination.png"));
            i++;
            amphibianTribe = TribeManager.Add(PluginGuid, "amphibian", tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_amphibian.png"), appearInTribeChoices: true, choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_NATURE_amphibian.png"));
            i++;
            androidTribe = TribeManager.Add(PluginGuid, "android", tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_android.png"), appearInTribeChoices: true, choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_TECH_android.png"));
            i++;
            cellsTribe = TribeManager.Add(PluginGuid, "cells", tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_cells.png"), appearInTribeChoices: true, choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_TECH_cells.png"));
            i++;
            ceremorphTribe = TribeManager.Add(PluginGuid, "ceremorph", tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_ceremorph.png"), appearInTribeChoices: true, choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_MAGIKS_ceremorph.png"));
            i++;
            chessTribe = TribeManager.Add(PluginGuid, "chess", tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_chess.png"), appearInTribeChoices: true, choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_TECH_chess.png"));
            i++;
            conduitsTribe = TribeManager.Add(PluginGuid, "conduits", tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_conduits.png"), appearInTribeChoices: true, choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_TECH_conduits.png"));
            i++;
            cryptidTribe = TribeManager.Add(PluginGuid, "cryptid", tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_cryptid.png"), appearInTribeChoices: true, choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_UNDEAD_cryptid.png"));
            i++;
            fairyTribe = TribeManager.Add(PluginGuid, "fairy", tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_fairy.png"), appearInTribeChoices: true, choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_MAGIKS_fairy.png"));
            i++;
            felineTribe = TribeManager.Add(PluginGuid, "feline", tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_feline.png"), appearInTribeChoices: true, choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_NATURE_feline.png"));
            i++;
            fishTribe = TribeManager.Add(PluginGuid, "fish", tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_fish.png"), appearInTribeChoices: true, choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_NATURE_fish.png"));
            i++;
            fleshyTribe = TribeManager.Add(PluginGuid, "fleshy", tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_zombie.png"), appearInTribeChoices: true, choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_UNDEAD_zombie.png"));
            i++;
            fungusTribe = TribeManager.Add(PluginGuid, "fungus", tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_fungus.png"), appearInTribeChoices: true, choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_BASIC_fungus.png"));
            i++;
            gemsTribe = TribeManager.Add(PluginGuid, "gems", TextureHelper.GetImageAsTexture("tribeicon_gems.png"), true, TextureHelper.GetImageAsTexture("card_rewardback_MAGIKS_gems.png"));
            i++;
            guardianTribe = TribeManager.Add(PluginGuid, "guardian", tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_guardian.png"), appearInTribeChoices: true, choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_MAGIKS_guardian.png"));
            i++;
            hellionTribe = TribeManager.Add(PluginGuid, "hellion", TextureHelper.GetImageAsTexture("tribeicon_hellion.png"), true, TextureHelper.GetImageAsTexture("card_rewardback_UNDEAD_hellion.png"));
            i++;
            horrorTribe = TribeManager.Add(PluginGuid, "horror", TextureHelper.GetImageAsTexture("tribeicon_horror.png"), true, TextureHelper.GetImageAsTexture("card_rewardback_UNDEAD_horror.png"));
            i++;
            humanoidTribe = TribeManager.Add(PluginGuid, "humanoid", tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_humanoid.png"), appearInTribeChoices: true, choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_NATURE_humanoid.png"));
            i++;
            lichTribe = TribeManager.Add(PluginGuid, "lich", TextureHelper.GetImageAsTexture("tribeicon_lich.png"), true, TextureHelper.GetImageAsTexture("card_rewardback_MAGIKS_lich.png"));
            i++;
            machineTribe = TribeManager.Add(PluginGuid, "machine", TextureHelper.GetImageAsTexture("tribeicon_machine.png"), true, TextureHelper.GetImageAsTexture("card_rewardback_TECH_machine.png"));
            i++;
            mulluskTribe = TribeManager.Add(PluginGuid, "mullusk", tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_mullusk.png"), appearInTribeChoices: true, choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_UNDEAD_mullusk.png"));
            i++;
            mythicalTribe = TribeManager.Add(PluginGuid, "mythical", tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_mythical.png"), appearInTribeChoices: true, choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_NATURE_mythical.png"));
            i++;
            nightmareTribe = TribeManager.Add(PluginGuid, "nightmare", TextureHelper.GetImageAsTexture("tribeicon_nightmare.png"), true, TextureHelper.GetImageAsTexture("card_rewardback_UNDEAD_nightmare.png"));
            i++;
            objectTribe = TribeManager.Add(PluginGuid, "object", TextureHelper.GetImageAsTexture("tribeicon_object.png"), true, TextureHelper.GetImageAsTexture("card_rewardback_BASIC_object.png"));
            i++;
            planetTribe = TribeManager.Add(PluginGuid, "planet", TextureHelper.GetImageAsTexture("tribeicon_planet.png"), true, TextureHelper.GetImageAsTexture("card_rewardback_BASIC_planet.png"));
            i++;
            plantTribe = TribeManager.Add(PluginGuid, "plant", tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_plant.png"), appearInTribeChoices: true, choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_BASIC_plant.png"));
            i++;
            possessedTribe = TribeManager.Add(PluginGuid, "possessed", tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_possessed.png"), appearInTribeChoices: true, choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_UNDEAD_possessed.png"));
            i++;
            rodentTribe = TribeManager.Add(PluginGuid, "rodent", tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_rodent.png"), appearInTribeChoices: true, choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_NATURE_rodent.png"));
            i++;
            scholarTribe = TribeManager.Add(PluginGuid, "scholar", tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_scholar.png"), appearInTribeChoices: true, choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_MAGIKS_scholar.png"));
            i++;
            securityTribe = TribeManager.Add(PluginGuid, "security", tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_security.png"), appearInTribeChoices: true, choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_TECH_security.png"));
            i++;
            shapelessTribe = TribeManager.Add(PluginGuid, "shapeless", TextureHelper.GetImageAsTexture("tribeicon_shapeless.png"), true, TextureHelper.GetImageAsTexture("card_rewardback_BASIC_shapeless.png"));
            i++;
            shapeshifterTribe = TribeManager.Add(PluginGuid, "shapeshifter", TextureHelper.GetImageAsTexture("tribeicon_shapeshifter.png"), true, TextureHelper.GetImageAsTexture("card_rewardback_MAGIKS_shapeshifter.png"));
            i++;
            skeletalTribe = TribeManager.Add(PluginGuid, "skeletal", tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_skeletal.png"), appearInTribeChoices: true, choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_UNDEAD_skeletal.png"));
            i++;
            spectralTribe = TribeManager.Add(PluginGuid, "spectral", tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_spectral.png"), appearInTribeChoices: true, choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_UNDEAD_spectral.png"));
            i++;
            stoneTribe = TribeManager.Add(PluginGuid, "stone", tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_stone.png"), appearInTribeChoices: true, choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_BASIC_stone.png"));
            i++;
            utilityTribe = TribeManager.Add(PluginGuid, "utility", tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_utility.png"), appearInTribeChoices: true, choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_TECH_utility.png"));
            i++;
            wingedbeastTribe = TribeManager.Add(PluginGuid, "wingedbeast", TextureHelper.GetImageAsTexture("tribeicon_wingedbeast.png"), true, TextureHelper.GetImageAsTexture("card_rewardback_NATURE_wingedbeast.png"));
            i++;

            Logger.LogInfo($"Sucsessfully Loaded {i} tribe(s)!");
        }
    }
}
