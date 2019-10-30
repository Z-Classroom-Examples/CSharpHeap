using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Heap
{
    public class Heap
    {
        private const int MaxHeap = 100;
        private readonly int[] _nodes = new int[MaxHeap];
        private int _lastNode = 1;

        public void Insert(int item)
        {
            if (_lastNode < MaxHeap)
            {
                _nodes[_lastNode++] = item;
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
            HeapifyUp();
        }

        private void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        

        public int Remove()
        {
            if (_lastNode >= 0)
            {
                int result = _nodes[1];
                _nodes[1] = _nodes[_lastNode-1];
                _lastNode--;
                HeapifyDown();
                return result;
            }
            throw new ArgumentOutOfRangeException();
            
        }

        public void Display()
        {
            for(var i=1;i < _lastNode;i++)
            {
                Console.Write($" {_nodes[i]} ");
            }
            Console.WriteLine();

        }

        private void HeapifyDown()
        {
            int parentIndex = 1;
            int leftChildIndex = parentIndex * 2;
            int rightChildIndex = parentIndex * 2 + 1;
            while (parentIndex < _lastNode && leftChildIndex < _lastNode)
            {
                int maxIndex = leftChildIndex;
                if (rightChildIndex < _lastNode)
                {
                    maxIndex = _nodes[leftChildIndex] < _nodes[rightChildIndex] ? leftChildIndex : rightChildIndex;
                }
                Swap(ref _nodes[parentIndex], ref _nodes[maxIndex]);

                parentIndex = maxIndex;
                leftChildIndex = parentIndex * 2;
                rightChildIndex = parentIndex * 2 + 1;
            }
        }


        private void HeapifyUp()                            
        {
            var holeToExamine = _lastNode-1;
            int parent = holeToExamine / 2;
            while (_nodes[parent] > _nodes[holeToExamine])
            {
                Swap(ref _nodes[parent], ref _nodes[holeToExamine]);
                holeToExamine = parent;
                parent = holeToExamine / 2;
            }                              
        }
    }
}
