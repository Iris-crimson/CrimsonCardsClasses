using ClassesManagerReborn;
using System.Collections;

namespace CrimsonCards.Cards.BounceKingClass
{
    class BounceKingClass : ClassHandler
    {
        public static string name = "Bounce King";

        public override IEnumerator Init()
        {
            while (!(BounceKing.Card && LordOfRicochet.Card && ProtectiveCoating.Card && Unpredictability.Card)) yield return null;
            ClassesRegistry.Register(BounceKing.Card, CardType.Entry);
            ClassesRegistry.Register(LordOfRicochet.Card, CardType.Card, BounceKing.Card, 2);
            ClassesRegistry.Register(ProtectiveCoating.Card, CardType.Card, BounceKing.Card, 3);
            ClassesRegistry.Register(Unpredictability.Card, CardType.Card, BounceKing.Card, 4);
        }
    }
}