using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ChessLogic
{
    // stores the players' turn, who wins the game and colour of chess pieces
    public enum Player
    {
        None,
        White,
        Black
    }
    public static class PlayerExtensions
    {
        public static Player Opponent(this Player player)
        {
            return player switch
            {
                Player.White => Player.Black, // case 1:
                Player.Black => Player.White, // case 2:
                _ => Player.None, // default:
            };
        }
    }
}