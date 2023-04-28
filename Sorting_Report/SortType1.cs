using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Report
{
    public class SortType1
    {
        private static void Swap(IList<int> list, int left, int right)
        {
            int temp = list[left];
            list[left] = list[right];
            list[right] = temp;
        }
        /******************************************************
         * 선형 정렬
         * 
         * 1개의 요소를 재위치시키기 위해 전체를 확인하는 정렬
         * n개의 요소를 재위치시키기 위해 n개를 확인하는 정렬
         * 시간복잡도 : O(N^2)
         ******************************************************/

        /*******************************************************
         * <선택정렬(Selection Sort)>
         * 정렬 되지 않은 순열 중 가장 작은 값를 찾아 첫번째 값와 위치를 
         * 바꾸는 방식으로 정렬을 하는 알고리즘이다
         * 배열의 맨앞에서 부터 시작하여 길이만큼 값들과 비교하여 
         * 가장 작은값을 맨앞에 위치시키고 고정한 다음 그 다음 값도 
         * 같은 과정을 정렬하기 위치 변환을 반복한다
         * 기본 오름차순이지만 최대 선택정렬(Max-Selection Sort)로 진행하면
         * 내림차순으로 진행되고 정렬된다
         * 배열 전체를 비교하여 진행하므로 시간복잡도는 O(n^2)이다
         *******************************************************/
        public static void Selection(IList<int> list)
        {
            for (int i =0; i < list.Count -1; i++)                     // 배열 크기만큼 반복
            {
                int minValue = i;
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (list[j] < list[minValue])
                    {
                        minValue = j;
                    }
                }
                Swap(list, i, minValue);
            }
        }

       
        /*******************************************************
        * <삽입정렬(Insertion Sort)>
        * 정렬되지 않은 배열에서, 배열 맨앞에서 두번째 값부터 해당 데이터의 앞쪽으로 탐색해가며 
        * 적절한 위치에 값을 삽입하여 정렬하는 알고리즘이다
        * 해당 값을 별도로 꺼내어 해당 위치의 앞부분과 비교하여 해당값이 더 작을경우 위치를 바꾼다
        * 기본적으로 오름차순이며 최악의 경우 시간복잡도가 O(N^2)수준이지만 최선의 경우 O(N)으로
        * 배열의 상태의 따라 효율도가 다르다
        *******************************************************/

        public static void Insert(IList<int> list)
        {
           for (int i = 1; i < list.Count; i++)                     
            {
                int key = list[i];
                int j;
                for (j = i - 1; j >= 0 && key < list[j]; j--)           
                {
                    list[j + 1] = list[j];
                }
                list[j + 1] = key;
            }
        } 

        /*******************************************************
        * <버블정렬(Bubble Sort)>
        * 서로 인접한 두 데이터가 서로 비료하여 정한 기준대로 해당 데이터를 뒤로 넘겨 정렬하는 알고리즘이다
        * 알고리즘은 배열의 첫번째와 두번째 비교하고 그다음 으로 순차적으로 배열길이 만큼 진행하여 배열뒤부터
        * 정렬이 이뤄지는 과정을 반복한다 
        * 배열전체를 탐색하는 만큼 시간복잡도는 O(n^2)이지만 
        * 한그룹(데이터 두개)씩 배열길이만큼 비교하기애 
        * 안정성이 높고 최적화면에서 좋은 정렬중 하나다
        *******************************************************/
    }
}
