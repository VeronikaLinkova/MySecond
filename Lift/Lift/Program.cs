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
            Console.WriteLine("Введите количество этажей");
            int countOfloor = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Выберите режим работы лифта. Введите 1 или 2");
            int modeOfLift = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Я на 1 этаже. Введите этажи");

            switch (modeOfLift)
            {
                case 1:
                    StartLiftWithQueue(countOfloor);
                    break;
                case 2:
                    StartLiftWithStack(countOfloor);
                    break;
                default:
                    Console.WriteLine("Такого режима нет");
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
                    Console.WriteLine("В доме нет столько этажей");
                    break;
                }
                else
                {
                    q = QueueMode(q, floorForCollection);
                }
            }

            Console.WriteLine("Начинаю движение");
            var nextFloor = q.Dequeue();

            for (; ; )
            {
                if (nextFloor > currentFloor)
                {
                    Thread.Sleep(1000);
                    currentFloor++;
                    Console.WriteLine($"Текущий этаж {currentFloor}");

                }
                else if (nextFloor < currentFloor)
                {
                    Thread.Sleep(1000);
                    currentFloor--;
                    Console.WriteLine($"Текущий этаж {currentFloor}");
                }
                else if (currentFloor == nextFloor)
                {
                    Console.WriteLine($"Остановка {nextFloor}");
                    if (q.Count != 0)
                    {
                        nextFloor = q.Dequeue();
                        Console.WriteLine($"Следующая точка остановки {nextFloor}");
                    }
                    else
                    {
                        Console.WriteLine("Очередь пуста. Задайте следующий этаж");
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
                    Console.WriteLine("В доме нет столько этажей");
                    break;
                }
                else
                {
                    s = StackMode(s, floorForCollection);
                }
            }

            Console.WriteLine("Начинаю движение");
            var nextFloor = s.Pop();

            for (; ; )
            {
                if (nextFloor > currentFloor)
                {
                    Thread.Sleep(1000);
                    currentFloor++;
                    Console.WriteLine($"Текущий этаж {currentFloor}");

                }
                else if (nextFloor < currentFloor)
                {
                    Thread.Sleep(1000);
                    currentFloor--;
                    Console.WriteLine($"Текущий этаж {currentFloor}");
                }
                else if (currentFloor == nextFloor)
                {
                    Console.WriteLine($"Остановка {nextFloor}");

                    if (s.Count != 0)
                    {
                        nextFloor = s.Pop();
                        Console.WriteLine($"Следующая точка остановки {nextFloor}");
                    }
                    else
                    {
                        Console.WriteLine("Очередь пуста. Задайте следующий этаж");
                        break;
                    }
                }
            }
        }

        static Queue<int> QueueMode(Queue<int> queue, int floor)
        {
            queue.Enqueue(floor);
            Console.WriteLine($"В queue добавлен {floor}");
            return queue;
        }

        static Stack<int> StackMode(Stack<int> stack, int floor)
        {
            stack.Push(floor);
            Console.WriteLine($"В stack добавлен {floor}");
            return stack;
        }
    }
}



