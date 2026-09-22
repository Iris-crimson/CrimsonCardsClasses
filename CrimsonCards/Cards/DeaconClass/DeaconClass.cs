using ClassesManagerReborn;
using System.Collections;

namespace CrimsonCards.Cards.DeaconClass
{
    class DeaconClass : ClassHandler
    {
        public static string name = "Deacon";

        public override IEnumerator Init()
        {
            while (!(Deacon.Card && FocusedPrayer.Card && PrayeroftheMagdump.Card && PrayerofGrandeur.Card)) yield return null;
            ClassesRegistry.Register(Deacon.Card, CardType.Entry);
            ClassesRegistry.Register(FocusedPrayer.Card, CardType.Card, Deacon.Card, 2);
            ClassesRegistry.Register(PrayeroftheMagdump.Card, CardType.Card, Deacon.Card, 3);
            ClassesRegistry.Register(PrayerofGrandeur.Card, CardType.Card, Deacon.Card, 4);
        }
    }
}