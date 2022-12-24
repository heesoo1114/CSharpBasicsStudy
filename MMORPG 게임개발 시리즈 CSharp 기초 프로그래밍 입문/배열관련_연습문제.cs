using System;

namespace MMORPG_게임개발_시리즈_CSharp_기초_프로그래밍_입문
{
    internal class Test
    {
        #region 나의 풀이
        // 가장 큰 값을 반환
        static int GetHightestScore(int[] scores)
        {
            int result = scores[0];

            for (int i = 0; i < scores.Length; i++)
            {
                if (result <= scores[i]) // 크기 비교
                {
                    // 크면 result에 대입
                    result = scores[i];
                }
            }

            return result;
        }

        // 평균 구하기
        static int GetAverageScore(int[] scores)
        {
            int sum = 0; 
            
            foreach (int score in scores)
            {
                // sum에 다 더해줌
                sum += score;
            }

            // 다 더해진 값에 length로 나누기
            return sum / scores.Length;
        }

        // value가 있으면 몇 번째에 있는지 없으면 없다고 알려줌
        static int GetIndexOf(int[] scores, int value)
        {
            for (int i = 0; i < scores.Length; i++)
            {
                if (scores[i] == value) // 받아온 인수 value와 scores[i]가 같으면
                {
                    // 몇 번째인지 반환
                    return i;
                }
            }

            return -1;
        }

        // 오름차순 정렬
        static void Sort(int[] scores)
        {
            int[] sort = new int[scores.Length];

            for (int i = 0; i < scores.Length; i++)
            {
                for (int j = 0; j < scores.Length; j++)
                {
                    if (scores[i] >= scores[j])
                    {
                        sort[i] = scores[j];
                    }
                }
            }

            for (int i = 0; i < sort.Length; i++)
            {
                Console.WriteLine(sort[i]);
            }
        }

        static void Main()
        {
            int[] scores = new int[5] { 10, 50, 40, 20, 30 };

            // Console.WriteLine(GetHightestScore(scores));
            // Console.WriteLine(GetAverageScore(scores));
            // Console.WriteLine(GetIndexOf(scores, 20));
            Sort(scores);
        }
        #endregion

        #region 강의에서 풀어주는 풀이
        /*static int GetHightestScore(int[] scores)
        {
            return 0;
        }

        static int GetAverageScore(int[] scores)
        {
            return 0;
        }

        static int GetIndexOf(int[] scores, int value)
        {
            return 0;
        }

        static int Sort(int[] scores)
        {

        }

        static void Main()
        {
            int[] scores = new int[5] { 10, 30, 40, 20, 50 };
        }*/
        #endregion
    }
}
