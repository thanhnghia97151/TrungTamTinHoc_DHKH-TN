using System;

namespace Exam01_Enum
{
    class Program
    {
        enum DayOfWeek
        {
            Monday,
            Tuesday,
            Wednday
        }
        //Hàm sắp sếp tăng dẩn
        static void SortAcsending(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i+1; j < a.Length; j++)
                {
                    if (a[i]>a[j])
                    {
                        int t = a[i];
                        a[i] = a[j];
                        a[j] = t;
                    }
                }
            }
        }
        static void SortDecending(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] < a[j])
                    {
                        int t = a[i];
                        a[i] = a[j];
                        a[j] = t;
                    }
                }
            }
        }
        static void Sort(int[] a, SortType sortType = SortType.Ascending)
        {
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i+1; j < a.Length; j++)
                {
                    switch (sortType)
                    {
                        case SortType.Ascending:
                            if (a[i]>a[j])
                            {
                                int t = a[i];
                                a[i] = a[j];
                                a[j] = t;
                            }
                            break;
                        case SortType.Descending:
                            if (a[i] < a[j])
                            {
                                int t = a[i];
                                a[i] = a[j];
                                a[j] = t;
                            }
                            break;
                        default:
                            break;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            
        }
    }
}
