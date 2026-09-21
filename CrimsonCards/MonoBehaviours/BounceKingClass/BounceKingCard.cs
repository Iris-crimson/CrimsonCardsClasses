using UnityEngine;
using UnboundLib.GameModes;
using System.Collections;

namespace CrimsonCards.MonoBehaviours
{
    class BounceKingCard : MonoBehaviour
    {
        // Get player data and stats
        private Player player;
        private Gun gun;
        private GunAmmo gunAmmo;


        // Number of class cards this.player has
        public int numCards = 0;

        // Locks some stats
        public int bounce = 15;

        public void Awake()
        {
            player = this.gameObject.GetComponentInParent<Player>();
            gun = this.player.GetComponent<Holding>().holdable.GetComponent<Gun>();

            GameModeManager.AddHook(GameModeHooks.HookPickEnd, OnPickEnd);
        }

        public void Start()
        {
            setStats();
        }

        // Runs when card pick ends
        public IEnumerator OnPickEnd(IGameModeHandler gm)
        {
            setStats();
            gun.reflects += ((numCards * 15));
            yield break;
        }

        private void setStats()
        {
            gun.reflects = bounce;
        }
    }
}