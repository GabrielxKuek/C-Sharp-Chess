using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLogic
{
    // this is what the ui will interact with
    public class GameState
    {
        public Board Board { get; }
        public Player CurrentPlayer { get; private set; }
        public GameState(Player player, Board board)
        {
            CurrentPlayer = player;
            Board = board;
        }
    }
}