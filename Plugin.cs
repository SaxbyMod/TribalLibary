using BepInEx;
using DiskCardGame;
using InscryptionAPI.Card;
using InscryptionAPI.Helpers;

namespace TribalLibary
{
    [BepInPlugin(PluginGuid, PluginName, PluginVersion)]
    [BepInDependency("cyantist.inscryption.api", BepInDependency.DependencyFlags.HardDependency)]
    public class Plugin : BaseUnityPlugin

    {

        private const string PluginGuid = "tribes.libary";
        private const string PluginName = "ATribalLibary";
        private const string PluginVersion = "1.14.0";

        public static Tribe skeletalTribe;
        public static Tribe fleshyTribe;
        public static Tribe spectralTribe;
        public static Tribe vesselTribe;
        public static Tribe conduitsTribe;
        public static Tribe cellsTribe;
        public static Tribe utillityTribe;
        public static Tribe securityTribe;
        public static Tribe scholarTribe;
        public static Tribe guardianTribe;
        public static Tribe moxTribe;
        public static Tribe tentacleTribe;
        public static Tribe everythingTribe;
        public static Tribe fungusTribe;
        public static Tribe rodentTribe;
        public static Tribe ceromorphTribe;
        public static Tribe dragonTribe;
        public static Tribe fishTribe;
        public static Tribe beastTribe;
        public static Tribe beastwarriorTribe;
        public static Tribe aquaTribe;
        public static Tribe fairyTribe;
        public static Tribe plantTribe;
        public static Tribe pyroTribe;
        public static Tribe stoneTribe;
        public static Tribe thunderTribe;
        public static Tribe iceTribe;
        public static Tribe abominationTribe;
        public static Tribe cyberseTribe;
        public static Tribe dinosaurTribe;
        public static Tribe ghoulTribe;
        public static Tribe giantTribe;
        public static Tribe gooTribe;
        public static Tribe rockTribe;
        public static Tribe seaserpentTribe;
        public static Tribe vampireTribe;
        public static Tribe eggTribe;
        public static Tribe hauntedTribe;
        public static Tribe humanoidTribe;
        public static Tribe instrumentTribe;
        public static Tribe moonTribe;
        public static Tribe occultistTribe;
        public static Tribe possessedTribe;
        public static Tribe spiritTribe;
        public static Tribe unicellularTribe;
        public static Tribe zombieTribe;
        public static Tribe corpseTribe;
        public static Tribe mulluskTribe;
        public static Tribe cryptidTribe;
        public static Tribe chessTribe;
        public static Tribe amphibianTribe;
        public static Tribe felineTribe;
        public static Tribe houndTribe;
        public static Tribe nobleTribe;
        public static Tribe androidTribe;
        public static Tribe constructTribe;
        public static Tribe ebirdTribe;
        public static Tribe ecanineTribe;
        public static Tribe ehoovedTribe;
        public static Tribe einsectTribe;
        public static Tribe ereptileTribe;
        public static Tribe esquirrelTribe;
        public static Tribe booTribe;
        public static Tribe blockTribe;
        public static Tribe blooperTribe;
        public static Tribe bombombTribe;
        public static Tribe goombaTribe;
        public static Tribe blasterTribe;
        public static Tribe chompTribe;
        public static Tribe cheepCheepTribe;
        public static Tribe koopaTribe;
        public static Tribe piranhaPlantTribe;
        public static Tribe pokeyTribe;
        public static Tribe powerUpTribe;
        public static Tribe spikeTribe;
        public static Tribe shroobTribe;
        public static Tribe shyGuyTribe;
        public static Tribe crusherTribe;
        public static Tribe starTribe;
        public static Tribe mskeletonTribe;
        public static Tribe minsectTribe;
        public static Tribe mbirdTribe;
        public static Tribe mhoovedTribe;
        public static Tribe mreptileTribe;
        public static Tribe msquirrelTribe;
        public static Tribe cloudTribe;
        public static Tribe organTribe;
        public static Tribe itemboxTribe;
        public static Tribe electricityTribe;
        public static Tribe platformTribe;
        public static Tribe amalgramTribe;
        public static Tribe bonelessTribe;
        public static Tribe fiendTribe;
        public static Tribe foeTribe;
        public static Tribe friendTribe;
        public static Tribe frozenTribe;
        public static Tribe gamerTribe;
        public static Tribe gemsTribe;
        public static Tribe lichTribe;
        public static Tribe machineTribe;
        public static Tribe malwareTribe;
        public static Tribe psychicTribe;
        public static Tribe robotTribe;
        public static Tribe shapelessTribe;
        public static Tribe snakeTribe;
        public static Tribe spellcasterTribe;
        public static Tribe treasureTribe;
        public static Tribe treesTribe;
        public static Tribe virusTribe;
        public static Tribe warriorTribe;
        public static Tribe wyrmTribe;
        public static Tribe hellionTribe;
        public static Tribe werewolfTribe;
        public static Tribe shapeshifterTribe;
        public static Tribe wurmTribe;
        public static Tribe thrullTribe;
        public static Tribe tinyTribe;
        public static Tribe kithkinTribe;
        public static Tribe gargoyleTribe;
        public static Tribe shadeTribe;
        public static Tribe handTribe;
        public static Tribe necronTribe;
        public static Tribe slasherTribe;
        public static Tribe nightmareTribe;
        public static Tribe specterTribe;
        public static Tribe scarecrowTribe;
        public static Tribe horrorTribe;
        public static Tribe oozeTribe;
        public static Tribe wingedbeastTribe;
        public static Tribe divinebeastTribe;
        public static Tribe natureTribe;
        public static Tribe planetTribe;

        public void Awake()
        {
            Logger.LogInfo($"Sucsessfully Loaded {PluginName}!");
            int i = 0;
            {

                skeletalTribe = TribeManager.Add(
                    PluginGuid,
                    "skeletal",
                    tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_skeletal.png"),
                    appearInTribeChoices: true,
                    choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_UNDEAD_skeletal.png")
                 );
            }
            i++;
            {
                fleshyTribe = TribeManager.Add(
                    PluginGuid,
                    "fleshy",
                    tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_fleshy.png"),
                    appearInTribeChoices: true,
                    choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_UNDEAD_fleshy.png")
                 );
            }
            i++;
            {
                spectralTribe = TribeManager.Add(
                    PluginGuid,
                    "spectral",
                    tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_spectral.png"),
                    appearInTribeChoices: true,
                    choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_UNDEAD_spectral.png")
                 );
            }
            i++;
            {
                vesselTribe = TribeManager.Add(
                    PluginGuid,
                    "vessel",
                    tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_vessel.png"),
                    appearInTribeChoices: true,
                    choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_UNDEAD_vessel.png")
                 );
            }
            i++;
            {
                conduitsTribe = TribeManager.Add(
                    PluginGuid,
                    "conduits",
                    tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_conduits.png"),
                    appearInTribeChoices: true,
                    choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_TECH_conduits.png")
                 );
            }
            i++;
            {
                cellsTribe = TribeManager.Add(
                    PluginGuid,
                    "cells",
                    tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_cells.png"),
                    appearInTribeChoices: true,
                    choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_TECH_cells.png")
                 );
            }
            i++;
            {
                utillityTribe = TribeManager.Add(
                    PluginGuid,
                    "utillity",
                    tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_utillity.png"),
                    appearInTribeChoices: true,
                    choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_TECH_utillity.png")
                 );
            }
            i++;
            {
                securityTribe = TribeManager.Add(
                    PluginGuid,
                    "security",
                    tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_security.png"),
                    appearInTribeChoices: true,
                    choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_TECH_security.png")
                 );
            }
            i++;
            {
                scholarTribe = TribeManager.Add(
                    PluginGuid,
                    "scholar",
                    tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_scholar.png"),
                    appearInTribeChoices: true,
                    choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_MAGIKS_scholar.png")
                 );
            }
            i++;
            {
                guardianTribe = TribeManager.Add(
                    PluginGuid,
                    "guardian",
                    tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_guardian.png"),
                    appearInTribeChoices: true,
                    choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_MAGIKS_guardian.png")
                 );
            }
            i++;
            {
                moxTribe = TribeManager.Add(
                    PluginGuid,
                    "mox",
                    tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_mox.png"),
                    appearInTribeChoices: true,
                    choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_MAGIKS_mox.png")
                 );
            }
            i++;
            {
                tentacleTribe = TribeManager.Add(
                    PluginGuid,
                    "tentacle",
                    tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_tentacle.png"),
                    appearInTribeChoices: true,
                    choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_NATURE_tentacle.png")
                 );
            }
            i++;
            {
                everythingTribe = TribeManager.Add(
                    PluginGuid,
                    "everything",
                    tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_everything.png"),
                    appearInTribeChoices: true,
                    choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_BASIC_everything.png")
                 );
            }
            i++;
            {
                fungusTribe = TribeManager.Add(
                    PluginGuid,
                    "fungus",
                    tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_fungus.png"),
                    appearInTribeChoices: true,
                    choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_BASIC_fungus.png")
                 );
            }
            i++;
            {
                rodentTribe = TribeManager.Add(
                    PluginGuid,
                    "rodent",
                    tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_rodent.png"),
                    appearInTribeChoices: true,
                    choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_NATURE_rodent.png")
                 );
            }
            i++;
            {
                ceromorphTribe = TribeManager.Add(
                    PluginGuid,
                    "ceromorph",
                    tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_ceromorph.png"),
                    appearInTribeChoices: true,
                    choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_MAGIKS_ceromorph.png")
                 );
            }
            i++;
            {
                dragonTribe = TribeManager.Add(
                    PluginGuid,
                    "dragon",
                    tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_dragon.png"),
                    appearInTribeChoices: true,
                    choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_NATURE_dragon.png")
                 );
            }
            i++;
            {
                beastTribe = TribeManager.Add(
                    PluginGuid,
                    "beast",
                    tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_beast.png"),
                    appearInTribeChoices: true,
                    choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_NATURE_beast.png")
                 );
            }
            i++;
            {
                beastwarriorTribe = TribeManager.Add(
                    PluginGuid,
                    "beastwarrior",
                    tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_beastwarrior.png"),
                    appearInTribeChoices: true,
                    choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_NATURE_beastwarrior.png")
                 );
            }
            i++;
            {
                fishTribe = TribeManager.Add(
                    PluginGuid,
                    "fish",
                    tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_fish.png"),
                    appearInTribeChoices: true,
                    choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_NATURE_fish.png")
                 );
            }
            i++;
            {
                aquaTribe = TribeManager.Add(
                    PluginGuid,
                    "aqua",
                    tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_aqua.png"),
                    appearInTribeChoices: true,
                    choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_BASIC_aqua.png")
                 );
            }
            i++;
            {
                fairyTribe = TribeManager.Add(
                    PluginGuid,
                    "fairy",
                    tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_fairy.png"),
                    appearInTribeChoices: true,
                    choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_MAGIKS_fairy.png")
                 );
            }
            i++;
            {
                plantTribe = TribeManager.Add(
                    PluginGuid,
                    "plant",
                    tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_plant.png"),
                    appearInTribeChoices: true,
                    choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_BASIC_plant.png")
                 );
            }
            i++;
            {
                pyroTribe = TribeManager.Add(
                    PluginGuid,
                    "pyro",
                    tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_pyro.png"),
                    appearInTribeChoices: true,
                    choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_BASIC_pyro.png")
                 );
            }
            i++;
            {
                stoneTribe = TribeManager.Add(
                    PluginGuid,
                    "stone",
                    tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_stone.png"),
                    appearInTribeChoices: true,
                    choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_BASIC_stone.png")
                 );
            }
            i++;
            {
                thunderTribe = TribeManager.Add(
                    PluginGuid,
                    "thunder",
                    tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_thunder.png"),
                    appearInTribeChoices: true,
                    choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_BASIC_thunder.png")
                 );
            }
            i++;
            {
                iceTribe = TribeManager.Add(
                    PluginGuid,
                    "ice",
                    tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_ice.png"),
                    appearInTribeChoices: true,
                    choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_BASIC_ice.png")
                 );
            }
            i++;
            {
                abominationTribe = TribeManager.Add(
                    PluginGuid,
                    "abomination",
                    tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_abomination.png"),
                    appearInTribeChoices: true,
                    choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_BASIC_abomination.png")
                 );
            }
            i++;
            {
                cyberseTribe = TribeManager.Add(
                    PluginGuid,
                    "cyberse",
                    tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_cyberse.png"),
                    appearInTribeChoices: true,
                    choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_TECH_cyberse.png")
                 );
            }
            i++;
            {
                dinosaurTribe = TribeManager.Add(
                    PluginGuid,
                    "dinosaur",
                    tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_dinosaur.png"),
                    appearInTribeChoices: true,
                    choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_NATURE_dinosaur.png")
                 );
            }
            i++;
            {
                ghoulTribe = TribeManager.Add(
                    PluginGuid,
                    "ghoul",
                    tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_ghost.png"),
                    appearInTribeChoices: true,
                    choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_UNDEAD_ghost.png")
                 );
            }
            i++;
            {
                giantTribe = TribeManager.Add(
                    PluginGuid,
                    "giant",
                    tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_giant.png"),
                    appearInTribeChoices: true,
                    choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_BASIC_giant.png")
                 );
            }
            i++;
            {
                gooTribe = TribeManager.Add(
                    PluginGuid,
                    "goo",
                    tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_goo.png"),
                    appearInTribeChoices: true,
                    choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_BASIC_goo.png")
                 );
            }
            i++;
            {
                rockTribe = TribeManager.Add(
                    PluginGuid,
                    "rock",
                    tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_rock.png"),
                    appearInTribeChoices: true,
                    choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_BASIC_rock.png")
                 );
            }
            i++;
            {
                seaserpentTribe = TribeManager.Add(
                    PluginGuid,
                    "seaserpent",
                    tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_sea_serpent.png"),
                    appearInTribeChoices: true,
                    choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_NATURE_sea_serpent.png")
                 );
            }
            i++;
            {
                vampireTribe = TribeManager.Add(
                    PluginGuid,
                    "vampire",
                    tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_vampire.png"),
                    appearInTribeChoices: true,
                    choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_UNDEAD_vampire.png")
                 );
            }
            i++;
            {
                eggTribe = TribeManager.Add(
                    PluginGuid,
                    "egg",
                    tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_egg.png"),
                    appearInTribeChoices: true,
                    choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_NATURE_egg.png")
                 );
            }
            i++;
            {
                hauntedTribe = TribeManager.Add(
                    PluginGuid,
                    "haunted",
                    tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_haunted.png"),
                    appearInTribeChoices: true,
                    choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_UNDEAD_haunted.png")
                 );
            }
            i++;
            {
                humanoidTribe = TribeManager.Add(
                    PluginGuid,
                    "humanoid",
                    tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_humanoid.png"),
                    appearInTribeChoices: true,
                    choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_NATURE_humanoid.png")
                 );
            }
            i++;
            {
                instrumentTribe = TribeManager.Add(
                    PluginGuid,
                    "instrument",
                    tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_instrument.png"),
                    appearInTribeChoices: true,
                    choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_BASIC_instrument.png")
                 );
            }
            i++;
            {
                moonTribe = TribeManager.Add(
                    PluginGuid,
                    "moon",
                    tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_moon.png"),
                    appearInTribeChoices: true,
                    choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_BASIC_moon.png")
                 );
            }
            i++;
            {
                occultistTribe = TribeManager.Add(
                    PluginGuid,
                    "occultist",
                    tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_occultist.png"),
                    appearInTribeChoices: true,
                    choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_MAGIKS_occultist.png")
                 );
            }
            i++;
            {
                possessedTribe = TribeManager.Add(
                    PluginGuid,
                    "possessed",
                    tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_possessed.png"),
                    appearInTribeChoices: true,
                    choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_UNDEAD_possessed.png")
                 );
            }
            i++;
            {
                spiritTribe = TribeManager.Add(
                    PluginGuid,
                    "spirit",
                    tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_spirit.png"),
                    appearInTribeChoices: true,
                    choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_UNDEAD_spirit.png")
                 );
            }
            i++;
            {
                unicellularTribe = TribeManager.Add(
                    PluginGuid,
                    "unicellular",
                    tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_unicellular.png"),
                    appearInTribeChoices: true,
                    choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_BASIC_unicellular.png")
                 );
            }
            i++;
            {
                zombieTribe = TribeManager.Add(
                    PluginGuid,
                    "zombie",
                    tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_zombie.png"),
                    appearInTribeChoices: true,
                    choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_UNDEAD_zombie.png")
                 );
            }
            i++;
            {
                corpseTribe = TribeManager.Add(
                    PluginGuid,
                    "corpse",
                    tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_corpse.png"),
                    appearInTribeChoices: true,
                    choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_UNDEAD_corpse.png")
                 );
            }
            i++;
            {
                mulluskTribe = TribeManager.Add(
                    PluginGuid,
                    "mullusk",
                    tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_mullusk.png"),
                    appearInTribeChoices: true,
                    choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_UNDEAD_mullusk.png")
                 );
            }
            i++;
            {
                cryptidTribe = TribeManager.Add(
                    PluginGuid,
                    "cryptid",
                    tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_cryptid.png"),
                    appearInTribeChoices: true,
                    choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_UNDEAD_cryptid.png")
                 );
            }
            i++;
            {
                chessTribe = TribeManager.Add(
                     PluginGuid,
                     "chess",
                     tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_chess.png"),
                     appearInTribeChoices: true,
                     choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_TECH_chess.png")
                  );
            }
            i++;
            {
                amphibianTribe = TribeManager.Add(
                     PluginGuid,
                     "amphibian",
                     tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_amphibian.png"),
                     appearInTribeChoices: true,
                     choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_NATURE_amphibian.png")
                  );
            }
            i++;
            {
                felineTribe = TribeManager.Add(
                     PluginGuid,
                     "feline",
                     tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_feline.png"),
                     appearInTribeChoices: true,
                     choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_NATURE_feline.png")
                  );
            }
            i++;
            {
                houndTribe = TribeManager.Add(
                     PluginGuid,
                     "hound",
                     tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_hound.png"),
                     appearInTribeChoices: true,
                     choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_BASIC_hound.png")
                  );
            }
            i++;
            {
                nobleTribe = TribeManager.Add(
                     PluginGuid,
                     "noble",
                     tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_noble.png"),
                     appearInTribeChoices: true,
                     choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_BASIC_noble.png")
                  );
            }
            i++;
            {
                androidTribe = TribeManager.Add(
                     PluginGuid,
                     "android",
                     tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_android.png"),
                     appearInTribeChoices: true,
                     choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_TECH_android.png")
                  );
            }
            i++;
            {
                constructTribe = TribeManager.Add(
                     PluginGuid,
                     "construct",
                     tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_construct.png"),
                     appearInTribeChoices: true,
                     choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_MAGIKS_construct.png")
                  );
            }
            i++;
            {
                ebirdTribe = TribeManager.Add(
                     PluginGuid,
                     "ebird",
                     tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_bird.png"),
                     appearInTribeChoices: true,
                     choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_NATURE_bird.png")
                  );
            }
            i++;
            {
                ecanineTribe = TribeManager.Add(
                     PluginGuid,
                     "ecanine",
                     tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_canine.png"),
                     appearInTribeChoices: true,
                     choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_NATURE_canine.png")
                  );
            }
            i++;
            {
                ehoovedTribe = TribeManager.Add(
                     PluginGuid,
                     "ehooved",
                     tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_hooved.png"),
                     appearInTribeChoices: true,
                     choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_NATURE_hooved.png")
                  );
            }
            i++;
            {
                einsectTribe = TribeManager.Add(
                     PluginGuid,
                     "einsect",
                     tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_insect.png"),
                     appearInTribeChoices: true,
                     choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_NATURE_insect.png")
                  );
            }
            i++;
            {
                ereptileTribe = TribeManager.Add(
                     PluginGuid,
                     "ereptile",
                     tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_reptile.png"),
                     appearInTribeChoices: true,
                     choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_NATURE_reptile.png")
                  );
            }
            i++;
            {
                esquirrelTribe = TribeManager.Add(
                     PluginGuid,
                     "esquirrel",
                     tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_squirrel.png"),
                     appearInTribeChoices: true,
                     choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_NATURE_squirrel.png")
                  );
            }
            i++;
            {
                booTribe = TribeManager.Add(
                     PluginGuid,
                     "boo",
                     tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_boo.png"),
                     appearInTribeChoices: true,
                     choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_MARIO_boo.png")
                  );
            }
            i++;
            {
                blockTribe = TribeManager.Add(
                     PluginGuid,
                     "block",
                     tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_block.png"),
                     appearInTribeChoices: true,
                     choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_MARIO_block.png")
                  );
            }
            i++;
            {
                blooperTribe = TribeManager.Add(
                     PluginGuid,
                     "blooper",
                     tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_blooper.png"),
                     appearInTribeChoices: true,
                     choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_MARIO_blooper.png")
                  );
            }
            i++;
            {
                bombombTribe = TribeManager.Add(
                     PluginGuid,
                     "bomb-omb",
                     tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_bomb-omb.png"),
                     appearInTribeChoices: true,
                     choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_MARIO_bomb-omb.png")
                  );
            }
            i++;
            {
                goombaTribe = TribeManager.Add(
                     PluginGuid,
                     "goomba",
                     tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_goomba.png"),
                     appearInTribeChoices: true,
                     choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_MARIO_goomba.png")
                  );
            }
            i++;
            {
                blasterTribe = TribeManager.Add(
                     PluginGuid,
                     "blaster",
                     tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_blaster.png"),
                     appearInTribeChoices: true,
                     choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_MARIO_blaster.png")
                  );
            }
            i++;
            {
                chompTribe = TribeManager.Add(
                     PluginGuid,
                     "mcanine",
                     tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_chomp.png"),
                     appearInTribeChoices: true,
                     choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_MARIO_chomp.png")
                  );
            }
            i++;
            {
                cheepCheepTribe = TribeManager.Add(
                     PluginGuid,
                     "cheep_cheep",
                     tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_cheep_cheep.png"),
                     appearInTribeChoices: true,
                     choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_MARIO_cheep_cheep.png")
                  );
            }
            i++;
            {
                koopaTribe = TribeManager.Add(
                     PluginGuid,
                     "koopa",
                     tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_koopa.png"),
                     appearInTribeChoices: true,
                     choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_MARIO_koopa.png")
                  );
            }
            i++;
            {
                piranhaPlantTribe = TribeManager.Add(
                     PluginGuid,
                     "piranha_plant",
                     tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_piranha_plant.png"),
                     appearInTribeChoices: true,
                     choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_MARIO_piranha_plant.png")
                  );
            }
            i++;
            {
                pokeyTribe = TribeManager.Add(
                     PluginGuid,
                     "pokey",
                     tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_pokey.png"),
                     appearInTribeChoices: true,
                     choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_MARIO_pokey.png")
                  );
            }
            i++;
            {
                powerUpTribe = TribeManager.Add(
                     PluginGuid,
                     "power_up",
                     tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_power_up.png"),
                     appearInTribeChoices: true,
                     choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_MARIO_power_up.png")
                  );
            }
            i++;
            {
                spikeTribe = TribeManager.Add(
                     PluginGuid,
                     "spike",
                     tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_spike.png"),
                     appearInTribeChoices: true,
                     choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_MARIO_spike.png")
                  );
            }
            i++;
            {
                shroobTribe = TribeManager.Add(
                     PluginGuid,
                     "shroob",
                     tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_shroob.png"),
                     appearInTribeChoices: true,
                     choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_MARIO_shroob.png")
                  );
            }
            i++;
            {
                shyGuyTribe = TribeManager.Add(
                     PluginGuid,
                     "shy_guy",
                     tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_shy_guy.png"),
                     appearInTribeChoices: true,
                     choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_MARIO_shy_guy.png")
                  );
            }
            i++;
            {
                crusherTribe = TribeManager.Add(
                     PluginGuid,
                     "crusher",
                     tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_crusher.png"),
                     appearInTribeChoices: true,
                     choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_MARIO_crusher.png")
                  );
            }
            i++;
            {
                starTribe = TribeManager.Add(
                     PluginGuid,
                     "star",
                     tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_star.png"),
                     appearInTribeChoices: true,
                     choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_MARIO_star.png")
                  );
            }
            i++;
            {
                mskeletonTribe = TribeManager.Add(
                     PluginGuid,
                     "mskeleton",
                     tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_mskeleton.png"),
                     appearInTribeChoices: true,
                     choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_MARIO_mskeleton.png")
                  );
            }
            i++;
            {
                minsectTribe = TribeManager.Add(
                     PluginGuid,
                     "minsect",
                     tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_minsect.png"),
                     appearInTribeChoices: true,
                     choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_MARIO_minsect.png")
                  );
            }
            i++;
            {
                mbirdTribe = TribeManager.Add(
                     PluginGuid,
                     "mbird",
                     tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_mbird.png"),
                     appearInTribeChoices: true,
                     choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_MARIO_mbird.png")
                  );
            }
            i++;
            {
                mreptileTribe = TribeManager.Add(
                     PluginGuid,
                     "mreptile",
                     tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_mreptile.png"),
                     appearInTribeChoices: true,
                     choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_MARIO_mreptile.png")
                  );
            }
            i++;
            {
                mhoovedTribe = TribeManager.Add(
                     PluginGuid,
                     "mhooved",
                     tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_mhooved.png"),
                     appearInTribeChoices: true,
                     choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_MARIO_mhooved.png")
                  );
            }
            i++;
            {
                msquirrelTribe = TribeManager.Add(
                     PluginGuid,
                     "msquirrel",
                     tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_msquirrel.png"),
                     appearInTribeChoices: true,
                     choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_MARIO_msquirrel.png")
                  );
            }
            i++;
            {
                cloudTribe = TribeManager.Add(
                     PluginGuid,
                     "cloud",
                     tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_cloud.png"),
                     appearInTribeChoices: true,
                     choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_BASIC_cloud.png")
                  );
            }
            i++;
            {
                organTribe = TribeManager.Add(
                     PluginGuid,
                     "organ",
                     tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_organ.png"),
                     appearInTribeChoices: true,
                     choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_MARIO_organ.png")
                  );
            }
            i++;
            {
                itemboxTribe = TribeManager.Add(
                     PluginGuid,
                     "itembox",
                     tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_itembox.png"),
                     appearInTribeChoices: true,
                     choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_MARIO_itembox.png")
                  );
            }
            i++;
            {
                electricityTribe = TribeManager.Add(
                     PluginGuid,
                     "electricity",
                     tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_electricity.png"),
                     appearInTribeChoices: true,
                     choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_BASIC_electricity.png")
                  );
            }
            i++;
            {
                platformTribe = TribeManager.Add(
                     PluginGuid,
                     "platform",
                     tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_platform.png"),
                     appearInTribeChoices: true,
                     choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_MARIO_platform.png")
                  );
            }
            i++;
            Plugin.amalgramTribe = TribeManager.Add("tribes.libary", "amalgram", TextureHelper.GetImageAsTexture("tribeicon_amalgram.png", 0), true, TextureHelper.GetImageAsTexture("card_rewardback_NATURE_amalgram.png", 0));
            i++;
            Plugin.bonelessTribe = TribeManager.Add("tribes.libary", "boneless", TextureHelper.GetImageAsTexture("tribeicon_boneless.png", 0), true, TextureHelper.GetImageAsTexture("card_rewardback_UNDEAD_boneless.png", 0));
            i++;
            Plugin.fiendTribe = TribeManager.Add("tribes.libary", "fiend", TextureHelper.GetImageAsTexture("tribeicon_fiend.png", 0), true, TextureHelper.GetImageAsTexture("card_rewardback_BASIC_fiend.png", 0));
            i++;
            Plugin.foeTribe = TribeManager.Add("tribes.libary", "foe", TextureHelper.GetImageAsTexture("tribeicon_foe.png", 0), true, TextureHelper.GetImageAsTexture("card_rewardback_BASIC_foe.png", 0));
            i++;
            Plugin.friendTribe = TribeManager.Add("tribes.libary", "friend", TextureHelper.GetImageAsTexture("tribeicon_friend.png", 0), true, TextureHelper.GetImageAsTexture("card_rewardback_BASIC_friend.png", 0));
            i++;
            Plugin.frozenTribe = TribeManager.Add("tribes.libary", "frozen", TextureHelper.GetImageAsTexture("tribeicon_frozen.png", 0), true, TextureHelper.GetImageAsTexture("card_rewardback_BASIC_frozen.png", 0));
            i++;
            Plugin.gamerTribe = TribeManager.Add("tribes.libary", "gamer", TextureHelper.GetImageAsTexture("tribeicon_gamer.png", 0), true, TextureHelper.GetImageAsTexture("card_rewardback_BASIC_gamer.png", 0));
            i++;
            Plugin.gemsTribe = TribeManager.Add("tribes.libary", "gems", TextureHelper.GetImageAsTexture("tribeicon_gems.png", 0), true, TextureHelper.GetImageAsTexture("card_rewardback_MAGIKS_gems.png", 0));
            i++;
            Plugin.lichTribe = TribeManager.Add("tribes.libary", "lich", TextureHelper.GetImageAsTexture("tribeicon_lich.png", 0), true, TextureHelper.GetImageAsTexture("card_rewardback_MAGIKS_lich.png", 0));
            i++;
            Plugin.machineTribe = TribeManager.Add("tribes.libary", "machine", TextureHelper.GetImageAsTexture("tribeicon_machine.png", 0), true, TextureHelper.GetImageAsTexture("card_rewardback_TECH_machine.png", 0));
            i++;
            Plugin.malwareTribe = TribeManager.Add("tribes.libary", "malware", TextureHelper.GetImageAsTexture("tribeicon_malware.png", 0), true, TextureHelper.GetImageAsTexture("card_rewardback_TECH_malware.png", 0));
            i++;
            Plugin.psychicTribe = TribeManager.Add("tribes.libary", "psychic", TextureHelper.GetImageAsTexture("tribeicon_psychic.png", 0), true, TextureHelper.GetImageAsTexture("card_rewardback_MAGIKS_psychic.png", 0));
            i++;
            Plugin.robotTribe = TribeManager.Add("tribes.libary", "robot", TextureHelper.GetImageAsTexture("tribeicon_robot.png", 0), true, TextureHelper.GetImageAsTexture("card_rewardback_TECH_robot.png", 0));
            i++;
            Plugin.shapelessTribe = TribeManager.Add("tribes.libary", "shapeless", TextureHelper.GetImageAsTexture("tribeicon_shapeless.png", 0), true, TextureHelper.GetImageAsTexture("card_rewardback_BASIC_shapeless.png", 0));
            i++;
            Plugin.snakeTribe = TribeManager.Add("tribes.libary", "snake", TextureHelper.GetImageAsTexture("tribeicon_snake.png", 0), true, TextureHelper.GetImageAsTexture("card_rewardback_NATURE_snake.png", 0));
            i++;
            Plugin.spellcasterTribe = TribeManager.Add("tribes.libary", "spellcaster", TextureHelper.GetImageAsTexture("tribeicon_spellcaster.png", 0), true, TextureHelper.GetImageAsTexture("card_rewardback_MAGIKS_spellcaster.png", 0));
            i++;
            Plugin.treasureTribe = TribeManager.Add("tribes.libary", "treasure", TextureHelper.GetImageAsTexture("tribeicon_treasure.png", 0), true, TextureHelper.GetImageAsTexture("card_rewardback_BASIC_treasure.png", 0));
            i++;
            Plugin.treesTribe = TribeManager.Add("tribes.libary", "trees", TextureHelper.GetImageAsTexture("tribeicon_trees.png", 0), true, TextureHelper.GetImageAsTexture("card_rewardback_BASIC_trees.png", 0));
            i++;
            Plugin.virusTribe = TribeManager.Add("tribes.libary", "virus", TextureHelper.GetImageAsTexture("tribeicon_virus.png", 0), true, TextureHelper.GetImageAsTexture("card_rewardback_BASIC_virus.png", 0));
            i++;
            Plugin.warriorTribe = TribeManager.Add("tribes.libary", "warrior", TextureHelper.GetImageAsTexture("tribeicon_warrior.png", 0), true, TextureHelper.GetImageAsTexture("card_rewardback_BASIC_warrior.png", 0));
            i++;
            Plugin.wyrmTribe = TribeManager.Add("tribes.libary", "wyrm", TextureHelper.GetImageAsTexture("tribeicon_wyrm.png", 0), true, TextureHelper.GetImageAsTexture("card_rewardback_NATURE_wyrm.png", 0));
            i++;
            Plugin.hellionTribe = TribeManager.Add("tribes.libary", "hellion", TextureHelper.GetImageAsTexture("tribeicon_hellion.png", 0), true, TextureHelper.GetImageAsTexture("card_rewardback_UNDEAD_hellion.png", 0));
            i++;
            Plugin.werewolfTribe = TribeManager.Add("tribes.libary", "werewolf", TextureHelper.GetImageAsTexture("tribeicon_werewolf.png", 0), true, TextureHelper.GetImageAsTexture("card_rewardback_NATURE_werewolf.png", 0));
            i++;
            Plugin.shapeshifterTribe = TribeManager.Add("tribes.libary", "shapeshifter", TextureHelper.GetImageAsTexture("tribeicon_shapeshifter.png", 0), true, TextureHelper.GetImageAsTexture("card_rewardback_MAGIKS_shapeshifter.png", 0));
            i++;
            Plugin.wurmTribe = TribeManager.Add("tribes.libary", "wurm", TextureHelper.GetImageAsTexture("tribeicon_wurm.png", 0), true, TextureHelper.GetImageAsTexture("card_rewardback_NATURE_wurm.png", 0));
            i++;
            Plugin.thrullTribe = TribeManager.Add("tribes.libary", "thrull", TextureHelper.GetImageAsTexture("tribeicon_thrull.png", 0), true, TextureHelper.GetImageAsTexture("card_rewardback_BASIC_thrull.png", 0));
            i++;
            Plugin.tinyTribe = TribeManager.Add("tribes.libary", "tiny", TextureHelper.GetImageAsTexture("tribeicon_tiny.png", 0), true, TextureHelper.GetImageAsTexture("card_rewardback_BASIC_tiny.png", 0));
            i++;
            Plugin.kithkinTribe = TribeManager.Add("tribes.libary", "kithkin", TextureHelper.GetImageAsTexture("tribeicon_kithkin.png", 0), true, TextureHelper.GetImageAsTexture("card_rewardback_BASIC_kithkin.png", 0));
            i++;
            Plugin.gargoyleTribe = TribeManager.Add("tribes.libary", "gargoyle", TextureHelper.GetImageAsTexture("tribeicon_gargoyle.png", 0), true, TextureHelper.GetImageAsTexture("card_rewardback_BASIC_gargoyle.png", 0));
            i++;
            Plugin.handTribe = TribeManager.Add("tribes.libary", "hand", TextureHelper.GetImageAsTexture("tribeicon_hand.png", 0), true, TextureHelper.GetImageAsTexture("card_rewardback_BASIC_hand.png", 0));
            i++;
            Plugin.shadeTribe = TribeManager.Add("tribes.libary", "shade", TextureHelper.GetImageAsTexture("tribeicon_shade.png", 0), true, TextureHelper.GetImageAsTexture("card_rewardback_UNDEAD_shade.png", 0));
            i++;
            Plugin.slasherTribe = TribeManager.Add("tribes.libary", "slasher", TextureHelper.GetImageAsTexture("tribeicon_slasher.png", 0), true, TextureHelper.GetImageAsTexture("card_rewardback_BASIC_slasher.png", 0));
            i++;
            Plugin.necronTribe = TribeManager.Add("tribes.libary", "necron", TextureHelper.GetImageAsTexture("tribeicon_necron.png", 0), true, TextureHelper.GetImageAsTexture("card_rewardback_UNDEAD_necron.png", 0));
            i++;
            Plugin.nightmareTribe = TribeManager.Add("tribes.libary", "nightmare", TextureHelper.GetImageAsTexture("tribeicon_nightmare.png", 0), true, TextureHelper.GetImageAsTexture("card_rewardback_UNDEAD_nightmare.png", 0));
            i++;
            Plugin.specterTribe = TribeManager.Add("tribes.libary", "specter", TextureHelper.GetImageAsTexture("tribeicon_specter.png", 0), true, TextureHelper.GetImageAsTexture("card_rewardback_UNDEAD_specter.png", 0));
            i++;
            Plugin.scarecrowTribe = TribeManager.Add("tribes.libary", "scarecrow", TextureHelper.GetImageAsTexture("tribeicon_scarecrow.png", 0), true, TextureHelper.GetImageAsTexture("card_rewardback_BASIC_scarecrow.png", 0));
            i++;
            Plugin.horrorTribe = TribeManager.Add("tribes.libary", "horror", TextureHelper.GetImageAsTexture("tribeicon_horror.png", 0), true, TextureHelper.GetImageAsTexture("card_rewardback_UNDEAD_horror.png", 0));
            i++;
            Plugin.oozeTribe = TribeManager.Add("tribes.libary", "ooze", TextureHelper.GetImageAsTexture("tribeicon_ooze.png", 0), true, TextureHelper.GetImageAsTexture("card_rewardback_BASIC_ooze.png", 0));
            i++;
            Plugin.natureTribe = TribeManager.Add("tribes.libary", "nature", TextureHelper.GetImageAsTexture("tribeicon_nature.png", 0), true, TextureHelper.GetImageAsTexture("card_rewardback_NATURE_nature.png", 0));
            i++;
            Plugin.wingedbeastTribe = TribeManager.Add("tribes.libary", "wingedbeast", TextureHelper.GetImageAsTexture("tribeicon_wingedbeast.png", 0), true, TextureHelper.GetImageAsTexture("card_rewardback_NATURE_wingedbeast.png", 0));
            i++;
            Plugin.divinebeastTribe = TribeManager.Add("tribes.libary", "divinebeast", TextureHelper.GetImageAsTexture("tribeicon_divinebeast.png", 0), true, TextureHelper.GetImageAsTexture("card_rewardback_NATURE_divinebeast.png", 0));
            i++;
            Plugin.planetTribe = TribeManager.Add("tribes.libary", "planet", TextureHelper.GetImageAsTexture("tribeicon_planet.png", 0), true, TextureHelper.GetImageAsTexture("card_rewardback_BASIC_planet.png", 0));
            i++;
            Plugin.planetTribe = TribeManager.Add("tribes.libary", "pokemon", TextureHelper.GetImageAsTexture("tribeicon_pokemon.png", 0), true, TextureHelper.GetImageAsTexture("card_rewardback_BASIC_pokemon.png", 0));
            i++;
            Logger.LogInfo($"Sucsessfully Loaded {i} tribe(s)!");
        }
    }
}
