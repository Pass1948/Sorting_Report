﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Report
{
    internal class SortType2
    {
        private static void Swap(IList<int> list, int left, int right)
        {
            int temp = list[left];
            list[left] = list[right];
            list[right] = temp;
        }
        /******************************************************
       * 분할정복 정렬
       * 
       * 1개의 요소를 재위치시키기 위해 전체의 1/2를 확인하는 정렬
       * n개의 요소를 재위치시키기 위해 n/2개를 확인하는 정렬
       * 시간복잡도 : O(NlogN)
       ******************************************************/

        /*******************************************************
        * <힙정렬(Heap Sort)>
        * 트리기반으로 배열의 힙상태를 유지하는 정렬을 보여주는 알고리즘이다
        * 우선순위를 기준으로 정렬되어 비교적 많은 데이터량을 가진 배열을
        * 정렬하는데애 시간복잡도 O(N logN)에서 최선일경우 O(n)의 효율성을 보이지만
        * 연속적인 메모리할당이 아니라서 범위를 벗어난 인덱스가 있을경우 새로운 메모리공간을
        * 추가해야 하기애 컴퓨터 메모리 구조상 캐쉬메모리에 부담을 주어 
        * 다른 종류의 정렬 알고리즘들에 비해 속도가 느린 편에 속한다
        * 또한 동일한 값을 가진 데이터를 정렬하는데 위치를 보장 하지않아 안정성면에서 다소 
        * 불안정한정렬을 보여주는 깨지는 정렬이이다
        *******************************************************/
        public static void Heap(IList<int> list)
        {
            PriorityQueue<int, int> pq = new PriorityQueue<int, int>();

            for (int i = 0; i < list.Count; i++)            
            {
                pq.Enqueue(list[i], list[i]);
            }

            for (int i = 0; i < list.Count; i++)            
                                                            
            {
                list[i] = pq.Dequeue();
            }
        }
        /*******************************************************
        * <합병정렬(Merge Sort)>
        * 정렬되지 않은 배열을 2분할 하고 정렬하여 합병하는 알고리즘으로
        * 2분할 하는 과정을 더이상 나눌수없는 단위까지 진행한후 그 반대의 순으로
        * 합병을 진행하면서 서로 비교하여 정렬을 진행한다
        * 본래의 배열의 반분할하여 다시 정렬되 형태로 합병하는 방식이라 안정성이 보장되지만
        * 반분할된 배열을 따로 갖기에 별도의 메모리공간을 차지하며 컴퓨터상의 
        * 미리 메모리공간을 배치해야하는 오버헤드가 발생할수있다
        *******************************************************/
        public static void Merge(IList<int> list, int left, int right)
        {
            if (left == right) return;

            int mid = (left + right) / 2;
            Merge(list, left, mid);
            Merge(list, mid + 1, right);
            Merge(list, left, mid, right);
        }
        public static void Merge(IList<int> list, int left, int mid, int right)
        {
            List<int> sortedList = new List<int>();
            int leftIndex = left;
            int rightIndex = mid + 1;

            while (leftIndex <= mid && rightIndex <= right)
            {
                if (list[leftIndex] < list[rightIndex])
                    sortedList.Add(list[leftIndex++]);
                else
                    sortedList.Add(list[rightIndex++]);
            }
            if (leftIndex > mid)    
            {
                for (int i = rightIndex; i <= right; i++)
                    sortedList.Add(list[i]);
            }
            else  
            {
                for (int i = leftIndex; i <= mid; i++)
                    sortedList.Add(list[i]);
            }
            for (int i = left; i <= right; i++)
            {
                list[i] = sortedList[i - left];
            }
        }
        /*******************************************************
        * <퀵정렬(Quick Sort)>
        * 정렬되지 않은 배열에서 하나의 배열요소에 피벗(기준점)을 정하고 
        * 정한 피벗을 기준으로 양쪽으로 2분할하여 정렬하는 알고리즘으로
        * 대부분 맨앞의 값을 피벗으로 삼고 진행하며 하나의 피벗으로 정렬이 되면
        * 그다음 값을 피벗으로 정하고 다시 정렬을 하는 과정을 반복하며
        * 피벗된 값은 위치가 고정되고 모든 요소가 피벗이 될때
        * (분할된 배열의 크기가 1이된 상태) 정렬이 완성되게 된다
        * 2분할된 배열에서 양쪽으로 교차되는 배치가 일어나게 되는 경우 동일한 값을
        * 교차하여 재배치하게 되는 불안정한 상황이 발생할수가 있어 퀵정렬 또한
        * 안정성이 깨지는 정렬에 속한다
        * 평소 O(N log N)의 시간복잡도 효율을 내지만
        * 만약 순차적으로 정렬된 배열을 역순으로 재정렬을 할경우
        * 시간복잡도상의 최악의 상황으로 O(n^2)의 효율을 내게된다
        *******************************************************/
        public static void Quick(IList<int> list, int start, int end)
        {
            if (start >= end) return;

            int pivotIndex = start;                         
            int leftIndex = pivotIndex + 1;
            int rightIndex = end;

            while (leftIndex <= rightIndex) 
            {
                while (list[leftIndex] <= list[pivotIndex] && leftIndex < end)
                    leftIndex++;
                while (list[rightIndex] >= list[pivotIndex] && rightIndex > start)
                    rightIndex--;

                if (leftIndex < rightIndex)     
                    Swap(list, leftIndex, rightIndex);
                else    
                    Swap(list, pivotIndex, rightIndex);
            }

            Quick(list, start, rightIndex - 1);       
            Quick(list, rightIndex + 1, end);         
        }
    }
}
