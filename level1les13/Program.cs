﻿using System;
using System.Collections.Generic;

namespace Level1Space
{
    public static class Level1
    {
        public static int Unmanned(int L, int N, int[][] track)
        {
           
            int time = 0;
            int way = 0;
            bool flag = true;
            if (N != track.Length)
            {
                Console.WriteLine("initial condition is not correct");
                return 0;
            }

            for (int i = 1; i < track.Length; i++)
            {
                if (track[i][0] < track[i-1][0])
                {
                    Console.WriteLine("initial condition is not correct");
                    return 0;
                }
            }
            for (int i = 0; i < track.Length; i++)
            {
                if (L < track[i][0])
                {
                    Console.WriteLine("initial condition is not correct");
                    return 0;
                }
            }

            for (int i = 0; i < track.Length; i++)
            {
                flag = true;
                time = time + track[i][0] - way;
                if (time < track[i][1])
                {
                    time = track[i][1];
                    flag = false;
                }

                if ((flag) && ((time) % (track[i][1] + track[i][2]) < track[i][1]))
                {
                    time = time + track[i][1] - ((time) % (track[i][1] + track[i][2]));
                }

                way = track[i][0];

            }

            if (way < L) time = time + L - way;

            return time;
        }

        //static void Main(string[] args)
        //{
        //    int L = 10;
        //    int N = 2;
        //    int[][] track = new int[N][];
        //    track[0] = new int[3] { 10, 3, 5 };
        //    track[1] = new int[3] { 1, 5, 10 };
        //    Console.WriteLine(7 % 13);
        //    int time = Unmanned(L, N, track);
           
        //    Console.WriteLine(time);
        //}
    }
}