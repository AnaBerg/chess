using Chess.board;
using System;


namespace Chess {
    class Program {
        static void Main(string[] args) {

            Board p = new Board(8, 8);

            Screen.printBoard(p);

        }
    }
}
