using System;

namespace MMORPG_게임개발_시리즈_CSharp__자료구조와_알고리즘
{
    internal class Sample
    {
        static void Main(string[] args)
        {
            #region 변수 관리
            Console.CursorVisible = false;

            string CIRCLE = "\u25cf";

            const int WAIT_TICK = 1000 / 30;
            int lastTick = 0;
            #endregion

            while (true)
            {
                #region 프레임 관리
                int currentTick = System.Environment.TickCount;
                int elapsedTick = currentTick - lastTick; // = 경과시간

                if (elapsedTick < WAIT_TICK)
                {
                    continue;
                }
                lastTick = currentTick;
                #endregion

                // 입력

                // 로직

                // 렌더링

                Console.SetCursorPosition(0, 0);

                for (int i = 0; i < 25; i++)
                {
                    for (int j = 0; j < 25; j++)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(CIRCLE);
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
