﻿namespace Sorting_Report
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

        /******************************************************
         * 선형 정렬
         * 
         * 1개의 요소를 재위치시키기 위해 전체를 확인하는 정렬
         * n개의 요소를 재위치시키기 위해 n개를 확인하는 정렬
         * 시간복잡도 : O(N^2)
         ******************************************************/


        // <선택정렬>
        // 데이터 중 가장 작은 값부터 하나씩 선택하여 정렬
        // 배열에서 가장작은 값을 맨앞으로 위치 변환하고 고정
        // 두번째 위치에도 똑같이 그다음 작은 값을 위치 옴기고 고정
        // 이 과정은 배열 크기만큼 반복진행함
        // 배열 맨첨부터 배열크기까지 순차적으로 진행
        // 현재 선택된 값과 다른값 비교
        // 전체 비교해서 가장 작은값 선정

        // <삽입정렬>
        // 데이터를 하나씩 꺼내어 정렬된 자료 중 적합한 위치에 삽입하여 정렬
        // 배열 처음부터 배열크기까지 순차적으로 진행하면서 각 요소마다 이미 선정된 정렬에
        // 위치를 선정하고 정렬시키는 정렬
        // 해당 자리의 수를 앞에 자리수와 비교해서 앞수보다 작으면 앞으로 이동

        // <버블정렬>
        // 서로 인접한 데이터를 비교하여 정렬
        // 맨앞에서 부터 뒤로 옮겨지는 정렬로 두수를 비교해서 큰수가 뒤로 옮겨지는 정렬이다
        // 크면 옮기고 안크면 그 다음수로 비교하고 뒤에 고정되면 다시 맨처음부터 과정을 진행한다
        // 배열전체를 접근을 하기에 최적화면에서 좋은 효과를 나타낸다

        /******************************************************
        * 분할정복 정렬
        * 
        * 1개의 요소를 재위치시키기 위해 전체의 1/2를 확인하는 정렬
        * n개의 요소를 재위치시키기 위해 n/2개를 확인하는 정렬
        * 시간복잡도 : O(NlogN)
        ******************************************************/

        // <힙정렬>
        // 힙을 이용하여 우선순위가 가장 높은 요소부터 가져와 정렬
        // 배열의 힙상태를 이용한 정렬
        // 불안정정렬 (깨지는 정렬)
        // 다른 장점에 비해 메모리부담이 있음
        // 많은 데이터를 정렬시킬때 좋은 효율을 볼수있다
        // 동일한 데이터의 정렬위치를 보장이 안됨(안정성이 깨질수있음)
        // 캐쉬메모리에 부담을 주는 방식이 있어서 퀵정렬보다 느린속도를 가진다 (배열탐색에 새로운 메모리를 가저와서 속도가 느려짐)
        // 우선순위큐에 데이터를 넣고
        // 전부 꺼내면 우선순위큐는 우선순위가 높은순으로
        // 호출하기 때문에 우선순위순으로 정렬이 되어있다

        // <합병정렬>
        // 데이터를 2분할하여 정렬 후 합병
        // 하나의 피벗(기준점)을 기준으로 작은값과 큰값을 2분할하여 정렬
        // 더이상 쪼개지지 않을 단위까지 쪼갠다음 비교하고 합병 비교하고 합병하는 과정을 진행한다
        // 반분할된 정렬을 따로 갖고있어야되기 때문에 메모리공간을 차지하게 된다
        // 메모리공간을 찾기위해 오버헤드가 발생할수있음


        // <퀵정렬>
        // 다른정렬과 다르게 메모적 부담이 있음
        // 불안정정렬 (깨지는 정렬)
        // 피벗을 가운데로 작은값은 왼쪽 큰값은 오른쪽으로 보낸뒤 분할된 배열에서도 피벗을 정한고 정렬하고
        // 모든 수가 피벗이 되면 정렬이 완성된다
        // 반분할을 가정상으로 해서 메모리적으로 부담은 없다(일반 배열에서 피벗을 기준으로 왼쪽 오른쪽 위치만 변경)
        // 순차적인 배열에서 역순인 경우 시간복잡도가 O(n^2)이 되는 최악의 효율도가 나온다 (최악의 경우)



        static void Main(string[] args)
        {
            
        }
    }
}