﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncNet6
{
    public class Example1
    {
        //await callMethod();
        //Console.ReadKey();
        static async Task callMethod()
        {
            Method2();
            var count = await Method1();
            Method3(count);
        }

        static async Task<int> Method1()
        {
            int count = 0;
            await Task.Run(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine(" Method 1");
                    count += 1;
                }
            });
            return count;
        }

        static void Method2()
        {
            for (int i = 0; i < 25; i++)
            {
                Console.WriteLine(" Method 2");
            }
        }

        static void Method3(int count)
        {
            Console.WriteLine("Total count is " + count);
        }
    }

}
