using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using System.Collections;
using System.Threading;

namespace Lift
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("������� ���������� ������");
            int countOfloor = Int32.Parse(Console.ReadLine());

            Console.WriteLine("�������� ����� ������ �����. ������� 1 ��� 2");
            int modeOfLift = Int32.Parse(Console.ReadLine());

            Console.WriteLine("� �� 1 �����. ������� �����");

            switch (modeOfLift)
            {
                case 1:
                    StartLiftWithQueue(countOfloor);
                    break;
                case 2:
                    StartLiftWithStack(countOfloor);
                    break;
                default:
                    Console.WriteLine("������ ������ ���");
                    break;
            }
        }

        static void StartLiftWithQueue(int countOfloor)
        {
            Queue<int> q = new Queue<int>();
            int floorForCollection;
            int currentFloor = 1;

            for (int i = 0; i < 3; i++)
            {
                floorForCollection = Int32.Parse(Console.ReadLine());
                if (floorForCollection > countOfloor)
                {
                    Console.WriteLine("� ���� ��� ������� ������");
                    break;
                }
                else
                {
                    q = QueueMode(q, floorForCollection);
                }
            }

            Console.WriteLine("������� ��������");
            var nextFloor = q.Dequeue();

            for (; ; )
            {
                if (nextFloor > currentFloor)
                {
                    Thread.Sleep(1000);
                    currentFloor++;
                    Console.WriteLine($"������� ���� {currentFloor}");

                }
                else if (nextFloor < currentFloor)
                {
                    Thread.Sleep(1000);
                    currentFloor--;
                    Console.WriteLine($"������� ���� {currentFloor}");
                }
                else if (currentFloor == nextFloor)
                {
                    Console.WriteLine($"��������� {nextFloor}");
                    if (q.Count != 0)
                    {
                        nextFloor = q.Dequeue();
                        Console.WriteLine($"��������� ����� ��������� {nextFloor}");
                    }
                    else
                    {
                        Console.WriteLine("������� �����. ������� ��������� ����");
                        break;
                    }
                }
            }
        }

        static void StartLiftWithStack(int countOfloor)
        {
            int currentFloor = 1;
            Stack<int> s = new Stack<int>();
            int floorForCollection;

            for (int i = 0; i < 3; i++)
            {
                floorForCollection = Int32.Parse(Console.ReadLine());

                if (floorForCollection > countOfloor)
                {
                    Console.WriteLine("� ���� ��� ������� ������");
                    break;
                }
                else
                {
                    s = StackMode(s, floorForCollection);
                }
            }

            Console.WriteLine("������� ��������");
            var nextFloor = s.Pop();

            for (; ; )
            {
                if (nextFloor > currentFloor)
                {
                    Thread.Sleep(1000);
                    currentFloor++;
                    Console.WriteLine($"������� ���� {currentFloor}");

                }
                else if (nextFloor < currentFloor)
                {
                    Thread.Sleep(1000);
                    currentFloor--;
                    Console.WriteLine($"������� ���� {currentFloor}");
                }
                else if (currentFloor == nextFloor)
                {
                    Console.WriteLine($"��������� {nextFloor}");

                    if (s.Count != 0)
                    {
                        nextFloor = s.Pop();
                        Console.WriteLine($"��������� ����� ��������� {nextFloor}");
                    }
                    else
                    {
                        Console.WriteLine("������� �����. ������� ��������� ����");
                        break;
                    }
                }
            }
        }

        static Queue<int> QueueMode(Queue<int> queue, int floor)
        {
            queue.Enqueue(floor);
            Console.WriteLine($"� queue �������� {floor}");
            return queue;
        }

        static Stack<int> StackMode(Stack<int> stack, int floor)
        {
            stack.Push(floor);
            Console.WriteLine($"� stack �������� {floor}");
            return stack;
        }
    }
}



