using System.Collections.Generic;

namespace Sorting_Report
{
    internal class Program
    {
        /*******************************************************
         * 선택정렬 : 데이터 중 가장 작은 값부터 하나씩 선택하여 정렬
         * 삽입정렬 : 데이터를 하나씩 꺼내어 정렬된 자료 중 적합한 위치에 삽입하여 정렬
         * 버블정렬 : 서로 인접한 데이터를 비교하여 정렬
         * 합병정렬 : 데이터를 2분할하여 정렬 후 합병
         * 퀵정렬 : 하나의 피벗을 기준으로 작은값과 큰값을 2분할하여 정렬
         *******************************************************/

        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(3);
            list.Add(6);
            list.Add(1);
            list.Add(5);
            list.Add(2);
            list.Add(4);
            int left = 0;
            int right = 0;
            int start = 0;
            int end = 0;

            Console.WriteLine("=========================");
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            Console.WriteLine("=========================");
            //SortType1.Selection(list);
            //SortType1.Insert(list);
            //SortType1.Bubble(list);
            //SortType2.Heap(list);
            //SortType2.Merge(list, left, right);
            //SortType2.Quick(list, start, end);
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }




        }
    }
}