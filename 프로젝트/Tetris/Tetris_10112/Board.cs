﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris_10112
{
    internal class Board
    {
        internal static Board GameBoard
        {
            get;
            private set;
        }

        static Board()
        {
            GameBoard = new Board();
        }

        int[,] board = new int[GameRule.BX, GameRule.BY];

        internal int this[int x, int y]
        {
            get
            {
                return board[x, y];
            }
        }

        internal bool MoveEnable(int bn, int tn, int x, int y)
        {
            for(int xx =0; xx < 4; xx++)
            {
                for(int yy =0; yy < 4; yy++)
                {
                    if(BlockValue.bvals[bn, tn, xx, yy] != 0)
                    {
                        if(board[x + xx, y + yy] != 0)
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }

        internal void Store(int bn, int turn, int x, int y)
        {
            for(int xx = 0; xx < 4; xx++)
            {
                for(int yy =0; yy < 4; yy++)
                {
                    if((x+ xx >= 0) && (x + xx < GameRule.BX) && (y + yy >= 0) && (y + yy < GameRule.BY))
                    {
                        board[x + xx, y + yy] += BlockValue.bvals[bn, turn, xx, yy];
                    }
                }
            }
            CheckLines(y + 3);
        }

        private void CheckLines(int y)
        {
            int yy = 0;
            for(yy = 0; yy < 4; yy++)
            {
                if(y - yy > 0 )
                {
                    if(CheckLine(y - yy))
                    {
                        ClearLine(y - yy);
                        y++;
                    }
                }
            }
        }

        private void ClearLine(int y)
        {
            for (; y > 0; y--)
            {
                for (int xx = 0; xx < GameRule.BX; xx++) // 윗줄을 아랫줄에 복사
                {
                    board[xx, y] = board[xx, y + 1]; // y + 1로 변경 후 윗줄 복사
                }
            }
            Form1.score += 100;
        }

        private bool CheckLine(int y)
        {
            for(int xx = 0; xx < GameRule.BX; xx++)
            {
                if(board[xx, y] == 0)
                {
                    return false;
                }
            }
            return true;
        }

        internal void ClearBoard()
        {
            for(int xx = 0; xx < GameRule.BX; xx++)
            {
                for(int yy = 0; yy < GameRule.BY; yy++)
                {
                    board[xx, yy] = 0;
                }
            }
        }
    }
}
