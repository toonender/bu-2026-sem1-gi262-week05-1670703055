using UnityEngine;
using System.Reflection;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace Assignment
{
    public class StudentSolution : IAssignment
    {
        #region Lecture
        public int[] LCT01_SelectionSortAscending(int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[j] < numbers[minIndex])
                    {
                        minIndex = j;
                    }
                }
                (numbers[i], numbers[minIndex]) = (numbers[minIndex], numbers[i]);
            }
            return numbers;
        }

        public int[] LCT02_BubbleSortAscending(int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = 0; j < numbers.Length - 1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        (numbers[j], numbers[j + 1]) = (numbers[j + 1], numbers[j]);
                    }
                }
            }
            return numbers;
        }

        public int[] LCT03_InsertionSortAscending(int[] numbers)
        {
            for (int i = 1; i < numbers.Length; i++)
            {
                int key = numbers[i];
                int j = i - 1;
                while (numbers[j] > key && j > 0)
                {
                    numbers[j + 1] = numbers[j];
                    j--;
                }
                numbers[j + 1] = key;
            }
            return numbers;
        }

        #endregion

        #region Assignment

        public int[] AS01_SelectionSortDescending(int[] numbers)
        {
            int[] sortedNumbers = (int[])numbers.Clone();

            for (int currentPosition = 0; currentPosition < sortedNumbers.Length - 1; currentPosition++)
            {
                int largestNumberIndex = currentPosition;

                for (int searchIndex = currentPosition + 1; searchIndex < sortedNumbers.Length; searchIndex++)
                {
                    if (sortedNumbers[searchIndex] > sortedNumbers[largestNumberIndex])
                    {
                        largestNumberIndex = searchIndex;
                    }
                }

                int currentNumber = sortedNumbers[currentPosition];
                sortedNumbers[currentPosition] = sortedNumbers[largestNumberIndex];
                sortedNumbers[largestNumberIndex] = currentNumber;
            }

            foreach (int number in sortedNumbers)
            {
                Debug.Log(number);
            }

            return sortedNumbers;
        }

        public int[] AS02_BubbleSortDescending(int[] numbers)
        {
            int[] sortedNumbers = (int[])numbers.Clone();

            for (int pass = 0; pass < sortedNumbers.Length - 1; pass++)
            {
                for (int currentIndex = 0; currentIndex < sortedNumbers.Length - 1 - pass; currentIndex++)
                {
                    if (sortedNumbers[currentIndex] < sortedNumbers[currentIndex + 1])
                    {
                        int temporaryNumber = sortedNumbers[currentIndex];
                        sortedNumbers[currentIndex] = sortedNumbers[currentIndex + 1];
                        sortedNumbers[currentIndex + 1] = temporaryNumber;
                    }
                }
            }

            foreach (int number in sortedNumbers)
            {
                Debug.Log(number);
            }
            return sortedNumbers;
        }

        public int[] AS03_InsertionSortDescending(int[] numbers)
        {
            int[] sortedNumbers = (int[])numbers.Clone();

            for (int currentIndex = 1; currentIndex < sortedNumbers.Length; currentIndex++)
            {
                int numberToInsert = sortedNumbers[currentIndex];
                int searchIndex = currentIndex - 1;

                while (searchIndex >= 0 && sortedNumbers[searchIndex] < numberToInsert)
                {
                    sortedNumbers[searchIndex + 1] = sortedNumbers[searchIndex];
                    searchIndex--;
                }

                sortedNumbers[searchIndex + 1] = numberToInsert;
            }

            foreach (int number in sortedNumbers)
            {
                Debug.Log(number);
            }

            return sortedNumbers;
        }

        public int AS04_FindTheSecondLargestNumber(int[] numbers)
        {
            if (numbers.Length < 2)
            {
                return 0;
            }

            int largestNumber = int.MinValue;
            int secondLargestNumber = int.MinValue;
            bool hasLargestNumber = false;
            bool hasSecondLargestNumber = false;

            foreach (int number in numbers)
            {
                if (!hasLargestNumber)
                {
                    largestNumber = number;
                    hasLargestNumber = true;
                }
                else if (number > largestNumber)
                {
                    secondLargestNumber = largestNumber;
                    hasSecondLargestNumber = true;
                    largestNumber = number;
                }
                else if (number < largestNumber &&
                         (!hasSecondLargestNumber || number > secondLargestNumber))
                {
                    secondLargestNumber = number;
                    hasSecondLargestNumber = true;
                }
            }

            if (!hasSecondLargestNumber)
            {
                return 0;
            }

            Debug.Log(secondLargestNumber);
            return secondLargestNumber;
        }

        #endregion

        #region Extra

        public int EX01_FindLongestConsecutiveSequence(int[] numbers)
        {
            return 0;
        }

        #endregion
    }
}