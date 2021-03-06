using System;
using Chess.board;

namespace Chess {
    class Screen {
        public static void printBoard(Board board) { 
            for (int i = 0; i < board.lines; i++) {
                for (int j = 0; j < board.columns; j++) {
                    if (board.piece(i, j) == null) {
                        Console.Write(" -");
                    } else {
                        Console.Write(board.piece(i, j) + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
