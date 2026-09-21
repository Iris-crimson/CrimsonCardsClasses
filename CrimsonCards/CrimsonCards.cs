using BepInEx;
using UnboundLib.Cards;
using HarmonyLib;
using CardChoiceSpawnUniqueCardPatch.CustomCategories;
using System.Net.NetworkInformation;
using CrimsonCards.Cards;
using CrimsonCards.Cards.BounceKingClass;

namespace CrimsonCards
{
    [BepInDependency("com.willis.rounds.unbound", BepInDependency.DependencyFlags.HardDependency)]
    [BepInDependency("pykess.rounds.plugins.moddingutils", BepInDependency.DependencyFlags.HardDependency)]
    [BepInDependency("pykess.rounds.plugins.cardchoicespawnuniquecardpatch", BepInDependency.DependencyFlags.HardDependency)]
    [BepInDependency("root.classes.manager.reborn", BepInDependency.DependencyFlags.HardDependency)]

    [BepInPlugin(ModId, ModName, Version)]

    [BepInProcess("Rounds.exe")]
    public class CrimsonCards : BaseUnityPlugin
    {
        private const string ModId = "com.iriscrimson.rounds.CrimsonCards";
        private const string ModName = "Crimson Cards";
        private const string Version = "1.0.0";
        public const string ModInitials = "CC";
        public static CrimsonCards instance { get; private set; }

        void Awake()
        {
            var harmony = new Harmony(ModId);
            harmony.PatchAll();
        }
        void Start()
        {
            instance = this;
            CustomCard.BuildCard<BounceKing>((card => BounceKing.Card = card));
            CustomCard.BuildCard<LordOfRicochet>((card => LordOfRicochet.Card = card));
            CustomCard.BuildCard<Unpredictability>((card => Unpredictability.Card = card));
            CustomCard.BuildCard<ProtectiveCoating>((card => ProtectiveCoating.Card = card));
        }
    }
}