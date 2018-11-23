using System;
using Monopoly.Player;

namespace Monopoly.Utility
{
    class GlobalStorage
    {
        public static Action OnPlayerTurnCompleted;
        public static Action<Player.Player> OnNextPlayerTurn;
        public static Action OnDiceRollComplete;
        
        public static int[] dice = new int[2];
        public static int playerTurn = 0;
    }
}
