using System;
using System.Collections.Generic;

namespace Exam01
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] sub = new float[3];
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Nhap diem mon {i+1}: ");
                sub[i] = float.Parse(Console.ReadLine());
            }
            //Dictionary
            Dictionary<char, float> dkv = new Dictionary<char, float>()
            {
                {'A',2 },
                {'B',1 },
                {'C',0.5f }
            };
            float[] ddt = { 2.5f, 1.5f, 1 };
            
            Console.Write("Moi ban chon khu vuc (A,B,C): ");
            char kv = char.Parse(Console.ReadLine().ToUpper());
            Console.Write("Chon doi tuong: (1,2,3): ");
            int dt = int.Parse(Console.ReadLine());
            Console.Write("Nhap diem chuan: ");
            float s = sub[0] + sub[1] + sub[2] + dkv[kv]+ddt[dt];
            float dc = float.Parse(Console.ReadLine());
            Dictionary<bool, string> rs = new Dictionary<bool, string>()
            {
                {true,"Dau" },
                {false,"Chuc ban may man lan sau" }
            };
            Console.WriteLine($"Ket qua: {rs[s >= dc]}");
            
        }
    }
}
